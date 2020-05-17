namespace BulkImageCroping
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.showImageRepet = new System.Windows.Forms.ToolStripButton();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addFileButton = new System.Windows.Forms.ToolStripButton();
            this.RemoveButton = new System.Windows.Forms.ToolStripButton();
            this.RemoveAllButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.W = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.H = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.config = new System.Windows.Forms.ToolStripComboBox();
            this.cropBtn = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.inputListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.priview = new System.Windows.Forms.WebBrowser();
            this.addFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showImageRepet,
            this.progressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // showImageRepet
            // 
            this.showImageRepet.CheckOnClick = true;
            this.showImageRepet.Image = global::BulkImageCroping.Properties.Resources.ImageBox;
            this.showImageRepet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showImageRepet.Name = "showImageRepet";
            this.showImageRepet.Size = new System.Drawing.Size(81, 20);
            this.showImageRepet.Text = "Tile Image";
            this.showImageRepet.Click += new System.EventHandler(this.ShowImageRepet_Click);
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(400, 16);
            this.progressBar.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFileButton,
            this.RemoveButton,
            this.RemoveAllButton,
            this.toolStripLabel1,
            this.W,
            this.toolStripLabel3,
            this.H,
            this.toolStripLabel2,
            this.config,
            this.cropBtn,
            this.toolStripLabel4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addFileButton
            // 
            this.addFileButton.Image = ((System.Drawing.Image)(resources.GetObject("addFileButton.Image")));
            this.addFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(77, 22);
            this.addFileButton.Text = "Add file...";
            this.addFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RemoveButton.Enabled = false;
            this.RemoveButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveButton.Image")));
            this.RemoveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(23, 22);
            this.RemoveButton.Text = "Remove selected";
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // RemoveAllButton
            // 
            this.RemoveAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RemoveAllButton.Enabled = false;
            this.RemoveAllButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveAllButton.Image")));
            this.RemoveAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveAllButton.Name = "RemoveAllButton";
            this.RemoveAllButton.Size = new System.Drawing.Size(23, 22);
            this.RemoveAllButton.Text = "Remove All ";
            this.RemoveAllButton.Click += new System.EventHandler(this.RemoveAllButton_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(18, 22);
            this.toolStripLabel1.Text = "W";
            // 
            // W
            // 
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(50, 25);
            this.W.Text = "100";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(16, 22);
            this.toolStripLabel3.Text = "H";
            // 
            // H
            // 
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(50, 25);
            this.H.Text = "100";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(46, 22);
            this.toolStripLabel2.Text = "Anchor";
            // 
            // config
            // 
            this.config.Name = "config";
            this.config.Size = new System.Drawing.Size(100, 25);
            // 
            // cropBtn
            // 
            this.cropBtn.Enabled = false;
            this.cropBtn.Image = ((System.Drawing.Image)(resources.GetObject("cropBtn.Image")));
            this.cropBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cropBtn.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.cropBtn.Name = "cropBtn";
            this.cropBtn.Size = new System.Drawing.Size(70, 22);
            this.cropBtn.Text = "Crop All";
            this.cropBtn.Click += new System.EventHandler(this.CropBtn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.inputListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 403);
            this.splitContainer1.SplitterDistance = 456;
            this.splitContainer1.TabIndex = 2;
            // 
            // inputListBox
            // 
            this.inputListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputListBox.FormattingEnabled = true;
            this.inputListBox.Location = new System.Drawing.Point(0, 0);
            this.inputListBox.Margin = new System.Windows.Forms.Padding(0);
            this.inputListBox.Name = "inputListBox";
            this.inputListBox.Size = new System.Drawing.Size(456, 403);
            this.inputListBox.TabIndex = 0;
            this.inputListBox.SelectedIndexChanged += new System.EventHandler(this.InputListBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.priview);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 403);
            this.panel1.TabIndex = 0;
            // 
            // priview
            // 
            this.priview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priview.Location = new System.Drawing.Point(0, 0);
            this.priview.MinimumSize = new System.Drawing.Size(20, 20);
            this.priview.Name = "priview";
            this.priview.ScrollBarsEnabled = false;
            this.priview.Size = new System.Drawing.Size(336, 399);
            this.priview.TabIndex = 0;
            // 
            // addFileDialog
            // 
            this.addFileDialog.DefaultExt = "pdf";
            this.addFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png";
            this.addFileDialog.Multiselect = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(611, 428);
            this.trackBar1.Maximum = 500;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(162, 45);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 3;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.ForeColor = System.Drawing.Color.Blue;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(149, 22);
            this.toolStripLabel4.Text = "Created by Akshay Nikhare";
            this.toolStripLabel4.Click += new System.EventHandler(this.toolStripLabel4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Bulk Image Cropping";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox inputListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton addFileButton;
        private System.Windows.Forms.OpenFileDialog addFileDialog;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.WebBrowser priview;
        private System.Windows.Forms.ToolStripButton showImageRepet;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox W;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox H;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox config;
        private System.Windows.Forms.ToolStripButton cropBtn;
        private System.Windows.Forms.ToolStripButton RemoveButton;
        private System.Windows.Forms.ToolStripButton RemoveAllButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
    }
}

