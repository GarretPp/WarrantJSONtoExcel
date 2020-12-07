using ClosedXML.Excel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarrantJSONtoExcel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            dialogWarrantDataFile.ShowDialog();
           
        }

        private void btnSelectExportFolder_Click(object sender, EventArgs e)
        {
            dialogSaveFile.ShowDialog();

        }

        private void btnProcessData_Click(object sender, EventArgs e)
        {
            if (tbJSONData.Text != "" && dialogSaveFile.FileName != "")
            {
                pBar.Maximum = 100;
                pBar.Minimum = 0;
                pBar.Step = 1;
                btnProcessData.Enabled = false;
                backgroundWorkerProcessData.RunWorkerAsync();
            } else if (tbJSONData.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("No Warrant JSON Data Loaded...");
            }
        }

        private void mainMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backgroundWorkerProcessData_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            //workbook to add table data into
            var wb = new XLWorkbook();
            DataTable WarrantDT = new DataTable();
            WarrantDT.TableName = "Warrants";
            WarrantDT.Columns.Add("Index", typeof(string));
            WarrantDT.Columns.Add("STATUS", typeof(string));
            WarrantDT.Columns.Add("DISPLAY NUMBER", typeof(string));
            WarrantDT.Columns.Add("CIV ID", typeof(string));
            WarrantDT.Columns.Add("FirstName", typeof(string));
            WarrantDT.Columns.Add("LastName", typeof(string));
            WarrantDT.Columns.Add("DOB", typeof(string));
            WarrantDT.Columns.Add("Sex", typeof(string));
            WarrantDT.Columns.Add("CreatedDate", typeof(string));
            WarrantDT.Columns.Add("Warrant Type", typeof(string));
            WarrantDT.Columns.Add("Charges", typeof(string));
            WarrantDT.Columns.Add("Evidence", typeof(string));
            WarrantDT.Columns.Add("Requester", typeof(string));
            WarrantDT.Columns.Add("CreatedBy", typeof(string));
            WarrantDT.Columns.Add("CreatedByWebID", typeof(string));
            WarrantDT.Columns.Add("CreatedByDeptTag", typeof(string));
            WarrantDT.Columns.Add("MagistrateName", typeof(string));
            WarrantDT.Columns.Add("MagistrateWebID", typeof(string));
            WarrantDT.Columns.Add("ApprovedDate", typeof(string));


            JArray JSONData = JArray.Parse(tbJSONData.Text);

            //Stuff for progress bar
            int MaximumValue = JSONData.Count();
            int Value = 0;

            foreach (JObject x in JSONData.Reverse())
            {
                Value++;
                worker.ReportProgress((Value/MaximumValue)*100);

                //check if DEPT info is present, if not lists as JS
                dynamic department = "";
                try
                {
                    department = x["requestingDepartment"]["departmentTag"];
                }
                catch (InvalidOperationException)
                {
                    department = "JS";
                }


                WarrantDT.Rows.Add(x["warrantId"],
                    x["warrantStatus"],
                    x["displayNumber"],
                    x["character"]["userId"],
                    x["character"]["firstName"],
                    x["character"]["lastName"],
                    x["character"]["dateOfBirth"],
                    x["character"]["gender"],
                    x["createdAtUTC"],
                    x["warrantType"]["title"],
                    x["charges"],
                    x["warrantEvidence"],
                    x["requestingOfficer"],
                    x["createdByUserInfo"]["name"],
                    x["createdByUserInfo"]["websiteId"],
                    department,
                    x["approvedByUserInfo"]["name"],
                    x["approvedByUserInfo"]["websiteId"],
                    x["approvedAtUTC"]);


            }

            //Adds datatable to worksheet on Excel
            wb.Worksheets.Add(WarrantDT);
            wb.SaveAs(dialogSaveFile.FileName);
            
        }

        private void backgroundWorkerProcessData_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pBar.Value = e.ProgressPercentage;
        }

        private void backgroundWorkerProcessData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pBar.Value = 0;
            btnProcessData.Enabled = true;
            if (cbIsOpenFileWhenDone.Checked)
            {
                System.Diagnostics.Process.Start(dialogSaveFile.FileName);
            }
            if (cbIsOpenFolderWhenDone.Checked)
            {
                System.Diagnostics.Process.Start("explorer.exe", Path.GetDirectoryName(dialogSaveFile.FileName));
            }
            if (!cbIsOpenFolderWhenDone.Checked && !cbIsOpenFileWhenDone.Checked)
            {
                System.Windows.Forms.MessageBox.Show("Processing Complete");
            }
        }

        private void cbIsCopyJSONtoFile_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsCopyJSONtoFile.Checked)
            {
                btnSelectJSONOutput.Visible = true;
                btnSaveJSONData.Visible = true;
                pBarJSONSave.Visible = true;
            } else
            {
                btnSelectJSONOutput.Visible = false;
                btnSaveJSONData.Visible = false;
                pBarJSONSave.Visible = false;
            }
        }

        private void btnSelectJSONOutput_Click(object sender, EventArgs e)
        {
            dialogSaveJSONFileOutput.ShowDialog();
            if(dialogSaveJSONFileOutput.FileName != "")
            {
                btnSaveJSONData.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundSaveJSONData_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            System.IO.File.WriteAllText(dialogSaveJSONFileOutput.FileName, tbJSONData.Text);
        }

        private void btnSaveJSONData_Click(object sender, EventArgs e)
        {
            btnSaveJSONData.Enabled = false;
            pBarJSONSave.Style = ProgressBarStyle.Marquee;
            pBarJSONSave.MarqueeAnimationSpeed = 100;
            backgroundSaveJSONData.RunWorkerAsync();
        }

        private void backgroundSaveJSONData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pBarJSONSave.Style = ProgressBarStyle.Continuous;
            pBarJSONSave.MarqueeAnimationSpeed = 0;
            btnSaveJSONData.Enabled = true;
            dialogWarrantDataFile.FileName = dialogSaveJSONFileOutput.FileName;

            if (cbIsOpenFolderWhenDone.Checked)
            {
                System.Diagnostics.Process.Start("explorer.exe", Path.GetDirectoryName(dialogSaveJSONFileOutput.FileName));
            }
            if (!cbIsOpenFolderWhenDone.Checked && !cbIsOpenFileWhenDone.Checked)
            {
                System.Windows.Forms.MessageBox.Show("Processing Complete");
            }
        }

        private void lblCreatedByLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/GarretPp");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabController.SelectTab(tabHelp);
        }

        private void tabProcess_Click(object sender, EventArgs e)
        {

        }

        private void dialogSaveFile_FileOk(object sender, CancelEventArgs e)
        {
            if (dialogSaveFile.FileName != "")
            {
                lblExportFolderVariable.Text = dialogSaveFile.FileName;
                btnProcessData.Enabled = true;
            }
        }

        private void dialogWarrantDataFile_FileOk(object sender, CancelEventArgs e)
        {
            if (dialogWarrantDataFile.FileName != "")
            {
                lblFileLocationVariable.Text = dialogWarrantDataFile.FileName;
                //pulls data from selected JSON file and converts to a string
                using (StreamReader r = new StreamReader(dialogWarrantDataFile.FileName))
                {
                    tbJSONData.Text = r.ReadToEnd();
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblExportFolder_Click(object sender, EventArgs e)
        {

        }

        private void lblJSONFileLocationDesc_Click(object sender, EventArgs e)
        {

        }
    }
}
