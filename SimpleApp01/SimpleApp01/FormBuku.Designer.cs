
namespace SimpleApp01
{
    partial class FormBuku
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
            this.cbPCSharp = new System.Windows.Forms.CheckBox();
            this.cbPJav = new System.Windows.Forms.CheckBox();
            this.cbSql = new System.Windows.Forms.CheckBox();
            this.cbSeo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbFullPayment = new System.Windows.Forms.RadioButton();
            this.rdbInstallments = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBeli = new System.Windows.Forms.Button();
            this.btnkKeluar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbPCSharp
            // 
            this.cbPCSharp.AutoSize = true;
            this.cbPCSharp.Location = new System.Drawing.Point(32, 58);
            this.cbPCSharp.Name = "cbPCSharp";
            this.cbPCSharp.Size = new System.Drawing.Size(107, 19);
            this.cbPCSharp.TabIndex = 0;
            this.cbPCSharp.Text = "Programing C#";
            this.cbPCSharp.UseVisualStyleBackColor = true;
            // 
            // cbPJav
            // 
            this.cbPJav.AutoSize = true;
            this.cbPJav.Location = new System.Drawing.Point(32, 81);
            this.cbPJav.Name = "cbPJav";
            this.cbPJav.Size = new System.Drawing.Size(144, 19);
            this.cbPJav.TabIndex = 1;
            this.cbPJav.Text = "Basic Programing Java";
            this.cbPJav.UseVisualStyleBackColor = true;
            // 
            // cbSql
            // 
            this.cbSql.AutoSize = true;
            this.cbSql.Location = new System.Drawing.Point(32, 106);
            this.cbSql.Name = "cbSql";
            this.cbSql.Size = new System.Drawing.Size(160, 19);
            this.cbSql.TabIndex = 2;
            this.cbSql.Text = "SQL Server for Store Apps";
            this.cbSql.UseVisualStyleBackColor = true;
            // 
            // cbSeo
            // 
            this.cbSeo.AutoSize = true;
            this.cbSeo.Location = new System.Drawing.Point(32, 131);
            this.cbSeo.Name = "cbSeo";
            this.cbSeo.Size = new System.Drawing.Size(120, 19);
            this.cbSeo.TabIndex = 3;
            this.cbSeo.Text = "SEO E-Commerce";
            this.cbSeo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Available Books";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "select the books you wish to purchase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mode Payment";
            // 
            // rdbFullPayment
            // 
            this.rdbFullPayment.AutoSize = true;
            this.rdbFullPayment.Location = new System.Drawing.Point(295, 58);
            this.rdbFullPayment.Name = "rdbFullPayment";
            this.rdbFullPayment.Size = new System.Drawing.Size(94, 19);
            this.rdbFullPayment.TabIndex = 7;
            this.rdbFullPayment.TabStop = true;
            this.rdbFullPayment.Text = "Full Payment";
            this.rdbFullPayment.UseVisualStyleBackColor = true;
            // 
            // rdbInstallments
            // 
            this.rdbInstallments.AutoSize = true;
            this.rdbInstallments.Location = new System.Drawing.Point(295, 83);
            this.rdbInstallments.Name = "rdbInstallments";
            this.rdbInstallments.Size = new System.Drawing.Size(89, 19);
            this.rdbInstallments.TabIndex = 8;
            this.rdbInstallments.TabStop = true;
            this.rdbInstallments.Text = "Installments";
            this.rdbInstallments.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "select the mode of payment";
            // 
            // btnBeli
            // 
            this.btnBeli.Location = new System.Drawing.Point(282, 153);
            this.btnBeli.Name = "btnBeli";
            this.btnBeli.Size = new System.Drawing.Size(213, 40);
            this.btnBeli.TabIndex = 10;
            this.btnBeli.Text = "Purchase";
            this.btnBeli.UseVisualStyleBackColor = true;
            // 
            // btnkKeluar
            // 
            this.btnkKeluar.Location = new System.Drawing.Point(396, 398);
            this.btnkKeluar.Name = "btnkKeluar";
            this.btnkKeluar.Size = new System.Drawing.Size(99, 40);
            this.btnkKeluar.TabIndex = 11;
            this.btnkKeluar.Text = "Exit";
            this.btnkKeluar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Your Comments";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 235);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 23);
            this.textBox1.TabIndex = 13;
            // 
            // FormBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnkKeluar);
            this.Controls.Add(this.btnBeli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdbInstallments);
            this.Controls.Add(this.rdbFullPayment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSeo);
            this.Controls.Add(this.cbSql);
            this.Controls.Add(this.cbPJav);
            this.Controls.Add(this.cbPCSharp);
            this.Name = "FormBuku";
            this.Text = "FormBuku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbPCSharp;
        private System.Windows.Forms.CheckBox cbPJav;
        private System.Windows.Forms.CheckBox cbSql;
        private System.Windows.Forms.CheckBox cbSeo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbFullPayment;
        private System.Windows.Forms.RadioButton rdbInstallments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBeli;
        private System.Windows.Forms.Button btnkKeluar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}