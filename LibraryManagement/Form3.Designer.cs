namespace LibraryManagement
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bOOKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWBOOKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEMBERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDMEMBERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWMEMBERINFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iSSUEBOOKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rETURNBOOKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOOKDETAILSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PowderBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bOOKSToolStripMenuItem,
            this.mEMBERSToolStripMenuItem,
            this.iSSUEBOOKSToolStripMenuItem,
            this.rETURNBOOKSToolStripMenuItem,
            this.bOOKDETAILSToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1072, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // bOOKSToolStripMenuItem
            // 
            this.bOOKSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDToolStripMenuItem,
            this.vIEWBOOKSToolStripMenuItem});
            this.bOOKSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bOOKSToolStripMenuItem.Image")));
            this.bOOKSToolStripMenuItem.Name = "bOOKSToolStripMenuItem";
            this.bOOKSToolStripMenuItem.Size = new System.Drawing.Size(113, 54);
            this.bOOKSToolStripMenuItem.Text = "Books";
            this.bOOKSToolStripMenuItem.Click += new System.EventHandler(this.bOOKSToolStripMenuItem_Click);
            // 
            // aDDToolStripMenuItem
            // 
            this.aDDToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.aDDToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aDDToolStripMenuItem.Image")));
            this.aDDToolStripMenuItem.Name = "aDDToolStripMenuItem";
            this.aDDToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.aDDToolStripMenuItem.Text = "Add Books";
            this.aDDToolStripMenuItem.Click += new System.EventHandler(this.aDDToolStripMenuItem_Click);
            // 
            // vIEWBOOKSToolStripMenuItem
            // 
            this.vIEWBOOKSToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.vIEWBOOKSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vIEWBOOKSToolStripMenuItem.Image")));
            this.vIEWBOOKSToolStripMenuItem.Name = "vIEWBOOKSToolStripMenuItem";
            this.vIEWBOOKSToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.vIEWBOOKSToolStripMenuItem.Text = "View and Edit Add books";
            this.vIEWBOOKSToolStripMenuItem.Click += new System.EventHandler(this.vIEWBOOKSToolStripMenuItem_Click);
            // 
            // mEMBERSToolStripMenuItem
            // 
            this.mEMBERSToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.mEMBERSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDMEMBERSToolStripMenuItem,
            this.vIEWMEMBERINFOToolStripMenuItem});
            this.mEMBERSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mEMBERSToolStripMenuItem.Image")));
            this.mEMBERSToolStripMenuItem.Name = "mEMBERSToolStripMenuItem";
            this.mEMBERSToolStripMenuItem.Size = new System.Drawing.Size(135, 54);
            this.mEMBERSToolStripMenuItem.Text = "Members";
            // 
            // aDDMEMBERSToolStripMenuItem
            // 
            this.aDDMEMBERSToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.aDDMEMBERSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aDDMEMBERSToolStripMenuItem.Image")));
            this.aDDMEMBERSToolStripMenuItem.Name = "aDDMEMBERSToolStripMenuItem";
            this.aDDMEMBERSToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.aDDMEMBERSToolStripMenuItem.Text = "Add Members";
            this.aDDMEMBERSToolStripMenuItem.Click += new System.EventHandler(this.aDDMEMBERSToolStripMenuItem_Click);
            // 
            // vIEWMEMBERINFOToolStripMenuItem
            // 
            this.vIEWMEMBERINFOToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.vIEWMEMBERINFOToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vIEWMEMBERINFOToolStripMenuItem.Image")));
            this.vIEWMEMBERINFOToolStripMenuItem.Name = "vIEWMEMBERINFOToolStripMenuItem";
            this.vIEWMEMBERINFOToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.vIEWMEMBERINFOToolStripMenuItem.Text = "View and Edit Member Info";
            this.vIEWMEMBERINFOToolStripMenuItem.Click += new System.EventHandler(this.vIEWMEMBERINFOToolStripMenuItem_Click);
            // 
            // iSSUEBOOKSToolStripMenuItem
            // 
            this.iSSUEBOOKSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("iSSUEBOOKSToolStripMenuItem.Image")));
            this.iSSUEBOOKSToolStripMenuItem.Name = "iSSUEBOOKSToolStripMenuItem";
            this.iSSUEBOOKSToolStripMenuItem.Size = new System.Drawing.Size(149, 54);
            this.iSSUEBOOKSToolStripMenuItem.Text = "Issue Books";
            this.iSSUEBOOKSToolStripMenuItem.Click += new System.EventHandler(this.iSSUEBOOKSToolStripMenuItem_Click);
            // 
            // rETURNBOOKSToolStripMenuItem
            // 
            this.rETURNBOOKSToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.rETURNBOOKSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rETURNBOOKSToolStripMenuItem.Image")));
            this.rETURNBOOKSToolStripMenuItem.Name = "rETURNBOOKSToolStripMenuItem";
            this.rETURNBOOKSToolStripMenuItem.Size = new System.Drawing.Size(160, 54);
            this.rETURNBOOKSToolStripMenuItem.Text = "Return Books";
            this.rETURNBOOKSToolStripMenuItem.Click += new System.EventHandler(this.rETURNBOOKSToolStripMenuItem_Click);
            // 
            // bOOKDETAILSToolStripMenuItem
            // 
            this.bOOKDETAILSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bOOKDETAILSToolStripMenuItem.Image")));
            this.bOOKDETAILSToolStripMenuItem.Name = "bOOKDETAILSToolStripMenuItem";
            this.bOOKDETAILSToolStripMenuItem.Size = new System.Drawing.Size(179, 54);
            this.bOOKDETAILSToolStripMenuItem.Text = "All Book Details";
            this.bOOKDETAILSToolStripMenuItem.Click += new System.EventHandler(this.bOOKDETAILSToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.eXITToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eXITToolStripMenuItem.Image")));
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(97, 54);
            this.eXITToolStripMenuItem.Text = "Exit";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 633);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bOOKSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIEWBOOKSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mEMBERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDMEMBERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIEWMEMBERINFOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iSSUEBOOKSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rETURNBOOKSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOOKDETAILSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}