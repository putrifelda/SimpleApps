
namespace SimpleApp01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTeks = new System.Windows.Forms.Label();
            this.txtTeks = new System.Windows.Forms.TextBox();
            this.btnTampil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTeks
            // 
            this.lblTeks.AutoSize = true;
            this.lblTeks.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTeks.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTeks.Location = new System.Drawing.Point(34, 61);
            this.lblTeks.Name = "lblTeks";
            this.lblTeks.Size = new System.Drawing.Size(50, 23);
            this.lblTeks.TabIndex = 0;
            this.lblTeks.Text = "Teks";
            this.lblTeks.Click += new System.EventHandler(this.lblTeks_Click);
            // 
            // txtTeks
            // 
            this.txtTeks.Location = new System.Drawing.Point(90, 61);
            this.txtTeks.Multiline = true;
            this.txtTeks.Name = "txtTeks";
            this.txtTeks.Size = new System.Drawing.Size(258, 24);
            this.txtTeks.TabIndex = 1;
            this.txtTeks.TextChanged += new System.EventHandler(this.txtTeks_TextChanged);
            // 
            // btnTampil
            // 
            this.btnTampil.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTampil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTampil.ForeColor = System.Drawing.SystemColors.Info;
            this.btnTampil.Location = new System.Drawing.Point(254, 103);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(94, 29);
            this.btnTampil.TabIndex = 2;
            this.btnTampil.Text = "Show";
            this.btnTampil.UseVisualStyleBackColor = false;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 188);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.txtTeks);
            this.Controls.Add(this.lblTeks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeks;
        private System.Windows.Forms.TextBox txtTeks;
        private System.Windows.Forms.Button btnTampil;
    }
}

