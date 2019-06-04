using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eCTD_indexer.UserDialog
{
    public partial class FileDetails : Form
    {
        public FileDetails()
        {
            InitializeComponent();
        }

        public FileDetails(Database.LifecycleData data, Database.DB_Access db)
        {
            InitializeComponent();

            // Store lifecycele data in internal variable
            this.lifecycle = data;
            this.dba = db;

            // Set Status
            this.cbCurrentStatus.Items.AddRange(new object[] {
                        "new",
                        "append",
                        "replace",
                        "delete"});
            this.cbCurrentStatus.Text = this.lifecycle.LifecycleAction;

            // Set the rest of the current data
            this.tbCurrentPath.Text = this.lifecycle.Path;
            this.tbCurrentFilename.Text = this.lifecycle.Filename;
            this.tbCurrentSHA256.Text = this.lifecycle.SHA256;
            this.tbCurrentSequenceNumber.Text = MainWindow.me.SeqNumber;
            this.tbCurrentStatusOld.Text = this.dba.getFileStatus(this.lifecycle.Path, this.lifecycle.Filename);
            this.tbCurrentID.Text = lifecycle.ID;

            // Set Tooltip
            ToolTip t = new ToolTip();
            t.SetToolTip(this.lVirtual, "If the data is only stored in the database, then the info is virtual. The data is not there to proof these infos.");
        }

        // Internal variables
        private Database.LifecycleData lifecycle;
        private Database.DB_Access dba;

        private void btOK_Click(object sender, EventArgs e)
        {
            this.dba.setLifecycleStatus(this.lifecycle);
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPinWindow_Click(object sender, EventArgs e)
        {
            if(this.TopMost)
            {
                this.TopMost = false;
                this.btPinWindow.Image = Properties.Resources.Status_object_unlocked_icon;
            }
            else
            {
                this.TopMost = true;
                this.btPinWindow.Image = Properties.Resources.Status_object_locked_icon;
            }
        }

        private void btSelectCorrespondingFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "pdf files (*.pdf)|*.pdf";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the Filename and Path to it
                    String CorrespondingFile = openFileDialog.FileName;
                    String PathAndFile = this.lifecycle.Path + "\\" + this.lifecycle.Filename;

                    // Find the eu-regional.xml file to detect the information about the corresponding sequence
                    String [] CompareFilepath = Toolbox.StartsWithTheSameSubstring(CorrespondingFile, PathAndFile);


                    // Search for the file in the database to get the status etc.

                }
            }
        }


    }
}
