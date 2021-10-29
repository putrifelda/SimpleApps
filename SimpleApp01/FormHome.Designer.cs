
namespace SimpleApp01
{
    partial class FormHome
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editForm = new System.Windows.Forms.ToolStripMenuItem();
            this.formBiodataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formKasirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formKasirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.formBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.formLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editForm});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(737, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // editForm
            // 
            this.editForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formBiodataToolStripMenuItem,
            this.formKasirToolStripMenuItem,
            this.formKasirToolStripMenuItem1,
            this.formBukuToolStripMenuItem,
            this.formLoginToolStripMenuItem});
            this.editForm.Name = "editForm";
            this.editForm.Size = new System.Drawing.Size(47, 20);
            this.editForm.Text = "Form";
            // 
            // formBiodataToolStripMenuItem
            // 
            this.formBiodataToolStripMenuItem.Name = "formBiodataToolStripMenuItem";
            this.formBiodataToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.formBiodataToolStripMenuItem.Text = "Form Menampilkan Teks";
            this.formBiodataToolStripMenuItem.Click += new System.EventHandler(this.formBiodataToolStripMenuItem_Click);
            // 
            // formKasirToolStripMenuItem
            // 
            this.formKasirToolStripMenuItem.Name = "formKasirToolStripMenuItem";
            this.formKasirToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.formKasirToolStripMenuItem.Text = "Form Biodata";
            this.formKasirToolStripMenuItem.Click += new System.EventHandler(this.formKasirToolStripMenuItem_Click);
            // 
            // formKasirToolStripMenuItem1
            // 
            this.formKasirToolStripMenuItem1.Name = "formKasirToolStripMenuItem1";
            this.formKasirToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.formKasirToolStripMenuItem1.Text = "Form Kasir";
            this.formKasirToolStripMenuItem1.Click += new System.EventHandler(this.formKasirToolStripMenuItem1_Click);
            // 
            // formBukuToolStripMenuItem
            // 
            this.formBukuToolStripMenuItem.Name = "formBukuToolStripMenuItem";
            this.formBukuToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.formBukuToolStripMenuItem.Text = "Form Buku";
            this.formBukuToolStripMenuItem.Click += new System.EventHandler(this.formBukuToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 501);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(737, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // formLoginToolStripMenuItem
            // 
            this.formLoginToolStripMenuItem.Name = "formLoginToolStripMenuItem";
            this.formLoginToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.formLoginToolStripMenuItem.Text = "Form Login";
            this.formLoginToolStripMenuItem.Click += new System.EventHandler(this.formLoginToolStripMenuItem_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 523);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editForm;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem formBiodataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formKasirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formKasirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem formBukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formLoginToolStripMenuItem;
    }
}



