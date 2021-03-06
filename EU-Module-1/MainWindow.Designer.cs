//eCTD indexer (EU Module 1)
//Copyright 2007-2016 Ymir Vesteinsson, ymir@ectd.is

//This file is part of eCTD-indexer.

//eCTD-indexer is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//eCTD-indexer is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with eCTD-indexer.  If not, see <http://www.gnu.org/licenses/>.

namespace eCTD_indexer
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbCreate = new System.Windows.Forms.ToolStripButton();
            this.tsbOpenDossier = new System.Windows.Forms.ToolStripButton();
            this.tsbOpenLastDossier = new System.Windows.Forms.ToolStripButton();
            this.tsbAdoptInformation = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteEmptyFolder = new System.Windows.Forms.ToolStripButton();
            this.tsbCreateXMLFiles = new System.Windows.Forms.ToolStripButton();
            this.tsbDiagnostic = new System.Windows.Forms.ToolStripButton();
            this.tsbPackDossier = new System.Windows.Forms.ToolStripButton();
            this.tsbAssemble = new System.Windows.Forms.ToolStripButton();
            this.tsbRefreshFolderView = new System.Windows.Forms.ToolStripButton();
            this.tsbCloseDossier = new System.Windows.Forms.ToolStripButton();
            this.tsbOptions = new System.Windows.Forms.ToolStripButton();
            this.tsbCloseApp = new System.Windows.Forms.ToolStripButton();
            this.tsbAbout = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDossierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDossierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLastDossierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbiCloseDossier = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbideleteAllEmptyDirectoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeValidationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fileNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createXMLFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zipDossierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbSubmissionUnitCopy = new System.Windows.Forms.PictureBox();
            this.pbSubDescCopy = new System.Windows.Forms.PictureBox();
            this.pbRelSeqCopy = new System.Windows.Forms.PictureBox();
            this.pbModeCopy = new System.Windows.Forms.PictureBox();
            this.pbSubmissionTypeCopy = new System.Windows.Forms.PictureBox();
            this.pbProcedureTypeCopy = new System.Windows.Forms.PictureBox();
            this.pbNumberCopy = new System.Windows.Forms.PictureBox();
            this.pbTrackingNoCopy = new System.Windows.Forms.PictureBox();
            this.pbINNCopy = new System.Windows.Forms.PictureBox();
            this.pbIdentifierCopy = new System.Windows.Forms.PictureBox();
            this.tbIdentifier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxIS = new System.Windows.Forms.TextBox();
            this.textBoxDE2App = new System.Windows.Forms.TextBox();
            this.textBoxIE = new System.Windows.Forms.TextBox();
            this.textBoxTrackNo = new System.Windows.Forms.TextBox();
            this.textBoxHU = new System.Windows.Forms.TextBox();
            this.textBoxDE2 = new System.Windows.Forms.TextBox();
            this.textBoxIT = new System.Windows.Forms.TextBox();
            this.textBoxEL = new System.Windows.Forms.TextBox();
            this.checkBoxDE2 = new System.Windows.Forms.CheckBox();
            this.textBoxLV = new System.Windows.Forms.TextBox();
            this.comboBoxProcType = new System.Windows.Forms.ComboBox();
            this.textBoxDE = new System.Windows.Forms.TextBox();
            this.textBoxHRApp = new System.Windows.Forms.TextBox();
            this.textBoxLI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFR = new System.Windows.Forms.TextBox();
            this.textBoxHR = new System.Windows.Forms.TextBox();
            this.textBoxLT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFI = new System.Windows.Forms.TextBox();
            this.checkBoxHR = new System.Windows.Forms.CheckBox();
            this.textBoxLU = new System.Windows.Forms.TextBox();
            this.comboBoxSubmType = new System.Windows.Forms.ComboBox();
            this.textBoxED = new System.Windows.Forms.TextBox();
            this.textBoxMT = new System.Windows.Forms.TextBox();
            this.textBoxEU = new System.Windows.Forms.TextBox();
            this.labelSequence = new System.Windows.Forms.Label();
            this.textBoxNL = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxEE = new System.Windows.Forms.TextBox();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.textBoxNO = new System.Windows.Forms.TextBox();
            this.textBoxINN = new System.Windows.Forms.TextBox();
            this.textBoxDK = new System.Windows.Forms.TextBox();
            this.comboBoxSubmUnit = new System.Windows.Forms.ComboBox();
            this.textBoxPL = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxCZ = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxPT = new System.Windows.Forms.TextBox();
            this.labelSubmissionUnit = new System.Windows.Forms.Label();
            this.textBoxCY = new System.Windows.Forms.TextBox();
            this.textBoxRO = new System.Windows.Forms.TextBox();
            this.textBoxSubmDescr = new System.Windows.Forms.TextBox();
            this.textBoxBG = new System.Windows.Forms.TextBox();
            this.textBoxSK = new System.Windows.Forms.TextBox();
            this.textBoxBE = new System.Windows.Forms.TextBox();
            this.textBoxSI = new System.Windows.Forms.TextBox();
            this.checkBoxUK = new System.Windows.Forms.CheckBox();
            this.textBoxES = new System.Windows.Forms.TextBox();
            this.checkBoxSE = new System.Windows.Forms.CheckBox();
            this.textBoxSE = new System.Windows.Forms.TextBox();
            this.checkBoxES = new System.Windows.Forms.CheckBox();
            this.textBoxRelSeq = new System.Windows.Forms.TextBox();
            this.textBoxUK = new System.Windows.Forms.TextBox();
            this.checkBoxSI = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxSK = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxRO = new System.Windows.Forms.CheckBox();
            this.textBoxATApp = new System.Windows.Forms.TextBox();
            this.checkBoxPT = new System.Windows.Forms.CheckBox();
            this.textBoxBEApp = new System.Windows.Forms.TextBox();
            this.checkBoxPL = new System.Windows.Forms.CheckBox();
            this.textBoxUKApp = new System.Windows.Forms.TextBox();
            this.textBoxBGApp = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.checkBoxNO = new System.Windows.Forms.CheckBox();
            this.textBoxSEApp = new System.Windows.Forms.TextBox();
            this.textBoxCYApp = new System.Windows.Forms.TextBox();
            this.checkBoxAT = new System.Windows.Forms.CheckBox();
            this.checkBoxNL = new System.Windows.Forms.CheckBox();
            this.textBoxESApp = new System.Windows.Forms.TextBox();
            this.textBoxCZApp = new System.Windows.Forms.TextBox();
            this.checkBoxBE = new System.Windows.Forms.CheckBox();
            this.checkBoxMT = new System.Windows.Forms.CheckBox();
            this.textBoxSIApp = new System.Windows.Forms.TextBox();
            this.textBoxDKApp = new System.Windows.Forms.TextBox();
            this.checkBoxBG = new System.Windows.Forms.CheckBox();
            this.checkBoxLU = new System.Windows.Forms.CheckBox();
            this.textBoxSKApp = new System.Windows.Forms.TextBox();
            this.textBoxEEApp = new System.Windows.Forms.TextBox();
            this.checkBoxCY = new System.Windows.Forms.CheckBox();
            this.checkBoxLT = new System.Windows.Forms.CheckBox();
            this.textBoxROApp = new System.Windows.Forms.TextBox();
            this.textBoxEUApp = new System.Windows.Forms.TextBox();
            this.checkBoxCZ = new System.Windows.Forms.CheckBox();
            this.textBoxAT = new System.Windows.Forms.TextBox();
            this.textBoxPTApp = new System.Windows.Forms.TextBox();
            this.textBoxEDApp = new System.Windows.Forms.TextBox();
            this.checkBoxDK = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxPLApp = new System.Windows.Forms.TextBox();
            this.textBoxFIApp = new System.Windows.Forms.TextBox();
            this.checkBoxEE = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxNOApp = new System.Windows.Forms.TextBox();
            this.textBoxFRApp = new System.Windows.Forms.TextBox();
            this.checkBoxED = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxNLApp = new System.Windows.Forms.TextBox();
            this.textBoxDEApp = new System.Windows.Forms.TextBox();
            this.checkBoxEU = new System.Windows.Forms.CheckBox();
            this.checkBoxLI = new System.Windows.Forms.CheckBox();
            this.textBoxMTApp = new System.Windows.Forms.TextBox();
            this.textBoxELApp = new System.Windows.Forms.TextBox();
            this.checkBoxFI = new System.Windows.Forms.CheckBox();
            this.checkBoxLV = new System.Windows.Forms.CheckBox();
            this.textBoxLUApp = new System.Windows.Forms.TextBox();
            this.textBoxHUApp = new System.Windows.Forms.TextBox();
            this.checkBoxFR = new System.Windows.Forms.CheckBox();
            this.checkBoxIT = new System.Windows.Forms.CheckBox();
            this.textBoxLTApp = new System.Windows.Forms.TextBox();
            this.textBoxISApp = new System.Windows.Forms.TextBox();
            this.checkBoxDE = new System.Windows.Forms.CheckBox();
            this.checkBoxIE = new System.Windows.Forms.CheckBox();
            this.textBoxLIApp = new System.Windows.Forms.TextBox();
            this.textBoxIEApp = new System.Windows.Forms.TextBox();
            this.checkBoxEL = new System.Windows.Forms.CheckBox();
            this.checkBoxIS = new System.Windows.Forms.CheckBox();
            this.textBoxLVApp = new System.Windows.Forms.TextBox();
            this.textBoxITApp = new System.Windows.Forms.TextBox();
            this.checkBoxHU = new System.Windows.Forms.CheckBox();
            this.fileExplorerUserControl = new eCTD_indexer.FileExplorerUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubmissionUnitCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubDescCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRelSeqCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbModeCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubmissionTypeCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProcedureTypeCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNumberCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrackingNoCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbINNCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIdentifierCopy)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.fileExplorerUserControl);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pbSubmissionUnitCopy);
            this.splitContainer1.Panel2.Controls.Add(this.pbSubDescCopy);
            this.splitContainer1.Panel2.Controls.Add(this.pbRelSeqCopy);
            this.splitContainer1.Panel2.Controls.Add(this.pbModeCopy);
            this.splitContainer1.Panel2.Controls.Add(this.pbSubmissionTypeCopy);
            this.splitContainer1.Panel2.Controls.Add(this.pbProcedureTypeCopy);
            this.splitContainer1.Panel2.Controls.Add(this.pbNumberCopy);
            this.splitContainer1.Panel2.Controls.Add(this.pbTrackingNoCopy);
            this.splitContainer1.Panel2.Controls.Add(this.pbINNCopy);
            this.splitContainer1.Panel2.Controls.Add(this.pbIdentifierCopy);
            this.splitContainer1.Panel2.Controls.Add(this.tbIdentifier);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxIS);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxDE2App);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxIE);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxTrackNo);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxHU);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxDE2);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxIT);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxEL);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxDE2);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxLV);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxProcType);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxDE);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxHRApp);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxLI);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxFR);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxHR);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxLT);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxFI);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxHR);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxLU);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxSubmType);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxED);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxMT);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxEU);
            this.splitContainer1.Panel2.Controls.Add(this.labelSequence);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxNL);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxEE);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxMode);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxNO);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxINN);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxDK);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxSubmUnit);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxPL);
            this.splitContainer1.Panel2.Controls.Add(this.label13);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCZ);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxNumber);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxPT);
            this.splitContainer1.Panel2.Controls.Add(this.labelSubmissionUnit);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCY);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxRO);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxSubmDescr);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxBG);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxSK);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxBE);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxSI);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxUK);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxES);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxSE);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxSE);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxES);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxRelSeq);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxUK);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxSI);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxSK);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxRO);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxATApp);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxPT);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxBEApp);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxPL);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxUKApp);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxBGApp);
            this.splitContainer1.Panel2.Controls.Add(this.label19);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxNO);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxSEApp);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCYApp);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxAT);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxNL);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxESApp);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCZApp);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxBE);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxMT);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxSIApp);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxDKApp);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxBG);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxLU);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxSKApp);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxEEApp);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxCY);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxLT);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxROApp);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxEUApp);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxCZ);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxAT);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxPTApp);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxEDApp);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxDK);
            this.splitContainer1.Panel2.Controls.Add(this.label21);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxPLApp);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxFIApp);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxEE);
            this.splitContainer1.Panel2.Controls.Add(this.label22);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxNOApp);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxFRApp);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxED);
            this.splitContainer1.Panel2.Controls.Add(this.label20);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxNLApp);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxDEApp);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxEU);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxLI);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxMTApp);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxELApp);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxFI);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxLV);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxLUApp);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxHUApp);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxFR);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxIT);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxLTApp);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxISApp);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxDE);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxIE);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxLIApp);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxIEApp);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxEL);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxIS);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxLVApp);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxITApp);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxHU);
            this.splitContainer1.Size = new System.Drawing.Size(962, 614);
            this.splitContainer1.SplitterDistance = 181;
            this.splitContainer1.TabIndex = 122;
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCreate,
            this.tsbOpenDossier,
            this.tsbOpenLastDossier,
            this.tsbAdoptInformation,
            this.tsbDeleteEmptyFolder,
            this.tsbCreateXMLFiles,
            this.tsbDiagnostic,
            this.tsbPackDossier,
            this.tsbAssemble,
            this.tsbRefreshFolderView,
            this.tsbCloseDossier,
            this.tsbOptions,
            this.tsbCloseApp,
            this.tsbAbout});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip.Size = new System.Drawing.Size(181, 39);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 122;
            this.toolStrip.Text = "toolStrip";
            // 
            // tsbCreate
            // 
            this.tsbCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCreate.Image = global::eCTD_indexer.Properties.Resources.Actions_folder_new_icon_72x72;
            this.tsbCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCreate.Name = "tsbCreate";
            this.tsbCreate.Size = new System.Drawing.Size(36, 36);
            this.tsbCreate.Text = "Create a new dossier";
            this.tsbCreate.Click += new System.EventHandler(this.tsbCreate_Click);
            // 
            // tsbOpenDossier
            // 
            this.tsbOpenDossier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpenDossier.Image = global::eCTD_indexer.Properties.Resources.Actions_document_open_icon_72x72;
            this.tsbOpenDossier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenDossier.Name = "tsbOpenDossier";
            this.tsbOpenDossier.Size = new System.Drawing.Size(36, 36);
            this.tsbOpenDossier.Text = "Open Dossier";
            this.tsbOpenDossier.Click += new System.EventHandler(this.tsbOpenDossier_Click);
            // 
            // tsbOpenLastDossier
            // 
            this.tsbOpenLastDossier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpenLastDossier.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpenLastDossier.Image")));
            this.tsbOpenLastDossier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenLastDossier.Name = "tsbOpenLastDossier";
            this.tsbOpenLastDossier.Size = new System.Drawing.Size(36, 36);
            this.tsbOpenLastDossier.Text = "Open Last Dossier";
            this.tsbOpenLastDossier.Click += new System.EventHandler(this.tsbOpenLastDossier_Click);
            // 
            // tsbAdoptInformation
            // 
            this.tsbAdoptInformation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdoptInformation.Image = global::eCTD_indexer.Properties.Resources.Actions_go_jump_icon_72x72;
            this.tsbAdoptInformation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdoptInformation.Name = "tsbAdoptInformation";
            this.tsbAdoptInformation.Size = new System.Drawing.Size(36, 36);
            this.tsbAdoptInformation.Text = "Adopt information from previous sequence";
            this.tsbAdoptInformation.Click += new System.EventHandler(this.tsbAdoptInformation_Click);
            // 
            // tsbDeleteEmptyFolder
            // 
            this.tsbDeleteEmptyFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeleteEmptyFolder.Image = global::eCTD_indexer.Properties.Resources.Actions_edit_clear_icon;
            this.tsbDeleteEmptyFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteEmptyFolder.Name = "tsbDeleteEmptyFolder";
            this.tsbDeleteEmptyFolder.Size = new System.Drawing.Size(36, 36);
            this.tsbDeleteEmptyFolder.Text = "Delete all empty directories";
            this.tsbDeleteEmptyFolder.Click += new System.EventHandler(this.tsbDeleteEmptyFolder_Click);
            // 
            // tsbCreateXMLFiles
            // 
            this.tsbCreateXMLFiles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCreateXMLFiles.Image = global::eCTD_indexer.Properties.Resources.Actions_system_run_icon_72x72;
            this.tsbCreateXMLFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCreateXMLFiles.Name = "tsbCreateXMLFiles";
            this.tsbCreateXMLFiles.Size = new System.Drawing.Size(36, 36);
            this.tsbCreateXMLFiles.Text = "Create XML files";
            this.tsbCreateXMLFiles.Click += new System.EventHandler(this.tsbCreateXMLFiles_Click);
            // 
            // tsbDiagnostic
            // 
            this.tsbDiagnostic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDiagnostic.Image = global::eCTD_indexer.Properties.Resources.Apps_system_diagnosis_icon;
            this.tsbDiagnostic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDiagnostic.Name = "tsbDiagnostic";
            this.tsbDiagnostic.Size = new System.Drawing.Size(36, 36);
            this.tsbDiagnostic.Text = "Dossier Diagnostic";
            this.tsbDiagnostic.Click += new System.EventHandler(this.tsbDiagnostic_Click);
            // 
            // tsbPackDossier
            // 
            this.tsbPackDossier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPackDossier.Image = global::eCTD_indexer.Properties.Resources.Apps_utilities_file_archiver_icon;
            this.tsbPackDossier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPackDossier.Name = "tsbPackDossier";
            this.tsbPackDossier.Size = new System.Drawing.Size(36, 36);
            this.tsbPackDossier.Text = "Zip dossier";
            this.tsbPackDossier.Click += new System.EventHandler(this.tsbPackDossier_Click);
            // 
            // tsbAssemble
            // 
            this.tsbAssemble.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAssemble.Image = global::eCTD_indexer.Properties.Resources.Actions_view_assemble_icon_72x72;
            this.tsbAssemble.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAssemble.Name = "tsbAssemble";
            this.tsbAssemble.Size = new System.Drawing.Size(36, 36);
            this.tsbAssemble.Text = "Assemble and consolidate dossier sequences";
            this.tsbAssemble.Click += new System.EventHandler(this.tsbAssemble_Click);
            // 
            // tsbRefreshFolderView
            // 
            this.tsbRefreshFolderView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefreshFolderView.Image = global::eCTD_indexer.Properties.Resources.Actions_view_refresh_icon_72x72;
            this.tsbRefreshFolderView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefreshFolderView.Name = "tsbRefreshFolderView";
            this.tsbRefreshFolderView.Size = new System.Drawing.Size(36, 36);
            this.tsbRefreshFolderView.Text = "Refresh Folder View";
            this.tsbRefreshFolderView.Click += new System.EventHandler(this.tsbRefreshFolderView_Click);
            // 
            // tsbCloseDossier
            // 
            this.tsbCloseDossier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCloseDossier.Image = global::eCTD_indexer.Properties.Resources.Actions_project_development_close_icon_72x72;
            this.tsbCloseDossier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCloseDossier.Name = "tsbCloseDossier";
            this.tsbCloseDossier.Size = new System.Drawing.Size(36, 36);
            this.tsbCloseDossier.Text = "Close the dossier";
            this.tsbCloseDossier.Click += new System.EventHandler(this.tsbCloseDossier_Click);
            // 
            // tsbOptions
            // 
            this.tsbOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOptions.Image = global::eCTD_indexer.Properties.Resources.Categories_applications_development_icon_72x72;
            this.tsbOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOptions.Name = "tsbOptions";
            this.tsbOptions.Size = new System.Drawing.Size(36, 36);
            this.tsbOptions.Text = "Application Options";
            this.tsbOptions.Click += new System.EventHandler(this.tsbOptions_Click);
            // 
            // tsbCloseApp
            // 
            this.tsbCloseApp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCloseApp.Image = global::eCTD_indexer.Properties.Resources.Actions_system_shutdown_icon_72x72;
            this.tsbCloseApp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCloseApp.Name = "tsbCloseApp";
            this.tsbCloseApp.Size = new System.Drawing.Size(36, 36);
            this.tsbCloseApp.Text = "Close the eCTD indexer";
            this.tsbCloseApp.Click += new System.EventHandler(this.tsbCloseApp_Click);
            // 
            // tsbAbout
            // 
            this.tsbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAbout.Image = global::eCTD_indexer.Properties.Resources.Actions_help_about_icon_72x72;
            this.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAbout.Name = "tsbAbout";
            this.tsbAbout.Size = new System.Drawing.Size(36, 36);
            this.tsbAbout.Text = "About eCTD indexer";
            this.tsbAbout.Click += new System.EventHandler(this.tsbAbout_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.checkToolStripMenuItem,
            this.createToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(181, 24);
            this.menuStrip1.TabIndex = 124;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDossierToolStripMenuItem,
            this.openDossierToolStripMenuItem,
            this.openLastDossierToolStripMenuItem,
            this.tsbiCloseDossier,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newDossierToolStripMenuItem
            // 
            this.newDossierToolStripMenuItem.Name = "newDossierToolStripMenuItem";
            this.newDossierToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.newDossierToolStripMenuItem.Text = "New Dossier";
            this.newDossierToolStripMenuItem.Click += new System.EventHandler(this.newDossierToolStripMenuItem_Click);
            // 
            // openDossierToolStripMenuItem
            // 
            this.openDossierToolStripMenuItem.Name = "openDossierToolStripMenuItem";
            this.openDossierToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.openDossierToolStripMenuItem.Text = "Open Dossier";
            this.openDossierToolStripMenuItem.Click += new System.EventHandler(this.openDossierToolStripMenuItem_Click);
            // 
            // openLastDossierToolStripMenuItem
            // 
            this.openLastDossierToolStripMenuItem.Name = "openLastDossierToolStripMenuItem";
            this.openLastDossierToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.openLastDossierToolStripMenuItem.Text = "Open Last Dossier";
            this.openLastDossierToolStripMenuItem.Click += new System.EventHandler(this.openLastDossierToolStripMenuItem_Click);
            // 
            // tsbiCloseDossier
            // 
            this.tsbiCloseDossier.Name = "tsbiCloseDossier";
            this.tsbiCloseDossier.Size = new System.Drawing.Size(168, 22);
            this.tsbiCloseDossier.Text = "Close Dossier";
            this.tsbiCloseDossier.Click += new System.EventHandler(this.tsbiCloseDossier_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.closeToolStripMenuItem.Text = "Close Application";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.tsbideleteAllEmptyDirectoriesToolStripMenuItem,
            this.toolStripSeparator2,
            this.tsmiProperties});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // tsbideleteAllEmptyDirectoriesToolStripMenuItem
            // 
            this.tsbideleteAllEmptyDirectoriesToolStripMenuItem.Name = "tsbideleteAllEmptyDirectoriesToolStripMenuItem";
            this.tsbideleteAllEmptyDirectoriesToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.tsbideleteAllEmptyDirectoriesToolStripMenuItem.Text = "Delete all empty directories";
            this.tsbideleteAllEmptyDirectoriesToolStripMenuItem.Click += new System.EventHandler(this.tsbideleteAllEmptyDirectoriesToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(214, 6);
            // 
            // tsmiProperties
            // 
            this.tsmiProperties.Name = "tsmiProperties";
            this.tsmiProperties.Size = new System.Drawing.Size(217, 22);
            this.tsmiProperties.Text = "Properties";
            this.tsmiProperties.Click += new System.EventHandler(this.tsmiProperties_Click);
            // 
            // checkToolStripMenuItem
            // 
            this.checkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.completeValidationToolStripMenuItem,
            this.toolStripSeparator1,
            this.fileNamesToolStripMenuItem});
            this.checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            this.checkToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.checkToolStripMenuItem.Text = "Check";
            // 
            // completeValidationToolStripMenuItem
            // 
            this.completeValidationToolStripMenuItem.Name = "completeValidationToolStripMenuItem";
            this.completeValidationToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.completeValidationToolStripMenuItem.Text = "Complete Validation";
            this.completeValidationToolStripMenuItem.Click += new System.EventHandler(this.completeValidationToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // fileNamesToolStripMenuItem
            // 
            this.fileNamesToolStripMenuItem.Name = "fileNamesToolStripMenuItem";
            this.fileNamesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.fileNamesToolStripMenuItem.Text = "File names";
            this.fileNamesToolStripMenuItem.Click += new System.EventHandler(this.fileNamesToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createXMLFilesToolStripMenuItem,
            this.zipDossierToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(53, 22);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // createXMLFilesToolStripMenuItem
            // 
            this.createXMLFilesToolStripMenuItem.Name = "createXMLFilesToolStripMenuItem";
            this.createXMLFilesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.createXMLFilesToolStripMenuItem.Text = "Create XML files";
            this.createXMLFilesToolStripMenuItem.Click += new System.EventHandler(this.createXMLFilesToolStripMenuItem_Click);
            // 
            // zipDossierToolStripMenuItem
            // 
            this.zipDossierToolStripMenuItem.Name = "zipDossierToolStripMenuItem";
            this.zipDossierToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.zipDossierToolStripMenuItem.Text = "Zip dossier";
            this.zipDossierToolStripMenuItem.Click += new System.EventHandler(this.zipDossierToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pbSubmissionUnitCopy
            // 
            this.pbSubmissionUnitCopy.Image = global::eCTD_indexer.Properties.Resources.Actions_edit_copy_icon;
            this.pbSubmissionUnitCopy.Location = new System.Drawing.Point(674, 148);
            this.pbSubmissionUnitCopy.Name = "pbSubmissionUnitCopy";
            this.pbSubmissionUnitCopy.Size = new System.Drawing.Size(36, 21);
            this.pbSubmissionUnitCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSubmissionUnitCopy.TabIndex = 132;
            this.pbSubmissionUnitCopy.TabStop = false;
            this.pbSubmissionUnitCopy.Click += new System.EventHandler(this.pbSubmissionUnitCopy_Click);
            // 
            // pbSubDescCopy
            // 
            this.pbSubDescCopy.Image = global::eCTD_indexer.Properties.Resources.Actions_edit_copy_icon;
            this.pbSubDescCopy.Location = new System.Drawing.Point(674, 121);
            this.pbSubDescCopy.Name = "pbSubDescCopy";
            this.pbSubDescCopy.Size = new System.Drawing.Size(36, 21);
            this.pbSubDescCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSubDescCopy.TabIndex = 131;
            this.pbSubDescCopy.TabStop = false;
            this.pbSubDescCopy.Click += new System.EventHandler(this.pbSubDescCopy_Click);
            // 
            // pbRelSeqCopy
            // 
            this.pbRelSeqCopy.Image = global::eCTD_indexer.Properties.Resources.Actions_edit_copy_icon;
            this.pbRelSeqCopy.Location = new System.Drawing.Point(674, 95);
            this.pbRelSeqCopy.Name = "pbRelSeqCopy";
            this.pbRelSeqCopy.Size = new System.Drawing.Size(36, 21);
            this.pbRelSeqCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRelSeqCopy.TabIndex = 130;
            this.pbRelSeqCopy.TabStop = false;
            this.pbRelSeqCopy.Click += new System.EventHandler(this.pbRelSeqCopy_Click);
            // 
            // pbModeCopy
            // 
            this.pbModeCopy.Image = global::eCTD_indexer.Properties.Resources.Actions_edit_copy_icon;
            this.pbModeCopy.Location = new System.Drawing.Point(325, 121);
            this.pbModeCopy.Name = "pbModeCopy";
            this.pbModeCopy.Size = new System.Drawing.Size(36, 21);
            this.pbModeCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbModeCopy.TabIndex = 129;
            this.pbModeCopy.TabStop = false;
            this.pbModeCopy.Click += new System.EventHandler(this.pbModeCopy_Click);
            // 
            // pbSubmissionTypeCopy
            // 
            this.pbSubmissionTypeCopy.Image = global::eCTD_indexer.Properties.Resources.Actions_edit_copy_icon;
            this.pbSubmissionTypeCopy.Location = new System.Drawing.Point(325, 98);
            this.pbSubmissionTypeCopy.Name = "pbSubmissionTypeCopy";
            this.pbSubmissionTypeCopy.Size = new System.Drawing.Size(36, 21);
            this.pbSubmissionTypeCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSubmissionTypeCopy.TabIndex = 128;
            this.pbSubmissionTypeCopy.TabStop = false;
            this.pbSubmissionTypeCopy.Click += new System.EventHandler(this.pbSubmissionTypeCopy_Click);
            // 
            // pbProcedureTypeCopy
            // 
            this.pbProcedureTypeCopy.Image = global::eCTD_indexer.Properties.Resources.Actions_edit_copy_icon;
            this.pbProcedureTypeCopy.Location = new System.Drawing.Point(325, 71);
            this.pbProcedureTypeCopy.Name = "pbProcedureTypeCopy";
            this.pbProcedureTypeCopy.Size = new System.Drawing.Size(36, 21);
            this.pbProcedureTypeCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProcedureTypeCopy.TabIndex = 127;
            this.pbProcedureTypeCopy.TabStop = false;
            this.pbProcedureTypeCopy.Click += new System.EventHandler(this.pbProcedureTypeCopy_Click);
            // 
            // pbNumberCopy
            // 
            this.pbNumberCopy.Image = global::eCTD_indexer.Properties.Resources.Actions_edit_copy_icon;
            this.pbNumberCopy.Location = new System.Drawing.Point(326, 145);
            this.pbNumberCopy.Name = "pbNumberCopy";
            this.pbNumberCopy.Size = new System.Drawing.Size(36, 21);
            this.pbNumberCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNumberCopy.TabIndex = 126;
            this.pbNumberCopy.TabStop = false;
            this.pbNumberCopy.Click += new System.EventHandler(this.pbNumberCopy_Click);
            // 
            // pbTrackingNoCopy
            // 
            this.pbTrackingNoCopy.Image = global::eCTD_indexer.Properties.Resources.Actions_edit_copy_icon;
            this.pbTrackingNoCopy.Location = new System.Drawing.Point(326, 45);
            this.pbTrackingNoCopy.Name = "pbTrackingNoCopy";
            this.pbTrackingNoCopy.Size = new System.Drawing.Size(36, 21);
            this.pbTrackingNoCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTrackingNoCopy.TabIndex = 125;
            this.pbTrackingNoCopy.TabStop = false;
            this.pbTrackingNoCopy.Click += new System.EventHandler(this.pbTrackingNoCopy_Click);
            // 
            // pbINNCopy
            // 
            this.pbINNCopy.Image = global::eCTD_indexer.Properties.Resources.Actions_edit_copy_icon;
            this.pbINNCopy.Location = new System.Drawing.Point(674, 44);
            this.pbINNCopy.Name = "pbINNCopy";
            this.pbINNCopy.Size = new System.Drawing.Size(36, 21);
            this.pbINNCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbINNCopy.TabIndex = 124;
            this.pbINNCopy.TabStop = false;
            this.pbINNCopy.Click += new System.EventHandler(this.pbINNCopy_Click);
            // 
            // pbIdentifierCopy
            // 
            this.pbIdentifierCopy.Image = global::eCTD_indexer.Properties.Resources.Actions_edit_copy_icon;
            this.pbIdentifierCopy.Location = new System.Drawing.Point(674, 69);
            this.pbIdentifierCopy.Name = "pbIdentifierCopy";
            this.pbIdentifierCopy.Size = new System.Drawing.Size(36, 21);
            this.pbIdentifierCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIdentifierCopy.TabIndex = 123;
            this.pbIdentifierCopy.TabStop = false;
            this.pbIdentifierCopy.Click += new System.EventHandler(this.pbIdentifierCopy_Click);
            // 
            // tbIdentifier
            // 
            this.tbIdentifier.Location = new System.Drawing.Point(457, 69);
            this.tbIdentifier.Name = "tbIdentifier";
            this.tbIdentifier.Size = new System.Drawing.Size(213, 20);
            this.tbIdentifier.TabIndex = 122;
            this.tbIdentifier.Enter += new System.EventHandler(this.tbIdentifier_Enter);
            this.tbIdentifier.Leave += new System.EventHandler(this.tbIdentifier_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tracking no";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 117;
            this.label8.Text = "Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "EU envelope information";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 115;
            this.label10.Text = "Mode";
            // 
            // textBoxIS
            // 
            this.textBoxIS.Enabled = false;
            this.textBoxIS.Location = new System.Drawing.Point(116, 565);
            this.textBoxIS.Name = "textBoxIS";
            this.textBoxIS.Size = new System.Drawing.Size(100, 20);
            this.textBoxIS.TabIndex = 58;
            this.textBoxIS.Tag = "IS";
            // 
            // textBoxDE2App
            // 
            this.textBoxDE2App.Enabled = false;
            this.textBoxDE2App.Location = new System.Drawing.Point(221, 332);
            this.textBoxDE2App.Name = "textBoxDE2App";
            this.textBoxDE2App.Size = new System.Drawing.Size(100, 20);
            this.textBoxDE2App.TabIndex = 29;
            this.textBoxDE2App.Tag = "DE2";
            // 
            // textBoxIE
            // 
            this.textBoxIE.Enabled = false;
            this.textBoxIE.Location = new System.Drawing.Point(116, 542);
            this.textBoxIE.Name = "textBoxIE";
            this.textBoxIE.Size = new System.Drawing.Size(100, 20);
            this.textBoxIE.TabIndex = 55;
            this.textBoxIE.Tag = "IE";
            // 
            // textBoxTrackNo
            // 
            this.textBoxTrackNo.AcceptsReturn = true;
            this.textBoxTrackNo.Location = new System.Drawing.Point(108, 45);
            this.textBoxTrackNo.Name = "textBoxTrackNo";
            this.textBoxTrackNo.Size = new System.Drawing.Size(212, 20);
            this.textBoxTrackNo.TabIndex = 0;
            // 
            // textBoxHU
            // 
            this.textBoxHU.Enabled = false;
            this.textBoxHU.Location = new System.Drawing.Point(116, 519);
            this.textBoxHU.Name = "textBoxHU";
            this.textBoxHU.Size = new System.Drawing.Size(100, 20);
            this.textBoxHU.TabIndex = 52;
            this.textBoxHU.Tag = "HU";
            // 
            // textBoxDE2
            // 
            this.textBoxDE2.Enabled = false;
            this.textBoxDE2.Location = new System.Drawing.Point(115, 332);
            this.textBoxDE2.Name = "textBoxDE2";
            this.textBoxDE2.Size = new System.Drawing.Size(100, 20);
            this.textBoxDE2.TabIndex = 28;
            this.textBoxDE2.Tag = "DE2";
            // 
            // textBoxIT
            // 
            this.textBoxIT.Enabled = false;
            this.textBoxIT.Location = new System.Drawing.Point(464, 194);
            this.textBoxIT.Name = "textBoxIT";
            this.textBoxIT.Size = new System.Drawing.Size(100, 20);
            this.textBoxIT.TabIndex = 61;
            this.textBoxIT.Tag = "IT";
            // 
            // textBoxEL
            // 
            this.textBoxEL.Enabled = false;
            this.textBoxEL.Location = new System.Drawing.Point(115, 404);
            this.textBoxEL.Name = "textBoxEL";
            this.textBoxEL.Size = new System.Drawing.Size(100, 20);
            this.textBoxEL.TabIndex = 37;
            this.textBoxEL.Tag = "EL";
            // 
            // checkBoxDE2
            // 
            this.checkBoxDE2.AutoSize = true;
            this.checkBoxDE2.Location = new System.Drawing.Point(19, 332);
            this.checkBoxDE2.Name = "checkBoxDE2";
            this.checkBoxDE2.Size = new System.Drawing.Size(61, 17);
            this.checkBoxDE2.TabIndex = 27;
            this.checkBoxDE2.Tag = "DE2";
            this.checkBoxDE2.Text = "DE-PEI";
            this.checkBoxDE2.UseVisualStyleBackColor = true;
            this.checkBoxDE2.CheckedChanged += new System.EventHandler(this.checkBoxDE2_CheckedChanged);
            // 
            // textBoxLV
            // 
            this.textBoxLV.Enabled = false;
            this.textBoxLV.Location = new System.Drawing.Point(464, 286);
            this.textBoxLV.Name = "textBoxLV";
            this.textBoxLV.Size = new System.Drawing.Size(100, 20);
            this.textBoxLV.TabIndex = 73;
            this.textBoxLV.Tag = "LV";
            // 
            // comboBoxProcType
            // 
            this.comboBoxProcType.FormattingEnabled = true;
            this.comboBoxProcType.Items.AddRange(new object[] {
            "centralised",
            "national",
            "mutual-recognition",
            "decentralised"});
            this.comboBoxProcType.Location = new System.Drawing.Point(108, 68);
            this.comboBoxProcType.Name = "comboBoxProcType";
            this.comboBoxProcType.Size = new System.Drawing.Size(212, 21);
            this.comboBoxProcType.TabIndex = 1;
            // 
            // textBoxDE
            // 
            this.textBoxDE.Enabled = false;
            this.textBoxDE.Location = new System.Drawing.Point(115, 309);
            this.textBoxDE.Name = "textBoxDE";
            this.textBoxDE.Size = new System.Drawing.Size(100, 20);
            this.textBoxDE.TabIndex = 25;
            this.textBoxDE.Tag = "DE";
            // 
            // textBoxHRApp
            // 
            this.textBoxHRApp.Enabled = false;
            this.textBoxHRApp.Location = new System.Drawing.Point(221, 496);
            this.textBoxHRApp.Name = "textBoxHRApp";
            this.textBoxHRApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxHRApp.TabIndex = 50;
            this.textBoxHRApp.Tag = "HR";
            // 
            // textBoxLI
            // 
            this.textBoxLI.Enabled = false;
            this.textBoxLI.Location = new System.Drawing.Point(464, 217);
            this.textBoxLI.Name = "textBoxLI";
            this.textBoxLI.Size = new System.Drawing.Size(100, 20);
            this.textBoxLI.TabIndex = 64;
            this.textBoxLI.Tag = "LI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Procedure type";
            // 
            // textBoxFR
            // 
            this.textBoxFR.Enabled = false;
            this.textBoxFR.Location = new System.Drawing.Point(115, 473);
            this.textBoxFR.Name = "textBoxFR";
            this.textBoxFR.Size = new System.Drawing.Size(100, 20);
            this.textBoxFR.TabIndex = 46;
            this.textBoxFR.Tag = "FR";
            // 
            // textBoxHR
            // 
            this.textBoxHR.Enabled = false;
            this.textBoxHR.Location = new System.Drawing.Point(115, 496);
            this.textBoxHR.Name = "textBoxHR";
            this.textBoxHR.Size = new System.Drawing.Size(100, 20);
            this.textBoxHR.TabIndex = 49;
            this.textBoxHR.Tag = "HR";
            // 
            // textBoxLT
            // 
            this.textBoxLT.Enabled = false;
            this.textBoxLT.Location = new System.Drawing.Point(464, 240);
            this.textBoxLT.Name = "textBoxLT";
            this.textBoxLT.Size = new System.Drawing.Size(100, 20);
            this.textBoxLT.TabIndex = 67;
            this.textBoxLT.Tag = "LT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Submission type";
            // 
            // textBoxFI
            // 
            this.textBoxFI.Enabled = false;
            this.textBoxFI.Location = new System.Drawing.Point(115, 450);
            this.textBoxFI.Name = "textBoxFI";
            this.textBoxFI.Size = new System.Drawing.Size(100, 20);
            this.textBoxFI.TabIndex = 43;
            this.textBoxFI.Tag = "FI";
            // 
            // checkBoxHR
            // 
            this.checkBoxHR.AutoSize = true;
            this.checkBoxHR.Location = new System.Drawing.Point(19, 496);
            this.checkBoxHR.Name = "checkBoxHR";
            this.checkBoxHR.Size = new System.Drawing.Size(90, 17);
            this.checkBoxHR.TabIndex = 48;
            this.checkBoxHR.Tag = "HR";
            this.checkBoxHR.Text = "HR-HALMED";
            this.checkBoxHR.UseVisualStyleBackColor = true;
            this.checkBoxHR.CheckedChanged += new System.EventHandler(this.checkBoxHR_CheckedChanged);
            // 
            // textBoxLU
            // 
            this.textBoxLU.Enabled = false;
            this.textBoxLU.Location = new System.Drawing.Point(464, 263);
            this.textBoxLU.Name = "textBoxLU";
            this.textBoxLU.Size = new System.Drawing.Size(100, 20);
            this.textBoxLU.TabIndex = 70;
            this.textBoxLU.Tag = "LU";
            // 
            // comboBoxSubmType
            // 
            this.comboBoxSubmType.FormattingEnabled = true;
            this.comboBoxSubmType.Items.AddRange(new object[] {
            "maa",
            "var-type1a",
            "var-type1ain",
            "var-type1b",
            "var-type2",
            "var-nat",
            "extension",
            "rup",
            "psur",
            "psusa",
            "rmp",
            "renewal",
            "pam-sob",
            "pam-anx",
            "pam-mea",
            "pam-leg",
            "pam-sda",
            "pam-capa",
            "pam-p45",
            "pam-p46",
            "pam-paes",
            "pam-rec",
            "pass107n",
            "pass107q",
            "asmf",
            "pmf",
            "referral-20",
            "referral-294",
            "referral-29p",
            "referral-30",
            "referral-31",
            "referral-35",
            "referral-5-3",
            "referral-107i",
            "referral-16c1c",
            "referral-16c4",
            "annual-reassessment",
            "usr",
            "clin-data-pub-rp",
            "clin-data-pub-fv",
            "paed-7-8-30",
            "paed-29",
            "paed-45",
            "paed-46",
            "article-58",
            "notification-61-3",
            "transfer-ma",
            "lifting-suspension",
            "withdrawal",
            "cep",
            "none"});
            this.comboBoxSubmType.Location = new System.Drawing.Point(108, 94);
            this.comboBoxSubmType.Name = "comboBoxSubmType";
            this.comboBoxSubmType.Size = new System.Drawing.Size(212, 21);
            this.comboBoxSubmType.TabIndex = 2;
            this.comboBoxSubmType.Tag = "7";
            this.comboBoxSubmType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubmType_SelectedIndexChanged);
            // 
            // textBoxED
            // 
            this.textBoxED.Enabled = false;
            this.textBoxED.Location = new System.Drawing.Point(464, 539);
            this.textBoxED.Name = "textBoxED";
            this.textBoxED.Size = new System.Drawing.Size(100, 20);
            this.textBoxED.TabIndex = 106;
            this.textBoxED.Tag = "EDQM";
            // 
            // textBoxMT
            // 
            this.textBoxMT.Enabled = false;
            this.textBoxMT.Location = new System.Drawing.Point(464, 309);
            this.textBoxMT.Name = "textBoxMT";
            this.textBoxMT.Size = new System.Drawing.Size(100, 20);
            this.textBoxMT.TabIndex = 76;
            this.textBoxMT.Tag = "MT";
            // 
            // textBoxEU
            // 
            this.textBoxEU.Enabled = false;
            this.textBoxEU.Location = new System.Drawing.Point(464, 562);
            this.textBoxEU.Name = "textBoxEU";
            this.textBoxEU.Size = new System.Drawing.Size(100, 20);
            this.textBoxEU.TabIndex = 106;
            this.textBoxEU.Tag = "EMA";
            // 
            // labelSequence
            // 
            this.labelSequence.AutoSize = true;
            this.labelSequence.Location = new System.Drawing.Point(367, 71);
            this.labelSequence.Name = "labelSequence";
            this.labelSequence.Size = new System.Drawing.Size(47, 13);
            this.labelSequence.TabIndex = 120;
            this.labelSequence.Text = "Identifier";
            // 
            // textBoxNL
            // 
            this.textBoxNL.Enabled = false;
            this.textBoxNL.Location = new System.Drawing.Point(464, 332);
            this.textBoxNL.Name = "textBoxNL";
            this.textBoxNL.Size = new System.Drawing.Size(100, 20);
            this.textBoxNL.TabIndex = 79;
            this.textBoxNL.Tag = "NL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(367, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "INN";
            // 
            // textBoxEE
            // 
            this.textBoxEE.Enabled = false;
            this.textBoxEE.Location = new System.Drawing.Point(115, 381);
            this.textBoxEE.Name = "textBoxEE";
            this.textBoxEE.Size = new System.Drawing.Size(100, 20);
            this.textBoxEE.TabIndex = 34;
            this.textBoxEE.Tag = "EE";
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.Enabled = false;
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "single",
            "grouping",
            "worksharing "});
            this.comboBoxMode.Location = new System.Drawing.Point(108, 119);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(212, 21);
            this.comboBoxMode.TabIndex = 3;
            // 
            // textBoxNO
            // 
            this.textBoxNO.Enabled = false;
            this.textBoxNO.Location = new System.Drawing.Point(464, 355);
            this.textBoxNO.Name = "textBoxNO";
            this.textBoxNO.Size = new System.Drawing.Size(100, 20);
            this.textBoxNO.TabIndex = 82;
            this.textBoxNO.Tag = "NO";
            // 
            // textBoxINN
            // 
            this.textBoxINN.Location = new System.Drawing.Point(457, 45);
            this.textBoxINN.Name = "textBoxINN";
            this.textBoxINN.Size = new System.Drawing.Size(213, 20);
            this.textBoxINN.TabIndex = 5;
            // 
            // textBoxDK
            // 
            this.textBoxDK.Enabled = false;
            this.textBoxDK.Location = new System.Drawing.Point(115, 358);
            this.textBoxDK.Name = "textBoxDK";
            this.textBoxDK.Size = new System.Drawing.Size(100, 20);
            this.textBoxDK.TabIndex = 31;
            this.textBoxDK.Tag = "DK";
            // 
            // comboBoxSubmUnit
            // 
            this.comboBoxSubmUnit.FormattingEnabled = true;
            this.comboBoxSubmUnit.Items.AddRange(new object[] {
            "initial",
            "validation-response",
            "response",
            "additional-info",
            "closing",
            "consolidating",
            "corrigendum",
            "reformat"});
            this.comboBoxSubmUnit.Location = new System.Drawing.Point(457, 146);
            this.comboBoxSubmUnit.Name = "comboBoxSubmUnit";
            this.comboBoxSubmUnit.Size = new System.Drawing.Size(212, 21);
            this.comboBoxSubmUnit.TabIndex = 105;
            // 
            // textBoxPL
            // 
            this.textBoxPL.Enabled = false;
            this.textBoxPL.Location = new System.Drawing.Point(464, 378);
            this.textBoxPL.Name = "textBoxPL";
            this.textBoxPL.Size = new System.Drawing.Size(100, 20);
            this.textBoxPL.TabIndex = 85;
            this.textBoxPL.Tag = "PL";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(367, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Subm. descr.";
            // 
            // textBoxCZ
            // 
            this.textBoxCZ.Enabled = false;
            this.textBoxCZ.Location = new System.Drawing.Point(115, 286);
            this.textBoxCZ.Name = "textBoxCZ";
            this.textBoxCZ.Size = new System.Drawing.Size(100, 20);
            this.textBoxCZ.TabIndex = 22;
            this.textBoxCZ.Tag = "CZ";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Enabled = false;
            this.textBoxNumber.Location = new System.Drawing.Point(108, 142);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(212, 20);
            this.textBoxNumber.TabIndex = 4;
            // 
            // textBoxPT
            // 
            this.textBoxPT.Enabled = false;
            this.textBoxPT.Location = new System.Drawing.Point(464, 401);
            this.textBoxPT.Name = "textBoxPT";
            this.textBoxPT.Size = new System.Drawing.Size(100, 20);
            this.textBoxPT.TabIndex = 88;
            this.textBoxPT.Tag = "PT";
            // 
            // labelSubmissionUnit
            // 
            this.labelSubmissionUnit.AutoSize = true;
            this.labelSubmissionUnit.Location = new System.Drawing.Point(367, 149);
            this.labelSubmissionUnit.Name = "labelSubmissionUnit";
            this.labelSubmissionUnit.Size = new System.Drawing.Size(80, 13);
            this.labelSubmissionUnit.TabIndex = 87;
            this.labelSubmissionUnit.Text = "Submission unit";
            // 
            // textBoxCY
            // 
            this.textBoxCY.Enabled = false;
            this.textBoxCY.Location = new System.Drawing.Point(115, 263);
            this.textBoxCY.Name = "textBoxCY";
            this.textBoxCY.Size = new System.Drawing.Size(100, 20);
            this.textBoxCY.TabIndex = 19;
            this.textBoxCY.Tag = "CY";
            // 
            // textBoxRO
            // 
            this.textBoxRO.Enabled = false;
            this.textBoxRO.Location = new System.Drawing.Point(464, 424);
            this.textBoxRO.Name = "textBoxRO";
            this.textBoxRO.Size = new System.Drawing.Size(100, 20);
            this.textBoxRO.TabIndex = 91;
            this.textBoxRO.Tag = "RO";
            // 
            // textBoxSubmDescr
            // 
            this.textBoxSubmDescr.Location = new System.Drawing.Point(457, 120);
            this.textBoxSubmDescr.Name = "textBoxSubmDescr";
            this.textBoxSubmDescr.Size = new System.Drawing.Size(213, 20);
            this.textBoxSubmDescr.TabIndex = 7;
            // 
            // textBoxBG
            // 
            this.textBoxBG.Enabled = false;
            this.textBoxBG.Location = new System.Drawing.Point(115, 240);
            this.textBoxBG.Name = "textBoxBG";
            this.textBoxBG.Size = new System.Drawing.Size(100, 20);
            this.textBoxBG.TabIndex = 16;
            this.textBoxBG.Tag = "BG";
            // 
            // textBoxSK
            // 
            this.textBoxSK.Enabled = false;
            this.textBoxSK.Location = new System.Drawing.Point(464, 493);
            this.textBoxSK.Name = "textBoxSK";
            this.textBoxSK.Size = new System.Drawing.Size(100, 20);
            this.textBoxSK.TabIndex = 100;
            this.textBoxSK.Tag = "SK";
            // 
            // textBoxBE
            // 
            this.textBoxBE.Enabled = false;
            this.textBoxBE.Location = new System.Drawing.Point(115, 217);
            this.textBoxBE.Name = "textBoxBE";
            this.textBoxBE.Size = new System.Drawing.Size(100, 20);
            this.textBoxBE.TabIndex = 13;
            this.textBoxBE.Tag = "BE";
            // 
            // textBoxSI
            // 
            this.textBoxSI.Enabled = false;
            this.textBoxSI.Location = new System.Drawing.Point(464, 470);
            this.textBoxSI.Name = "textBoxSI";
            this.textBoxSI.Size = new System.Drawing.Size(100, 20);
            this.textBoxSI.TabIndex = 97;
            this.textBoxSI.Tag = "SI";
            // 
            // checkBoxUK
            // 
            this.checkBoxUK.AutoSize = true;
            this.checkBoxUK.Location = new System.Drawing.Point(370, 516);
            this.checkBoxUK.Name = "checkBoxUK";
            this.checkBoxUK.Size = new System.Drawing.Size(76, 17);
            this.checkBoxUK.TabIndex = 102;
            this.checkBoxUK.Tag = "UK";
            this.checkBoxUK.Text = "UK-MHRA";
            this.checkBoxUK.UseVisualStyleBackColor = true;
            this.checkBoxUK.CheckedChanged += new System.EventHandler(this.checkBoxUK_CheckedChanged);
            // 
            // textBoxES
            // 
            this.textBoxES.Enabled = false;
            this.textBoxES.Location = new System.Drawing.Point(115, 427);
            this.textBoxES.Name = "textBoxES";
            this.textBoxES.Size = new System.Drawing.Size(100, 20);
            this.textBoxES.TabIndex = 40;
            this.textBoxES.Tag = "ES";
            // 
            // checkBoxSE
            // 
            this.checkBoxSE.AutoSize = true;
            this.checkBoxSE.Location = new System.Drawing.Point(370, 447);
            this.checkBoxSE.Name = "checkBoxSE";
            this.checkBoxSE.Size = new System.Drawing.Size(66, 17);
            this.checkBoxSE.TabIndex = 93;
            this.checkBoxSE.Tag = "SE";
            this.checkBoxSE.Text = "SE-MPA";
            this.checkBoxSE.UseVisualStyleBackColor = true;
            this.checkBoxSE.CheckedChanged += new System.EventHandler(this.checkBoxSE_CheckedChanged);
            // 
            // textBoxSE
            // 
            this.textBoxSE.Enabled = false;
            this.textBoxSE.Location = new System.Drawing.Point(464, 447);
            this.textBoxSE.Name = "textBoxSE";
            this.textBoxSE.Size = new System.Drawing.Size(100, 20);
            this.textBoxSE.TabIndex = 94;
            this.textBoxSE.Tag = "SE";
            // 
            // checkBoxES
            // 
            this.checkBoxES.AutoSize = true;
            this.checkBoxES.Location = new System.Drawing.Point(19, 427);
            this.checkBoxES.Name = "checkBoxES";
            this.checkBoxES.Size = new System.Drawing.Size(80, 17);
            this.checkBoxES.TabIndex = 39;
            this.checkBoxES.Tag = "ES";
            this.checkBoxES.Text = "ES-AEMPS";
            this.checkBoxES.UseVisualStyleBackColor = true;
            this.checkBoxES.CheckedChanged += new System.EventHandler(this.checkBoxES_CheckedChanged);
            // 
            // textBoxRelSeq
            // 
            this.textBoxRelSeq.Location = new System.Drawing.Point(457, 94);
            this.textBoxRelSeq.Name = "textBoxRelSeq";
            this.textBoxRelSeq.Size = new System.Drawing.Size(213, 20);
            this.textBoxRelSeq.TabIndex = 6;
            // 
            // textBoxUK
            // 
            this.textBoxUK.Enabled = false;
            this.textBoxUK.Location = new System.Drawing.Point(464, 516);
            this.textBoxUK.Name = "textBoxUK";
            this.textBoxUK.Size = new System.Drawing.Size(100, 20);
            this.textBoxUK.TabIndex = 103;
            this.textBoxUK.Tag = "UK";
            // 
            // checkBoxSI
            // 
            this.checkBoxSI.AutoSize = true;
            this.checkBoxSI.Location = new System.Drawing.Point(370, 470);
            this.checkBoxSI.Name = "checkBoxSI";
            this.checkBoxSI.Size = new System.Drawing.Size(74, 17);
            this.checkBoxSI.TabIndex = 96;
            this.checkBoxSI.Tag = "SI";
            this.checkBoxSI.Text = "SI-JAZMP";
            this.checkBoxSI.UseVisualStyleBackColor = true;
            this.checkBoxSI.CheckedChanged += new System.EventHandler(this.checkBoxSI_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "Rel. Sequence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Applicant";
            // 
            // checkBoxSK
            // 
            this.checkBoxSK.AutoSize = true;
            this.checkBoxSK.Location = new System.Drawing.Point(370, 493);
            this.checkBoxSK.Name = "checkBoxSK";
            this.checkBoxSK.Size = new System.Drawing.Size(68, 17);
            this.checkBoxSK.TabIndex = 99;
            this.checkBoxSK.Tag = "SK";
            this.checkBoxSK.Text = "SK-SIDC";
            this.checkBoxSK.UseVisualStyleBackColor = true;
            this.checkBoxSK.CheckedChanged += new System.EventHandler(this.checkBoxSK_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(567, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "Applicant";
            // 
            // checkBoxRO
            // 
            this.checkBoxRO.AutoSize = true;
            this.checkBoxRO.Location = new System.Drawing.Point(370, 424);
            this.checkBoxRO.Name = "checkBoxRO";
            this.checkBoxRO.Size = new System.Drawing.Size(86, 17);
            this.checkBoxRO.TabIndex = 90;
            this.checkBoxRO.Tag = "RO";
            this.checkBoxRO.Text = "RO-ANMMD";
            this.checkBoxRO.UseVisualStyleBackColor = true;
            this.checkBoxRO.CheckedChanged += new System.EventHandler(this.checkBoxRO_CheckedChanged);
            // 
            // textBoxATApp
            // 
            this.textBoxATApp.Enabled = false;
            this.textBoxATApp.Location = new System.Drawing.Point(221, 194);
            this.textBoxATApp.Name = "textBoxATApp";
            this.textBoxATApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxATApp.TabIndex = 11;
            this.textBoxATApp.Tag = "AT";
            // 
            // checkBoxPT
            // 
            this.checkBoxPT.AutoSize = true;
            this.checkBoxPT.Location = new System.Drawing.Point(370, 401);
            this.checkBoxPT.Name = "checkBoxPT";
            this.checkBoxPT.Size = new System.Drawing.Size(99, 17);
            this.checkBoxPT.TabIndex = 87;
            this.checkBoxPT.Tag = "PT";
            this.checkBoxPT.Text = "PT-INFARMED";
            this.checkBoxPT.UseVisualStyleBackColor = true;
            this.checkBoxPT.CheckedChanged += new System.EventHandler(this.checkBoxPT_CheckedChanged);
            // 
            // textBoxBEApp
            // 
            this.textBoxBEApp.Enabled = false;
            this.textBoxBEApp.Location = new System.Drawing.Point(221, 217);
            this.textBoxBEApp.Name = "textBoxBEApp";
            this.textBoxBEApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxBEApp.TabIndex = 14;
            this.textBoxBEApp.Tag = "BE";
            // 
            // checkBoxPL
            // 
            this.checkBoxPL.AutoSize = true;
            this.checkBoxPL.Location = new System.Drawing.Point(370, 378);
            this.checkBoxPL.Name = "checkBoxPL";
            this.checkBoxPL.Size = new System.Drawing.Size(71, 17);
            this.checkBoxPL.TabIndex = 84;
            this.checkBoxPL.Tag = "PL";
            this.checkBoxPL.Text = "PL-URPL";
            this.checkBoxPL.UseVisualStyleBackColor = true;
            this.checkBoxPL.CheckedChanged += new System.EventHandler(this.checkBoxPL_CheckedChanged);
            // 
            // textBoxUKApp
            // 
            this.textBoxUKApp.Enabled = false;
            this.textBoxUKApp.Location = new System.Drawing.Point(570, 516);
            this.textBoxUKApp.Name = "textBoxUKApp";
            this.textBoxUKApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxUKApp.TabIndex = 104;
            this.textBoxUKApp.Tag = "UK";
            // 
            // textBoxBGApp
            // 
            this.textBoxBGApp.Enabled = false;
            this.textBoxBGApp.Location = new System.Drawing.Point(221, 240);
            this.textBoxBGApp.Name = "textBoxBGApp";
            this.textBoxBGApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxBGApp.TabIndex = 17;
            this.textBoxBGApp.Tag = "BG";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 177);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 13);
            this.label19.TabIndex = 37;
            this.label19.Text = "Country/Agency";
            // 
            // checkBoxNO
            // 
            this.checkBoxNO.AutoSize = true;
            this.checkBoxNO.Location = new System.Drawing.Point(370, 355);
            this.checkBoxNO.Name = "checkBoxNO";
            this.checkBoxNO.Size = new System.Drawing.Size(77, 17);
            this.checkBoxNO.TabIndex = 81;
            this.checkBoxNO.Tag = "NO";
            this.checkBoxNO.Text = "NO-NOMA";
            this.checkBoxNO.UseVisualStyleBackColor = true;
            this.checkBoxNO.CheckedChanged += new System.EventHandler(this.checkBoxNO_CheckedChanged);
            // 
            // textBoxSEApp
            // 
            this.textBoxSEApp.Enabled = false;
            this.textBoxSEApp.Location = new System.Drawing.Point(570, 447);
            this.textBoxSEApp.Name = "textBoxSEApp";
            this.textBoxSEApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxSEApp.TabIndex = 95;
            this.textBoxSEApp.Tag = "SE";
            // 
            // textBoxCYApp
            // 
            this.textBoxCYApp.Enabled = false;
            this.textBoxCYApp.Location = new System.Drawing.Point(221, 263);
            this.textBoxCYApp.Name = "textBoxCYApp";
            this.textBoxCYApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxCYApp.TabIndex = 20;
            this.textBoxCYApp.Tag = "CY";
            // 
            // checkBoxAT
            // 
            this.checkBoxAT.AutoSize = true;
            this.checkBoxAT.Location = new System.Drawing.Point(19, 194);
            this.checkBoxAT.Name = "checkBoxAT";
            this.checkBoxAT.Size = new System.Drawing.Size(72, 17);
            this.checkBoxAT.TabIndex = 9;
            this.checkBoxAT.Tag = "AT";
            this.checkBoxAT.Text = "AT-BASG";
            this.checkBoxAT.UseVisualStyleBackColor = true;
            this.checkBoxAT.CheckedChanged += new System.EventHandler(this.checkBoxAT_CheckedChanged);
            // 
            // checkBoxNL
            // 
            this.checkBoxNL.AutoSize = true;
            this.checkBoxNL.Location = new System.Drawing.Point(370, 332);
            this.checkBoxNL.Name = "checkBoxNL";
            this.checkBoxNL.Size = new System.Drawing.Size(66, 17);
            this.checkBoxNL.TabIndex = 78;
            this.checkBoxNL.Tag = "NL";
            this.checkBoxNL.Text = "NL-MEB";
            this.checkBoxNL.UseVisualStyleBackColor = true;
            this.checkBoxNL.CheckedChanged += new System.EventHandler(this.checkBoxNL_CheckedChanged);
            // 
            // textBoxESApp
            // 
            this.textBoxESApp.Enabled = false;
            this.textBoxESApp.Location = new System.Drawing.Point(221, 427);
            this.textBoxESApp.Name = "textBoxESApp";
            this.textBoxESApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxESApp.TabIndex = 41;
            this.textBoxESApp.Tag = "ES";
            // 
            // textBoxCZApp
            // 
            this.textBoxCZApp.Enabled = false;
            this.textBoxCZApp.Location = new System.Drawing.Point(221, 286);
            this.textBoxCZApp.Name = "textBoxCZApp";
            this.textBoxCZApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxCZApp.TabIndex = 23;
            this.textBoxCZApp.Tag = "CZ";
            // 
            // checkBoxBE
            // 
            this.checkBoxBE.AutoSize = true;
            this.checkBoxBE.Location = new System.Drawing.Point(19, 217);
            this.checkBoxBE.Name = "checkBoxBE";
            this.checkBoxBE.Size = new System.Drawing.Size(80, 17);
            this.checkBoxBE.TabIndex = 12;
            this.checkBoxBE.Tag = "BE";
            this.checkBoxBE.Text = "BE-FAMHP";
            this.checkBoxBE.UseVisualStyleBackColor = true;
            this.checkBoxBE.CheckedChanged += new System.EventHandler(this.checkBoxBE_CheckedChanged);
            // 
            // checkBoxMT
            // 
            this.checkBoxMT.AutoSize = true;
            this.checkBoxMT.Location = new System.Drawing.Point(370, 309);
            this.checkBoxMT.Name = "checkBoxMT";
            this.checkBoxMT.Size = new System.Drawing.Size(99, 17);
            this.checkBoxMT.TabIndex = 75;
            this.checkBoxMT.Tag = "MT";
            this.checkBoxMT.Text = "MT-MEDAUTH";
            this.checkBoxMT.UseVisualStyleBackColor = true;
            this.checkBoxMT.CheckedChanged += new System.EventHandler(this.checkBoxMT_CheckedChanged);
            // 
            // textBoxSIApp
            // 
            this.textBoxSIApp.Enabled = false;
            this.textBoxSIApp.Location = new System.Drawing.Point(570, 470);
            this.textBoxSIApp.Name = "textBoxSIApp";
            this.textBoxSIApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxSIApp.TabIndex = 98;
            this.textBoxSIApp.Tag = "SI";
            // 
            // textBoxDKApp
            // 
            this.textBoxDKApp.Enabled = false;
            this.textBoxDKApp.Location = new System.Drawing.Point(221, 358);
            this.textBoxDKApp.Name = "textBoxDKApp";
            this.textBoxDKApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxDKApp.TabIndex = 32;
            this.textBoxDKApp.Tag = "DK";
            // 
            // checkBoxBG
            // 
            this.checkBoxBG.AutoSize = true;
            this.checkBoxBG.Location = new System.Drawing.Point(19, 240);
            this.checkBoxBG.Name = "checkBoxBG";
            this.checkBoxBG.Size = new System.Drawing.Size(66, 17);
            this.checkBoxBG.TabIndex = 15;
            this.checkBoxBG.Tag = "BG";
            this.checkBoxBG.Text = "BG-BDA";
            this.checkBoxBG.UseVisualStyleBackColor = true;
            this.checkBoxBG.CheckedChanged += new System.EventHandler(this.checkBoxBG_CheckedChanged);
            // 
            // checkBoxLU
            // 
            this.checkBoxLU.AutoSize = true;
            this.checkBoxLU.Location = new System.Drawing.Point(370, 263);
            this.checkBoxLU.Name = "checkBoxLU";
            this.checkBoxLU.Size = new System.Drawing.Size(92, 17);
            this.checkBoxLU.TabIndex = 69;
            this.checkBoxLU.Tag = "LU";
            this.checkBoxLU.Text = "LU-MINSANT";
            this.checkBoxLU.UseVisualStyleBackColor = true;
            this.checkBoxLU.CheckedChanged += new System.EventHandler(this.checkBoxLU_CheckedChanged);
            // 
            // textBoxSKApp
            // 
            this.textBoxSKApp.Enabled = false;
            this.textBoxSKApp.Location = new System.Drawing.Point(570, 493);
            this.textBoxSKApp.Name = "textBoxSKApp";
            this.textBoxSKApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxSKApp.TabIndex = 101;
            this.textBoxSKApp.Tag = "SK";
            // 
            // textBoxEEApp
            // 
            this.textBoxEEApp.Enabled = false;
            this.textBoxEEApp.Location = new System.Drawing.Point(221, 381);
            this.textBoxEEApp.Name = "textBoxEEApp";
            this.textBoxEEApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxEEApp.TabIndex = 35;
            this.textBoxEEApp.Tag = "EE";
            // 
            // checkBoxCY
            // 
            this.checkBoxCY.AutoSize = true;
            this.checkBoxCY.Location = new System.Drawing.Point(19, 263);
            this.checkBoxCY.Name = "checkBoxCY";
            this.checkBoxCY.Size = new System.Drawing.Size(65, 17);
            this.checkBoxCY.TabIndex = 18;
            this.checkBoxCY.Tag = "CY";
            this.checkBoxCY.Text = "CY-PHS";
            this.checkBoxCY.UseVisualStyleBackColor = true;
            this.checkBoxCY.CheckedChanged += new System.EventHandler(this.checkBoxCY_CheckedChanged);
            // 
            // checkBoxLT
            // 
            this.checkBoxLT.AutoSize = true;
            this.checkBoxLT.Location = new System.Drawing.Point(370, 240);
            this.checkBoxLT.Name = "checkBoxLT";
            this.checkBoxLT.Size = new System.Drawing.Size(72, 17);
            this.checkBoxLT.TabIndex = 66;
            this.checkBoxLT.Tag = "LT";
            this.checkBoxLT.Text = "LT-SMCA";
            this.checkBoxLT.UseVisualStyleBackColor = true;
            this.checkBoxLT.CheckedChanged += new System.EventHandler(this.checkBoxLT_CheckedChanged);
            // 
            // textBoxROApp
            // 
            this.textBoxROApp.Enabled = false;
            this.textBoxROApp.Location = new System.Drawing.Point(570, 424);
            this.textBoxROApp.Name = "textBoxROApp";
            this.textBoxROApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxROApp.TabIndex = 92;
            this.textBoxROApp.Tag = "RO";
            // 
            // textBoxEUApp
            // 
            this.textBoxEUApp.Enabled = false;
            this.textBoxEUApp.Location = new System.Drawing.Point(570, 562);
            this.textBoxEUApp.Name = "textBoxEUApp";
            this.textBoxEUApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxEUApp.TabIndex = 107;
            this.textBoxEUApp.Tag = "EMA";
            // 
            // checkBoxCZ
            // 
            this.checkBoxCZ.AutoSize = true;
            this.checkBoxCZ.Location = new System.Drawing.Point(19, 286);
            this.checkBoxCZ.Name = "checkBoxCZ";
            this.checkBoxCZ.Size = new System.Drawing.Size(71, 17);
            this.checkBoxCZ.TabIndex = 21;
            this.checkBoxCZ.Tag = "CZ";
            this.checkBoxCZ.Text = "CZ-SUKL";
            this.checkBoxCZ.UseVisualStyleBackColor = true;
            this.checkBoxCZ.CheckedChanged += new System.EventHandler(this.checkBoxCZ_CheckedChanged);
            // 
            // textBoxAT
            // 
            this.textBoxAT.Enabled = false;
            this.textBoxAT.Location = new System.Drawing.Point(115, 195);
            this.textBoxAT.Name = "textBoxAT";
            this.textBoxAT.Size = new System.Drawing.Size(100, 20);
            this.textBoxAT.TabIndex = 10;
            this.textBoxAT.Tag = "AT";
            // 
            // textBoxPTApp
            // 
            this.textBoxPTApp.Enabled = false;
            this.textBoxPTApp.Location = new System.Drawing.Point(570, 401);
            this.textBoxPTApp.Name = "textBoxPTApp";
            this.textBoxPTApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxPTApp.TabIndex = 89;
            this.textBoxPTApp.Tag = "PT";
            // 
            // textBoxEDApp
            // 
            this.textBoxEDApp.Enabled = false;
            this.textBoxEDApp.Location = new System.Drawing.Point(570, 539);
            this.textBoxEDApp.Name = "textBoxEDApp";
            this.textBoxEDApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxEDApp.TabIndex = 107;
            this.textBoxEDApp.Tag = "EDQM";
            // 
            // checkBoxDK
            // 
            this.checkBoxDK.AutoSize = true;
            this.checkBoxDK.Location = new System.Drawing.Point(19, 358);
            this.checkBoxDK.Name = "checkBoxDK";
            this.checkBoxDK.Size = new System.Drawing.Size(75, 17);
            this.checkBoxDK.TabIndex = 30;
            this.checkBoxDK.Tag = "DK";
            this.checkBoxDK.Text = "DK-DKMA";
            this.checkBoxDK.UseVisualStyleBackColor = true;
            this.checkBoxDK.CheckedChanged += new System.EventHandler(this.checkBoxDK_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(461, 177);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 13);
            this.label21.TabIndex = 58;
            this.label21.Text = "Invented name";
            // 
            // textBoxPLApp
            // 
            this.textBoxPLApp.Enabled = false;
            this.textBoxPLApp.Location = new System.Drawing.Point(570, 378);
            this.textBoxPLApp.Name = "textBoxPLApp";
            this.textBoxPLApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxPLApp.TabIndex = 86;
            this.textBoxPLApp.Tag = "PL";
            // 
            // textBoxFIApp
            // 
            this.textBoxFIApp.Enabled = false;
            this.textBoxFIApp.Location = new System.Drawing.Point(221, 450);
            this.textBoxFIApp.Name = "textBoxFIApp";
            this.textBoxFIApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxFIApp.TabIndex = 44;
            this.textBoxFIApp.Tag = "FI";
            // 
            // checkBoxEE
            // 
            this.checkBoxEE.AutoSize = true;
            this.checkBoxEE.Location = new System.Drawing.Point(19, 381);
            this.checkBoxEE.Name = "checkBoxEE";
            this.checkBoxEE.Size = new System.Drawing.Size(66, 17);
            this.checkBoxEE.TabIndex = 33;
            this.checkBoxEE.Tag = "EE";
            this.checkBoxEE.Text = "EE-SAM";
            this.checkBoxEE.UseVisualStyleBackColor = true;
            this.checkBoxEE.CheckedChanged += new System.EventHandler(this.checkBoxEE_CheckedChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(367, 177);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 13);
            this.label22.TabIndex = 57;
            this.label22.Text = "Country/Agency";
            // 
            // textBoxNOApp
            // 
            this.textBoxNOApp.Enabled = false;
            this.textBoxNOApp.Location = new System.Drawing.Point(570, 355);
            this.textBoxNOApp.Name = "textBoxNOApp";
            this.textBoxNOApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxNOApp.TabIndex = 83;
            this.textBoxNOApp.Tag = "NO";
            // 
            // textBoxFRApp
            // 
            this.textBoxFRApp.Enabled = false;
            this.textBoxFRApp.Location = new System.Drawing.Point(221, 473);
            this.textBoxFRApp.Name = "textBoxFRApp";
            this.textBoxFRApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxFRApp.TabIndex = 47;
            this.textBoxFRApp.Tag = "FR";
            // 
            // checkBoxED
            // 
            this.checkBoxED.AutoSize = true;
            this.checkBoxED.Location = new System.Drawing.Point(370, 539);
            this.checkBoxED.Name = "checkBoxED";
            this.checkBoxED.Size = new System.Drawing.Size(76, 17);
            this.checkBoxED.TabIndex = 105;
            this.checkBoxED.Tag = "EDQM";
            this.checkBoxED.Text = "EU-EDQM";
            this.checkBoxED.UseVisualStyleBackColor = true;
            this.checkBoxED.CheckedChanged += new System.EventHandler(this.checkBoxED_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(111, 177);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Invented name";
            // 
            // textBoxNLApp
            // 
            this.textBoxNLApp.Enabled = false;
            this.textBoxNLApp.Location = new System.Drawing.Point(570, 332);
            this.textBoxNLApp.Name = "textBoxNLApp";
            this.textBoxNLApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxNLApp.TabIndex = 80;
            this.textBoxNLApp.Tag = "NL";
            // 
            // textBoxDEApp
            // 
            this.textBoxDEApp.Enabled = false;
            this.textBoxDEApp.Location = new System.Drawing.Point(221, 309);
            this.textBoxDEApp.Name = "textBoxDEApp";
            this.textBoxDEApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxDEApp.TabIndex = 26;
            this.textBoxDEApp.Tag = "DE";
            // 
            // checkBoxEU
            // 
            this.checkBoxEU.AutoSize = true;
            this.checkBoxEU.Location = new System.Drawing.Point(370, 565);
            this.checkBoxEU.Name = "checkBoxEU";
            this.checkBoxEU.Size = new System.Drawing.Size(67, 17);
            this.checkBoxEU.TabIndex = 105;
            this.checkBoxEU.Tag = "EMA";
            this.checkBoxEU.Text = "EU-EMA";
            this.checkBoxEU.UseVisualStyleBackColor = true;
            this.checkBoxEU.CheckedChanged += new System.EventHandler(this.checkBoxEU_CheckedChanged);
            // 
            // checkBoxLI
            // 
            this.checkBoxLI.AutoSize = true;
            this.checkBoxLI.Location = new System.Drawing.Point(370, 217);
            this.checkBoxLI.Name = "checkBoxLI";
            this.checkBoxLI.Size = new System.Drawing.Size(57, 17);
            this.checkBoxLI.TabIndex = 63;
            this.checkBoxLI.Tag = "LI";
            this.checkBoxLI.Text = "LI-LLV";
            this.checkBoxLI.UseVisualStyleBackColor = true;
            this.checkBoxLI.CheckedChanged += new System.EventHandler(this.checkBoxLI_CheckedChanged);
            // 
            // textBoxMTApp
            // 
            this.textBoxMTApp.Enabled = false;
            this.textBoxMTApp.Location = new System.Drawing.Point(570, 309);
            this.textBoxMTApp.Name = "textBoxMTApp";
            this.textBoxMTApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxMTApp.TabIndex = 77;
            this.textBoxMTApp.Tag = "MT";
            // 
            // textBoxELApp
            // 
            this.textBoxELApp.Enabled = false;
            this.textBoxELApp.Location = new System.Drawing.Point(221, 404);
            this.textBoxELApp.Name = "textBoxELApp";
            this.textBoxELApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxELApp.TabIndex = 38;
            this.textBoxELApp.Tag = "EL";
            // 
            // checkBoxFI
            // 
            this.checkBoxFI.AutoSize = true;
            this.checkBoxFI.Location = new System.Drawing.Point(19, 450);
            this.checkBoxFI.Name = "checkBoxFI";
            this.checkBoxFI.Size = new System.Drawing.Size(70, 17);
            this.checkBoxFI.TabIndex = 42;
            this.checkBoxFI.Tag = "FI";
            this.checkBoxFI.Text = "FI-FIMEA";
            this.checkBoxFI.UseVisualStyleBackColor = true;
            this.checkBoxFI.CheckedChanged += new System.EventHandler(this.checkBoxFI_CheckedChanged);
            // 
            // checkBoxLV
            // 
            this.checkBoxLV.AutoSize = true;
            this.checkBoxLV.Location = new System.Drawing.Point(370, 286);
            this.checkBoxLV.Name = "checkBoxLV";
            this.checkBoxLV.Size = new System.Drawing.Size(63, 17);
            this.checkBoxLV.TabIndex = 72;
            this.checkBoxLV.Tag = "LV";
            this.checkBoxLV.Text = "LV-ZVA";
            this.checkBoxLV.UseVisualStyleBackColor = true;
            this.checkBoxLV.CheckedChanged += new System.EventHandler(this.checkBoxLV_CheckedChanged);
            // 
            // textBoxLUApp
            // 
            this.textBoxLUApp.Enabled = false;
            this.textBoxLUApp.Location = new System.Drawing.Point(570, 263);
            this.textBoxLUApp.Name = "textBoxLUApp";
            this.textBoxLUApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxLUApp.TabIndex = 71;
            this.textBoxLUApp.Tag = "LU";
            // 
            // textBoxHUApp
            // 
            this.textBoxHUApp.Enabled = false;
            this.textBoxHUApp.Location = new System.Drawing.Point(222, 519);
            this.textBoxHUApp.Name = "textBoxHUApp";
            this.textBoxHUApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxHUApp.TabIndex = 53;
            this.textBoxHUApp.Tag = "HU";
            // 
            // checkBoxFR
            // 
            this.checkBoxFR.AutoSize = true;
            this.checkBoxFR.Location = new System.Drawing.Point(19, 473);
            this.checkBoxFR.Name = "checkBoxFR";
            this.checkBoxFR.Size = new System.Drawing.Size(74, 17);
            this.checkBoxFR.TabIndex = 45;
            this.checkBoxFR.Tag = "FR";
            this.checkBoxFR.Text = "FR-ANSM";
            this.checkBoxFR.UseVisualStyleBackColor = true;
            this.checkBoxFR.CheckedChanged += new System.EventHandler(this.checkBoxFR_CheckedChanged);
            // 
            // checkBoxIT
            // 
            this.checkBoxIT.AutoSize = true;
            this.checkBoxIT.Location = new System.Drawing.Point(370, 194);
            this.checkBoxIT.Name = "checkBoxIT";
            this.checkBoxIT.Size = new System.Drawing.Size(62, 17);
            this.checkBoxIT.TabIndex = 60;
            this.checkBoxIT.Tag = "IT";
            this.checkBoxIT.Text = "IT-AIFA";
            this.checkBoxIT.UseVisualStyleBackColor = true;
            this.checkBoxIT.CheckedChanged += new System.EventHandler(this.checkBoxIT_CheckedChanged);
            // 
            // textBoxLTApp
            // 
            this.textBoxLTApp.Enabled = false;
            this.textBoxLTApp.Location = new System.Drawing.Point(570, 240);
            this.textBoxLTApp.Name = "textBoxLTApp";
            this.textBoxLTApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxLTApp.TabIndex = 68;
            this.textBoxLTApp.Tag = "LT";
            // 
            // textBoxISApp
            // 
            this.textBoxISApp.Enabled = false;
            this.textBoxISApp.Location = new System.Drawing.Point(222, 565);
            this.textBoxISApp.Name = "textBoxISApp";
            this.textBoxISApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxISApp.TabIndex = 59;
            this.textBoxISApp.Tag = "IS";
            // 
            // checkBoxDE
            // 
            this.checkBoxDE.AutoSize = true;
            this.checkBoxDE.Location = new System.Drawing.Point(19, 309);
            this.checkBoxDE.Name = "checkBoxDE";
            this.checkBoxDE.Size = new System.Drawing.Size(81, 17);
            this.checkBoxDE.TabIndex = 24;
            this.checkBoxDE.Tag = "DE";
            this.checkBoxDE.Text = "DE-BFARM";
            this.checkBoxDE.UseVisualStyleBackColor = true;
            this.checkBoxDE.CheckedChanged += new System.EventHandler(this.checkBoxDE_CheckedChanged);
            // 
            // checkBoxIE
            // 
            this.checkBoxIE.AutoSize = true;
            this.checkBoxIE.Location = new System.Drawing.Point(20, 542);
            this.checkBoxIE.Name = "checkBoxIE";
            this.checkBoxIE.Size = new System.Drawing.Size(69, 17);
            this.checkBoxIE.TabIndex = 54;
            this.checkBoxIE.Tag = "IE";
            this.checkBoxIE.Text = "IE-HPRA";
            this.checkBoxIE.UseVisualStyleBackColor = true;
            this.checkBoxIE.CheckedChanged += new System.EventHandler(this.checkBoxIE_CheckedChanged);
            // 
            // textBoxLIApp
            // 
            this.textBoxLIApp.Enabled = false;
            this.textBoxLIApp.Location = new System.Drawing.Point(570, 217);
            this.textBoxLIApp.Name = "textBoxLIApp";
            this.textBoxLIApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxLIApp.TabIndex = 65;
            this.textBoxLIApp.Tag = "LI";
            // 
            // textBoxIEApp
            // 
            this.textBoxIEApp.Enabled = false;
            this.textBoxIEApp.Location = new System.Drawing.Point(222, 542);
            this.textBoxIEApp.Name = "textBoxIEApp";
            this.textBoxIEApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxIEApp.TabIndex = 56;
            this.textBoxIEApp.Tag = "IE";
            // 
            // checkBoxEL
            // 
            this.checkBoxEL.AutoSize = true;
            this.checkBoxEL.Location = new System.Drawing.Point(19, 404);
            this.checkBoxEL.Name = "checkBoxEL";
            this.checkBoxEL.Size = new System.Drawing.Size(63, 17);
            this.checkBoxEL.TabIndex = 36;
            this.checkBoxEL.Tag = "EL";
            this.checkBoxEL.Text = "EL-EOF";
            this.checkBoxEL.UseVisualStyleBackColor = true;
            this.checkBoxEL.CheckedChanged += new System.EventHandler(this.checkBoxEL_CheckedChanged);
            // 
            // checkBoxIS
            // 
            this.checkBoxIS.AutoSize = true;
            this.checkBoxIS.Location = new System.Drawing.Point(20, 565);
            this.checkBoxIS.Name = "checkBoxIS";
            this.checkBoxIS.Size = new System.Drawing.Size(65, 17);
            this.checkBoxIS.TabIndex = 57;
            this.checkBoxIS.Tag = "IS";
            this.checkBoxIS.Text = "IS-IMCA";
            this.checkBoxIS.UseVisualStyleBackColor = true;
            this.checkBoxIS.CheckedChanged += new System.EventHandler(this.checkBoxIS_CheckedChanged);
            // 
            // textBoxLVApp
            // 
            this.textBoxLVApp.Enabled = false;
            this.textBoxLVApp.Location = new System.Drawing.Point(570, 286);
            this.textBoxLVApp.Name = "textBoxLVApp";
            this.textBoxLVApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxLVApp.TabIndex = 74;
            this.textBoxLVApp.Tag = "LV";
            // 
            // textBoxITApp
            // 
            this.textBoxITApp.Enabled = false;
            this.textBoxITApp.Location = new System.Drawing.Point(570, 193);
            this.textBoxITApp.Name = "textBoxITApp";
            this.textBoxITApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxITApp.TabIndex = 62;
            this.textBoxITApp.Tag = "IT";
            // 
            // checkBoxHU
            // 
            this.checkBoxHU.AutoSize = true;
            this.checkBoxHU.Location = new System.Drawing.Point(20, 519);
            this.checkBoxHU.Name = "checkBoxHU";
            this.checkBoxHU.Size = new System.Drawing.Size(71, 17);
            this.checkBoxHU.TabIndex = 51;
            this.checkBoxHU.Tag = "HU";
            this.checkBoxHU.Text = "HU-OGYI";
            this.checkBoxHU.UseVisualStyleBackColor = true;
            this.checkBoxHU.CheckedChanged += new System.EventHandler(this.checkBoxHU_CheckedChanged);
            // 
            // fileExplorerUserControl
            // 
            this.fileExplorerUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileExplorerUserControl.Location = new System.Drawing.Point(0, 63);
            this.fileExplorerUserControl.Margin = new System.Windows.Forms.Padding(2);
            this.fileExplorerUserControl.Name = "fileExplorerUserControl";
            this.fileExplorerUserControl.Size = new System.Drawing.Size(181, 551);
            this.fileExplorerUserControl.TabIndex = 123;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 614);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "6";
            this.Text = "eCTD indexer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubmissionUnitCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubDescCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRelSeqCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbModeCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubmissionTypeCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProcedureTypeCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNumberCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrackingNoCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbINNCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIdentifierCopy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTrackNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxProcType;
		private System.Windows.Forms.ComboBox comboBoxSubmUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSubmType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxINN;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxSubmDescr;
        private System.Windows.Forms.Label labelSubmissionUnit;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox checkBoxAT;
        private System.Windows.Forms.CheckBox checkBoxBE;
        private System.Windows.Forms.CheckBox checkBoxBG;
        private System.Windows.Forms.CheckBox checkBoxCY;
        private System.Windows.Forms.CheckBox checkBoxCZ;
        private System.Windows.Forms.CheckBox checkBoxDK;
        private System.Windows.Forms.CheckBox checkBoxEE;
        private System.Windows.Forms.CheckBox checkBoxEU;
		private System.Windows.Forms.CheckBox checkBoxED;
        private System.Windows.Forms.CheckBox checkBoxFI;
        private System.Windows.Forms.CheckBox checkBoxFR;
        private System.Windows.Forms.CheckBox checkBoxDE;
        private System.Windows.Forms.CheckBox checkBoxEL;
        private System.Windows.Forms.CheckBox checkBoxHU;
        private System.Windows.Forms.CheckBox checkBoxIS;
        private System.Windows.Forms.CheckBox checkBoxIE;
        private System.Windows.Forms.CheckBox checkBoxIT;
        private System.Windows.Forms.CheckBox checkBoxLV;
        private System.Windows.Forms.CheckBox checkBoxLI;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxAT;
        private System.Windows.Forms.CheckBox checkBoxUK;
        private System.Windows.Forms.CheckBox checkBoxSE;
        private System.Windows.Forms.CheckBox checkBoxES;
        private System.Windows.Forms.CheckBox checkBoxSI;
        private System.Windows.Forms.CheckBox checkBoxSK;
        private System.Windows.Forms.CheckBox checkBoxRO;
        private System.Windows.Forms.CheckBox checkBoxPT;
        private System.Windows.Forms.CheckBox checkBoxPL;
        private System.Windows.Forms.CheckBox checkBoxNO;
        private System.Windows.Forms.CheckBox checkBoxNL;
        private System.Windows.Forms.CheckBox checkBoxMT;
        private System.Windows.Forms.CheckBox checkBoxLU;
        private System.Windows.Forms.CheckBox checkBoxLT;
        private System.Windows.Forms.TextBox textBoxBE;
        private System.Windows.Forms.TextBox textBoxBG;
        private System.Windows.Forms.TextBox textBoxCY;
        private System.Windows.Forms.TextBox textBoxCZ;
        private System.Windows.Forms.TextBox textBoxDK;
        private System.Windows.Forms.TextBox textBoxEE;
		private System.Windows.Forms.TextBox textBoxED;
        private System.Windows.Forms.TextBox textBoxEU;
        private System.Windows.Forms.TextBox textBoxFI;
        private System.Windows.Forms.TextBox textBoxFR;
        private System.Windows.Forms.TextBox textBoxDE;
        private System.Windows.Forms.TextBox textBoxEL;
        private System.Windows.Forms.TextBox textBoxHU;
        private System.Windows.Forms.TextBox textBoxIS;
        private System.Windows.Forms.TextBox textBoxIE;
        private System.Windows.Forms.TextBox textBoxIT;
        private System.Windows.Forms.TextBox textBoxLV;
        private System.Windows.Forms.TextBox textBoxLI;
        private System.Windows.Forms.TextBox textBoxUK;
        private System.Windows.Forms.TextBox textBoxSE;
        private System.Windows.Forms.TextBox textBoxES;
        private System.Windows.Forms.TextBox textBoxSI;
        private System.Windows.Forms.TextBox textBoxSK;
        private System.Windows.Forms.TextBox textBoxRO;
        private System.Windows.Forms.TextBox textBoxPT;
        private System.Windows.Forms.TextBox textBoxPL;
        private System.Windows.Forms.TextBox textBoxNO;
        private System.Windows.Forms.TextBox textBoxNL;
        private System.Windows.Forms.TextBox textBoxMT;
        private System.Windows.Forms.TextBox textBoxLU;
        private System.Windows.Forms.TextBox textBoxLT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxITApp;
        private System.Windows.Forms.TextBox textBoxIEApp;
        private System.Windows.Forms.TextBox textBoxISApp;
        private System.Windows.Forms.TextBox textBoxHUApp;
        private System.Windows.Forms.TextBox textBoxELApp;
        private System.Windows.Forms.TextBox textBoxDEApp;
        private System.Windows.Forms.TextBox textBoxFRApp;
        private System.Windows.Forms.TextBox textBoxFIApp;
		private System.Windows.Forms.TextBox textBoxEDApp;
        private System.Windows.Forms.TextBox textBoxEUApp;
        private System.Windows.Forms.TextBox textBoxEEApp;
        private System.Windows.Forms.TextBox textBoxDKApp;
        private System.Windows.Forms.TextBox textBoxCZApp;
        private System.Windows.Forms.TextBox textBoxCYApp;
        private System.Windows.Forms.TextBox textBoxBGApp;
        private System.Windows.Forms.TextBox textBoxBEApp;
        private System.Windows.Forms.TextBox textBoxATApp;
        private System.Windows.Forms.TextBox textBoxUKApp;
        private System.Windows.Forms.TextBox textBoxSEApp;
        private System.Windows.Forms.TextBox textBoxESApp;
        private System.Windows.Forms.TextBox textBoxSIApp;
        private System.Windows.Forms.TextBox textBoxSKApp;
        private System.Windows.Forms.TextBox textBoxROApp;
        private System.Windows.Forms.TextBox textBoxPTApp;
        private System.Windows.Forms.TextBox textBoxPLApp;
        private System.Windows.Forms.TextBox textBoxNOApp;
        private System.Windows.Forms.TextBox textBoxNLApp;
        private System.Windows.Forms.TextBox textBoxMTApp;
        private System.Windows.Forms.TextBox textBoxLUApp;
        private System.Windows.Forms.TextBox textBoxLTApp;
        private System.Windows.Forms.TextBox textBoxLIApp;
        private System.Windows.Forms.TextBox textBoxLVApp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRelSeq;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.Label labelSequence;
        private System.Windows.Forms.TextBox textBoxHRApp;
        private System.Windows.Forms.TextBox textBoxHR;
        private System.Windows.Forms.CheckBox checkBoxHR;
        private System.Windows.Forms.TextBox textBoxDE2App;
        private System.Windows.Forms.TextBox textBoxDE2;
        private System.Windows.Forms.CheckBox checkBoxDE2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbOpenDossier;
        private FileExplorerUserControl fileExplorerUserControl;
        private System.Windows.Forms.ToolStripButton tsbCreate;
        private System.Windows.Forms.ToolStripButton tsbCreateXMLFiles;
        private System.Windows.Forms.ToolStripButton tsbRefreshFolderView;
        private System.Windows.Forms.ToolStripButton tsbDeleteEmptyFolder;
        private System.Windows.Forms.ToolStripButton tsbAbout;
        private System.Windows.Forms.ToolStripButton tsbCloseDossier;
        private System.Windows.Forms.ToolStripButton tsbCloseApp;
        private System.Windows.Forms.ToolStripButton tsbOptions;
        private System.Windows.Forms.ToolStripButton tsbAssemble;
        private System.Windows.Forms.ToolStripButton tsbDiagnostic;
        private System.Windows.Forms.TextBox tbIdentifier;
        private System.Windows.Forms.PictureBox pbIdentifierCopy;
        private System.Windows.Forms.PictureBox pbINNCopy;
        private System.Windows.Forms.PictureBox pbNumberCopy;
        private System.Windows.Forms.PictureBox pbTrackingNoCopy;
        private System.Windows.Forms.ToolStripButton tsbAdoptInformation;
        private System.Windows.Forms.ToolStripButton tsbPackDossier;
        private System.Windows.Forms.PictureBox pbModeCopy;
        private System.Windows.Forms.PictureBox pbSubmissionTypeCopy;
        private System.Windows.Forms.PictureBox pbProcedureTypeCopy;
        private System.Windows.Forms.PictureBox pbSubmissionUnitCopy;
        private System.Windows.Forms.PictureBox pbSubDescCopy;
        private System.Windows.Forms.PictureBox pbRelSeqCopy;
        private System.Windows.Forms.ToolStripButton tsbOpenLastDossier;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDossierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDossierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLastDossierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeValidationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fileNamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsbiCloseDossier;
        private System.Windows.Forms.ToolStripMenuItem tsbideleteAllEmptyDirectoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createXMLFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zipDossierToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiProperties;
    }
}

