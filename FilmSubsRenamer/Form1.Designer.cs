namespace FilmSubsRenamer
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstBoxManualRename_FileVideo = new System.Windows.Forms.ListBox();
            this.lstBoxManualRename_FilesSubs = new System.Windows.Forms.ListBox();
            this.btnManualRename_RinominaFiles = new System.Windows.Forms.Button();
            this.lblManualRename_Video = new System.Windows.Forms.Label();
            this.lblManualRename_Subs = new System.Windows.Forms.Label();
            this.lstBoxAutoRename_RiordinaTuttiFiles = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAutoRename = new System.Windows.Forms.TabPage();
            this.tabPageManualRename = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPageAutoRename.SuspendLayout();
            this.tabPageManualRename.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBoxManualRename_FileVideo
            // 
            this.lstBoxManualRename_FileVideo.AllowDrop = true;
            this.lstBoxManualRename_FileVideo.FormattingEnabled = true;
            this.lstBoxManualRename_FileVideo.Location = new System.Drawing.Point(8, 20);
            this.lstBoxManualRename_FileVideo.Name = "lstBoxManualRename_FileVideo";
            this.lstBoxManualRename_FileVideo.Size = new System.Drawing.Size(195, 446);
            this.lstBoxManualRename_FileVideo.TabIndex = 0;
            this.lstBoxManualRename_FileVideo.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.lstBoxManualRename_FileVideo.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            // 
            // lstBoxManualRename_FilesSubs
            // 
            this.lstBoxManualRename_FilesSubs.AllowDrop = true;
            this.lstBoxManualRename_FilesSubs.FormattingEnabled = true;
            this.lstBoxManualRename_FilesSubs.Location = new System.Drawing.Point(209, 20);
            this.lstBoxManualRename_FilesSubs.Name = "lstBoxManualRename_FilesSubs";
            this.lstBoxManualRename_FilesSubs.Size = new System.Drawing.Size(195, 446);
            this.lstBoxManualRename_FilesSubs.TabIndex = 1;
            this.lstBoxManualRename_FilesSubs.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox2_DragDrop);
            this.lstBoxManualRename_FilesSubs.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox2_DragEnter);
            // 
            // btnManualRename_RinominaFiles
            // 
            this.btnManualRename_RinominaFiles.Location = new System.Drawing.Point(243, 1);
            this.btnManualRename_RinominaFiles.Name = "btnManualRename_RinominaFiles";
            this.btnManualRename_RinominaFiles.Size = new System.Drawing.Size(161, 19);
            this.btnManualRename_RinominaFiles.TabIndex = 2;
            this.btnManualRename_RinominaFiles.Text = "Rinomina!";
            this.btnManualRename_RinominaFiles.UseVisualStyleBackColor = true;
            this.btnManualRename_RinominaFiles.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblManualRename_Video
            // 
            this.lblManualRename_Video.AutoSize = true;
            this.lblManualRename_Video.Location = new System.Drawing.Point(5, 4);
            this.lblManualRename_Video.Name = "lblManualRename_Video";
            this.lblManualRename_Video.Size = new System.Drawing.Size(34, 13);
            this.lblManualRename_Video.TabIndex = 3;
            this.lblManualRename_Video.Text = "Video";
            // 
            // lblManualRename_Subs
            // 
            this.lblManualRename_Subs.AutoSize = true;
            this.lblManualRename_Subs.Location = new System.Drawing.Point(206, 4);
            this.lblManualRename_Subs.Name = "lblManualRename_Subs";
            this.lblManualRename_Subs.Size = new System.Drawing.Size(31, 13);
            this.lblManualRename_Subs.TabIndex = 4;
            this.lblManualRename_Subs.Text = "Subs";
            // 
            // lstBoxAutoRename_RiordinaTuttiFiles
            // 
            this.lstBoxAutoRename_RiordinaTuttiFiles.AllowDrop = true;
            this.lstBoxAutoRename_RiordinaTuttiFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBoxAutoRename_RiordinaTuttiFiles.FormattingEnabled = true;
            this.lstBoxAutoRename_RiordinaTuttiFiles.Location = new System.Drawing.Point(7, 6);
            this.lstBoxAutoRename_RiordinaTuttiFiles.Name = "lstBoxAutoRename_RiordinaTuttiFiles";
            this.lstBoxAutoRename_RiordinaTuttiFiles.Size = new System.Drawing.Size(397, 459);
            this.lstBoxAutoRename_RiordinaTuttiFiles.TabIndex = 5;
            this.lstBoxAutoRename_RiordinaTuttiFiles.SelectedIndexChanged += new System.EventHandler(this.lstBoxAutoRename_RiordinaTuttiFiles_SelectedIndexChanged);
            this.lstBoxAutoRename_RiordinaTuttiFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox3_DragDrop);
            this.lstBoxAutoRename_RiordinaTuttiFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox3_DragEnter);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageAutoRename);
            this.tabControl1.Controls.Add(this.tabPageManualRename);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(419, 496);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPageAutoRename
            // 
            this.tabPageAutoRename.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPageAutoRename.Controls.Add(this.lstBoxAutoRename_RiordinaTuttiFiles);
            this.tabPageAutoRename.Location = new System.Drawing.Point(4, 22);
            this.tabPageAutoRename.Name = "tabPageAutoRename";
            this.tabPageAutoRename.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAutoRename.Size = new System.Drawing.Size(411, 470);
            this.tabPageAutoRename.TabIndex = 0;
            this.tabPageAutoRename.Text = "AutoRename";
            // 
            // tabPageManualRename
            // 
            this.tabPageManualRename.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPageManualRename.Controls.Add(this.lstBoxManualRename_FileVideo);
            this.tabPageManualRename.Controls.Add(this.lblManualRename_Subs);
            this.tabPageManualRename.Controls.Add(this.lstBoxManualRename_FilesSubs);
            this.tabPageManualRename.Controls.Add(this.lblManualRename_Video);
            this.tabPageManualRename.Controls.Add(this.btnManualRename_RinominaFiles);
            this.tabPageManualRename.Location = new System.Drawing.Point(4, 22);
            this.tabPageManualRename.Name = "tabPageManualRename";
            this.tabPageManualRename.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManualRename.Size = new System.Drawing.Size(411, 470);
            this.tabPageManualRename.TabIndex = 1;
            this.tabPageManualRename.Text = "ManualRename";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 499);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(421, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabel1.Text = "stato";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(421, 521);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FilmSubsRenamer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAutoRename.ResumeLayout(false);
            this.tabPageManualRename.ResumeLayout(false);
            this.tabPageManualRename.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxManualRename_FileVideo;
        private System.Windows.Forms.ListBox lstBoxManualRename_FilesSubs;
        private System.Windows.Forms.Button btnManualRename_RinominaFiles;
        private System.Windows.Forms.Label lblManualRename_Video;
        private System.Windows.Forms.Label lblManualRename_Subs;
        private System.Windows.Forms.ListBox lstBoxAutoRename_RiordinaTuttiFiles;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAutoRename;
        private System.Windows.Forms.TabPage tabPageManualRename;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

