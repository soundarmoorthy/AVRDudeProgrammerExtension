namespace AtmelStudio.AVRDude.Wrapper
{
    partial class AVRDudeUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AVRDudeUI));
            this.radioConfFile = new System.Windows.Forms.RadioButton();
            this.radioCmdLine = new System.Windows.Forms.RadioButton();
            this.lnkHelp = new System.Windows.Forms.LinkLabel();
            this.txtConfFilePath = new System.Windows.Forms.TextBox();
            this.txtCommandLine = new System.Windows.Forms.TextBox();
            this.btnChooseConf = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAVRDudePath = new System.Windows.Forms.TextBox();
            this.btnChooseExecutable = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProgramPath = new System.Windows.Forms.TextBox();
            this.btnSelectBinary = new System.Windows.Forms.Button();
            this.btnProgram = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.outputWindow = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioConfFile
            // 
            this.radioConfFile.AutoSize = true;
            this.radioConfFile.Location = new System.Drawing.Point(3, 61);
            this.radioConfFile.Name = "radioConfFile";
            this.radioConfFile.Size = new System.Drawing.Size(110, 17);
            this.radioConfFile.TabIndex = 5;
            this.radioConfFile.TabStop = true;
            this.radioConfFile.Text = "Use avrdude.conf";
            this.radioConfFile.UseVisualStyleBackColor = true;
            // 
            // radioCmdLine
            // 
            this.radioCmdLine.AutoSize = true;
            this.radioCmdLine.Location = new System.Drawing.Point(3, 19);
            this.radioCmdLine.Name = "radioCmdLine";
            this.radioCmdLine.Size = new System.Drawing.Size(95, 17);
            this.radioCmdLine.TabIndex = 4;
            this.radioCmdLine.TabStop = true;
            this.radioCmdLine.Text = "Command Line";
            this.radioCmdLine.UseVisualStyleBackColor = true;
            // 
            // lnkHelp
            // 
            this.lnkHelp.AutoSize = true;
            this.lnkHelp.Location = new System.Drawing.Point(396, 21);
            this.lnkHelp.Name = "lnkHelp";
            this.lnkHelp.Size = new System.Drawing.Size(66, 13);
            this.lnkHelp.TabIndex = 0;
            this.lnkHelp.TabStop = true;
            this.lnkHelp.Text = "Options help";
            this.lnkHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHelp_LinkClicked);
            // 
            // txtConfFilePath
            // 
            this.txtConfFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfFilePath.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtConfFilePath.Location = new System.Drawing.Point(121, 63);
            this.txtConfFilePath.Multiline = true;
            this.txtConfFilePath.Name = "txtConfFilePath";
            this.txtConfFilePath.Size = new System.Drawing.Size(269, 20);
            this.txtConfFilePath.TabIndex = 7;
            // 
            // txtCommandLine
            // 
            this.txtCommandLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommandLine.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCommandLine.Location = new System.Drawing.Point(121, 16);
            this.txtCommandLine.Multiline = true;
            this.txtCommandLine.Name = "txtCommandLine";
            this.txtCommandLine.Size = new System.Drawing.Size(269, 20);
            this.txtCommandLine.TabIndex = 6;
            // 
            // btnChooseConf
            // 
            this.btnChooseConf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChooseConf.Location = new System.Drawing.Point(399, 63);
            this.btnChooseConf.Name = "btnChooseConf";
            this.btnChooseConf.Size = new System.Drawing.Size(27, 20);
            this.btnChooseConf.TabIndex = 9;
            this.btnChooseConf.Text = "...";
            this.btnChooseConf.UseVisualStyleBackColor = true;
            this.btnChooseConf.Click += new System.EventHandler(this.btnChooseConf_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChooseConf);
            this.groupBox1.Controls.Add(this.txtCommandLine);
            this.groupBox1.Controls.Add(this.txtConfFilePath);
            this.groupBox1.Controls.Add(this.lnkHelp);
            this.groupBox1.Controls.Add(this.radioCmdLine);
            this.groupBox1.Controls.Add(this.radioConfFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 95);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options Selection";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select AVRDude Path";
            // 
            // txtAVRDudePath
            // 
            this.txtAVRDudePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAVRDudePath.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAVRDudePath.Location = new System.Drawing.Point(133, 55);
            this.txtAVRDudePath.Multiline = true;
            this.txtAVRDudePath.Name = "txtAVRDudePath";
            this.txtAVRDudePath.Size = new System.Drawing.Size(272, 20);
            this.txtAVRDudePath.TabIndex = 2;
            // 
            // btnChooseExecutable
            // 
            this.btnChooseExecutable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChooseExecutable.Location = new System.Drawing.Point(411, 55);
            this.btnChooseExecutable.Name = "btnChooseExecutable";
            this.btnChooseExecutable.Size = new System.Drawing.Size(27, 20);
            this.btnChooseExecutable.TabIndex = 3;
            this.btnChooseExecutable.Text = "...";
            this.btnChooseExecutable.UseVisualStyleBackColor = true;
            this.btnChooseExecutable.Click += new System.EventHandler(this.btnChooseExecutable_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select File to program";
            // 
            // txtProgramPath
            // 
            this.txtProgramPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProgramPath.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtProgramPath.Location = new System.Drawing.Point(133, 9);
            this.txtProgramPath.Multiline = true;
            this.txtProgramPath.Name = "txtProgramPath";
            this.txtProgramPath.Size = new System.Drawing.Size(272, 20);
            this.txtProgramPath.TabIndex = 10;
            // 
            // btnSelectBinary
            // 
            this.btnSelectBinary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectBinary.Location = new System.Drawing.Point(411, 9);
            this.btnSelectBinary.Name = "btnSelectBinary";
            this.btnSelectBinary.Size = new System.Drawing.Size(27, 20);
            this.btnSelectBinary.TabIndex = 11;
            this.btnSelectBinary.Text = "...";
            this.btnSelectBinary.UseVisualStyleBackColor = true;
            this.btnSelectBinary.Click += new System.EventHandler(this.btnSelectBinary_Click);
            // 
            // btnProgram
            // 
            this.btnProgram.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProgram.Location = new System.Drawing.Point(308, 190);
            this.btnProgram.Name = "btnProgram";
            this.btnProgram.Size = new System.Drawing.Size(97, 41);
            this.btnProgram.TabIndex = 10;
            this.btnProgram.Text = "Program";
            this.btnProgram.UseVisualStyleBackColor = true;
            this.btnProgram.Click += new System.EventHandler(this.btnProgram_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(427, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 41);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(483, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 45);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // outputWindow
            // 
            this.outputWindow.AutoWordSelection = true;
            this.outputWindow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputWindow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputWindow.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputWindow.ForeColor = System.Drawing.SystemColors.Menu;
            this.outputWindow.Location = new System.Drawing.Point(0, 0);
            this.outputWindow.Name = "outputWindow";
            this.outputWindow.ShowSelectionMargin = true;
            this.outputWindow.Size = new System.Drawing.Size(100, 96);
            this.outputWindow.TabIndex = 14;
            this.outputWindow.Text = "";
            this.outputWindow.Visible = false;
            // 
            // AVRDudeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(536, 243);
            this.Controls.Add(this.outputWindow);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnProgram);
            this.Controls.Add(this.btnSelectBinary);
            this.Controls.Add(this.txtProgramPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChooseExecutable);
            this.Controls.Add(this.txtAVRDudePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AVRDudeUI";
            this.Text = "Program using avrdude.exe";
            this.Load += new System.EventHandler(this.AVRDudeUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioConfFile;
        private System.Windows.Forms.RadioButton radioCmdLine;
        private System.Windows.Forms.LinkLabel lnkHelp;
        private System.Windows.Forms.TextBox txtConfFilePath;
        private System.Windows.Forms.TextBox txtCommandLine;
        private System.Windows.Forms.Button btnChooseConf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAVRDudePath;
        private System.Windows.Forms.Button btnChooseExecutable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProgramPath;
        private System.Windows.Forms.Button btnSelectBinary;
        private System.Windows.Forms.Button btnProgram;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox outputWindow;
    }
}