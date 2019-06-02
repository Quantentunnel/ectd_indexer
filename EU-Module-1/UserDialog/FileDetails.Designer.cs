namespace eCTD_indexer.UserDialog
{
    partial class FileDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileDetails));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbCurrentStatusOld = new System.Windows.Forms.TextBox();
            this.cbCurrentStatus = new System.Windows.Forms.ComboBox();
            this.tbCurrentSequenceNumber = new System.Windows.Forms.TextBox();
            this.tbCurrentSHA256 = new System.Windows.Forms.TextBox();
            this.tbCurrentFilename = new System.Windows.Forms.TextBox();
            this.tbCurrentPath = new System.Windows.Forms.TextBox();
            this.tbCurrentID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lVirtual = new System.Windows.Forms.Label();
            this.btSelectCorrespondingFile = new System.Windows.Forms.Button();
            this.tbCorrespondingStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCorrespondingSequenceNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCorrespondingSHA256 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbCorrespondingFilemame = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbCorrespondingPath = new System.Windows.Forms.TextBox();
            this.tbCorrespondingID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btOK = new System.Windows.Forms.ToolStripButton();
            this.btCancel = new System.Windows.Forms.ToolStripButton();
            this.btPinWindow = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.tbCurrentStatusOld);
            this.splitContainer1.Panel1.Controls.Add(this.cbCurrentStatus);
            this.splitContainer1.Panel1.Controls.Add(this.tbCurrentSequenceNumber);
            this.splitContainer1.Panel1.Controls.Add(this.tbCurrentSHA256);
            this.splitContainer1.Panel1.Controls.Add(this.tbCurrentFilename);
            this.splitContainer1.Panel1.Controls.Add(this.tbCurrentPath);
            this.splitContainer1.Panel1.Controls.Add(this.tbCurrentID);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.checkBox1);
            this.splitContainer1.Panel2.Controls.Add(this.lVirtual);
            this.splitContainer1.Panel2.Controls.Add(this.btSelectCorrespondingFile);
            this.splitContainer1.Panel2.Controls.Add(this.tbCorrespondingStatus);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.tbCorrespondingSequenceNumber);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.tbCorrespondingSHA256);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.tbCorrespondingFilemame);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.tbCorrespondingPath);
            this.splitContainer1.Panel2.Controls.Add(this.tbCorrespondingID);
            this.splitContainer1.Panel2.Controls.Add(this.label13);
            this.splitContainer1.Panel2.Controls.Add(this.label14);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(1084, 412);
            this.splitContainer1.SplitterDistance = 542;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eCTD_indexer.Properties.Resources.Actions_go_next_icon;
            this.pictureBox1.Location = new System.Drawing.Point(280, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // tbCurrentStatusOld
            // 
            this.tbCurrentStatusOld.Enabled = false;
            this.tbCurrentStatusOld.Location = new System.Drawing.Point(122, 212);
            this.tbCurrentStatusOld.Name = "tbCurrentStatusOld";
            this.tbCurrentStatusOld.Size = new System.Drawing.Size(152, 20);
            this.tbCurrentStatusOld.TabIndex = 13;
            // 
            // cbCurrentStatus
            // 
            this.cbCurrentStatus.FormattingEnabled = true;
            this.cbCurrentStatus.Location = new System.Drawing.Point(354, 212);
            this.cbCurrentStatus.Name = "cbCurrentStatus";
            this.cbCurrentStatus.Size = new System.Drawing.Size(165, 21);
            this.cbCurrentStatus.TabIndex = 12;
            // 
            // tbCurrentSequenceNumber
            // 
            this.tbCurrentSequenceNumber.Enabled = false;
            this.tbCurrentSequenceNumber.Location = new System.Drawing.Point(122, 245);
            this.tbCurrentSequenceNumber.Name = "tbCurrentSequenceNumber";
            this.tbCurrentSequenceNumber.Size = new System.Drawing.Size(397, 20);
            this.tbCurrentSequenceNumber.TabIndex = 11;
            // 
            // tbCurrentSHA256
            // 
            this.tbCurrentSHA256.Enabled = false;
            this.tbCurrentSHA256.Location = new System.Drawing.Point(122, 179);
            this.tbCurrentSHA256.Name = "tbCurrentSHA256";
            this.tbCurrentSHA256.Size = new System.Drawing.Size(397, 20);
            this.tbCurrentSHA256.TabIndex = 10;
            // 
            // tbCurrentFilename
            // 
            this.tbCurrentFilename.Location = new System.Drawing.Point(122, 146);
            this.tbCurrentFilename.Name = "tbCurrentFilename";
            this.tbCurrentFilename.Size = new System.Drawing.Size(397, 20);
            this.tbCurrentFilename.TabIndex = 9;
            // 
            // tbCurrentPath
            // 
            this.tbCurrentPath.Enabled = false;
            this.tbCurrentPath.Location = new System.Drawing.Point(122, 113);
            this.tbCurrentPath.Name = "tbCurrentPath";
            this.tbCurrentPath.Size = new System.Drawing.Size(397, 20);
            this.tbCurrentPath.TabIndex = 8;
            // 
            // tbCurrentID
            // 
            this.tbCurrentID.Enabled = false;
            this.tbCurrentID.Location = new System.Drawing.Point(122, 75);
            this.tbCurrentID.Name = "tbCurrentID";
            this.tbCurrentID.Size = new System.Drawing.Size(397, 20);
            this.tbCurrentID.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Seqence Number :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Status :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "SHA256 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Filename :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Path :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Info of this Sequence";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(118, 281);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lVirtual
            // 
            this.lVirtual.AutoSize = true;
            this.lVirtual.Location = new System.Drawing.Point(14, 281);
            this.lVirtual.Name = "lVirtual";
            this.lVirtual.Size = new System.Drawing.Size(55, 13);
            this.lVirtual.TabIndex = 20;
            this.lVirtual.Text = "Is virtual ?";
            // 
            // btSelectCorrespondingFile
            // 
            this.btSelectCorrespondingFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelectCorrespondingFile.Location = new System.Drawing.Point(117, 325);
            this.btSelectCorrespondingFile.Name = "btSelectCorrespondingFile";
            this.btSelectCorrespondingFile.Size = new System.Drawing.Size(397, 40);
            this.btSelectCorrespondingFile.TabIndex = 19;
            this.btSelectCorrespondingFile.Text = "Select Corresponding File";
            this.btSelectCorrespondingFile.UseVisualStyleBackColor = true;
            this.btSelectCorrespondingFile.Click += new System.EventHandler(this.btSelectCorrespondingFile_Click);
            // 
            // tbCorrespondingStatus
            // 
            this.tbCorrespondingStatus.Enabled = false;
            this.tbCorrespondingStatus.FormattingEnabled = true;
            this.tbCorrespondingStatus.Location = new System.Drawing.Point(117, 212);
            this.tbCorrespondingStatus.Name = "tbCorrespondingStatus";
            this.tbCorrespondingStatus.Size = new System.Drawing.Size(397, 21);
            this.tbCorrespondingStatus.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Seqence Number :";
            // 
            // tbCorrespondingSequenceNumber
            // 
            this.tbCorrespondingSequenceNumber.Enabled = false;
            this.tbCorrespondingSequenceNumber.Location = new System.Drawing.Point(117, 245);
            this.tbCorrespondingSequenceNumber.Name = "tbCorrespondingSequenceNumber";
            this.tbCorrespondingSequenceNumber.Size = new System.Drawing.Size(397, 20);
            this.tbCorrespondingSequenceNumber.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Status :";
            // 
            // tbCorrespondingSHA256
            // 
            this.tbCorrespondingSHA256.Enabled = false;
            this.tbCorrespondingSHA256.Location = new System.Drawing.Point(117, 179);
            this.tbCorrespondingSHA256.Name = "tbCorrespondingSHA256";
            this.tbCorrespondingSHA256.Size = new System.Drawing.Size(397, 20);
            this.tbCorrespondingSHA256.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "SHA256 :";
            // 
            // tbCorrespondingFilemame
            // 
            this.tbCorrespondingFilemame.Enabled = false;
            this.tbCorrespondingFilemame.Location = new System.Drawing.Point(117, 146);
            this.tbCorrespondingFilemame.Name = "tbCorrespondingFilemame";
            this.tbCorrespondingFilemame.Size = new System.Drawing.Size(397, 20);
            this.tbCorrespondingFilemame.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Filename :";
            // 
            // tbCorrespondingPath
            // 
            this.tbCorrespondingPath.Enabled = false;
            this.tbCorrespondingPath.Location = new System.Drawing.Point(117, 113);
            this.tbCorrespondingPath.Name = "tbCorrespondingPath";
            this.tbCorrespondingPath.Size = new System.Drawing.Size(397, 20);
            this.tbCorrespondingPath.TabIndex = 14;
            // 
            // tbCorrespondingID
            // 
            this.tbCorrespondingID.Enabled = false;
            this.tbCorrespondingID.Location = new System.Drawing.Point(117, 75);
            this.tbCorrespondingID.Name = "tbCorrespondingID";
            this.tbCorrespondingID.Size = new System.Drawing.Size(397, 20);
            this.tbCorrespondingID.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Path :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "File Info of the Corresponding Sequence";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btOK,
            this.btCancel,
            this.btPinWindow});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1084, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btOK
            // 
            this.btOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btOK.Image = global::eCTD_indexer.Properties.Resources.Actions_dialog_ok_apply_icon;
            this.btOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(23, 22);
            this.btOK.Text = "Save & Close";
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btCancel.Image = global::eCTD_indexer.Properties.Resources.Actions_edit_delete_icon;
            this.btCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(23, 22);
            this.btCancel.Text = "Cancel";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btPinWindow
            // 
            this.btPinWindow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btPinWindow.Image = global::eCTD_indexer.Properties.Resources.Status_object_unlocked_icon;
            this.btPinWindow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btPinWindow.Name = "btPinWindow";
            this.btPinWindow.Size = new System.Drawing.Size(23, 22);
            this.btPinWindow.Text = "Pin this Winow";
            this.btPinWindow.Click += new System.EventHandler(this.btPinWindow_Click);
            // 
            // FileDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 412);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileDetails";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Details";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btOK;
        private System.Windows.Forms.ToolStripButton btCancel;
        private System.Windows.Forms.ToolStripButton btPinWindow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbCurrentStatus;
        private System.Windows.Forms.TextBox tbCurrentSequenceNumber;
        private System.Windows.Forms.TextBox tbCurrentSHA256;
        private System.Windows.Forms.TextBox tbCurrentFilename;
        private System.Windows.Forms.TextBox tbCurrentPath;
        private System.Windows.Forms.TextBox tbCurrentID;
        private System.Windows.Forms.ComboBox tbCorrespondingStatus;
        private System.Windows.Forms.TextBox tbCorrespondingSequenceNumber;
        private System.Windows.Forms.TextBox tbCorrespondingSHA256;
        private System.Windows.Forms.TextBox tbCorrespondingFilemame;
        private System.Windows.Forms.TextBox tbCorrespondingPath;
        private System.Windows.Forms.TextBox tbCorrespondingID;
        private System.Windows.Forms.Button btSelectCorrespondingFile;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lVirtual;
        private System.Windows.Forms.TextBox tbCurrentStatusOld;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}