namespace FilmSubsRenamer
{
    partial class frmPrincipale
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nodo2");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nodo3");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nodo4");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Interfaccia", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Nodo5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Nodo6");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Estensioni", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipale));
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPageAutoRename.SuspendLayout();
            this.tabPageManualRename.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.lstBoxAutoRename_RiordinaTuttiFiles.HorizontalScrollbar = true;
            this.lstBoxAutoRename_RiordinaTuttiFiles.Location = new System.Drawing.Point(7, 6);
            this.lstBoxAutoRename_RiordinaTuttiFiles.Name = "lstBoxAutoRename_RiordinaTuttiFiles";
            this.lstBoxAutoRename_RiordinaTuttiFiles.Size = new System.Drawing.Size(397, 459);
            this.lstBoxAutoRename_RiordinaTuttiFiles.Sorted = true;
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
            this.tabControl1.Controls.Add(this.tabPage1);
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
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Yellow;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(60, 17);
            this.toolStripStatusLabel1.Text = "In attesa...";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(411, 470);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Impostazioni";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(149, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 458);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 46);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Associa nomi ";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(64, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sottotitolo";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Video";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.treeView1.Location = new System.Drawing.Point(3, 6);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nodo2";
            treeNode1.Text = "Nodo2";
            treeNode2.Name = "Nodo3";
            treeNode2.Text = "Nodo3";
            treeNode3.Name = "Nodo4";
            treeNode3.Text = "Nodo4";
            treeNode4.Name = "Nodo0";
            treeNode4.Text = "Interfaccia";
            treeNode5.Name = "Nodo5";
            treeNode5.Text = "Nodo5";
            treeNode6.Name = "Nodo6";
            treeNode6.Text = "Nodo6";
            treeNode7.Name = "Nodo1";
            treeNode7.Text = "Estensioni";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7});
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(140, 458);
            this.treeView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aggiorna";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AutoRename",
            "ManualRename"});
            this.comboBox1.Location = new System.Drawing.Point(9, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // frmPrincipale
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
            this.Name = "frmPrincipale";
            this.Text = "FilmSubsRenamer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAutoRename.ResumeLayout(false);
            this.tabPageManualRename.ResumeLayout(false);
            this.tabPageManualRename.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

