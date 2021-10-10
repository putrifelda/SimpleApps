
namespace SimpleApp01
{
    partial class FormKonversiSuhu
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdbCtF = new System.Windows.Forms.RadioButton();
            this.rdbFtC = new System.Windows.Forms.RadioButton();
            this.rdbCtK = new System.Windows.Forms.RadioButton();
            this.rdbKtC = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProses = new System.Windows.Forms.Button();
            this.hasilSuhu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convert";
            // 
            // rdbCtF
            // 
            this.rdbCtF.AutoSize = true;
            this.rdbCtF.Checked = true;
            this.rdbCtF.Location = new System.Drawing.Point(38, 54);
            this.rdbCtF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbCtF.Name = "rdbCtF";
            this.rdbCtF.Size = new System.Drawing.Size(137, 19);
            this.rdbCtF.TabIndex = 8;
            this.rdbCtF.TabStop = true;
            this.rdbCtF.Text = "Celcius ke Fahrenheit";
            this.rdbCtF.UseVisualStyleBackColor = true;
            // 
            // rdbFtC
            // 
            this.rdbFtC.AutoSize = true;
            this.rdbFtC.Location = new System.Drawing.Point(38, 76);
            this.rdbFtC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbFtC.Name = "rdbFtC";
            this.rdbFtC.Size = new System.Drawing.Size(137, 19);
            this.rdbFtC.TabIndex = 9;
            this.rdbFtC.Text = "Fahrenheit ke Celcius";
            this.rdbFtC.UseVisualStyleBackColor = true;
            // 
            // rdbCtK
            // 
            this.rdbCtK.AutoSize = true;
            this.rdbCtK.Location = new System.Drawing.Point(38, 99);
            this.rdbCtK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbCtK.Name = "rdbCtK";
            this.rdbCtK.Size = new System.Drawing.Size(113, 19);
            this.rdbCtK.TabIndex = 10;
            this.rdbCtK.Text = "Celcius ke Kelvin";
            this.rdbCtK.UseVisualStyleBackColor = true;
            // 
            // rdbKtC
            // 
            this.rdbKtC.AutoSize = true;
            this.rdbKtC.Location = new System.Drawing.Point(38, 122);
            this.rdbKtC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbKtC.Name = "rdbKtC";
            this.rdbKtC.Size = new System.Drawing.Size(113, 19);
            this.rdbKtC.TabIndex = 11;
            this.rdbKtC.Text = "Kelvin ke Celcius";
            this.rdbKtC.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Konversi Suhu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Suhu";
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(216, 187);
            this.btnProses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(82, 22);
            this.btnProses.TabIndex = 15;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // hasilSuhu
            // 
            this.hasilSuhu.Location = new System.Drawing.Point(68, 222);
            this.hasilSuhu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hasilSuhu.Name = "hasilSuhu";
            this.hasilSuhu.Size = new System.Drawing.Size(110, 23);
            this.hasilSuhu.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Hasil";
            // 
            // numInput
            // 
            this.numInput.Location = new System.Drawing.Point(68, 188);
            this.numInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numInput.Name = "numInput";
            this.numInput.Size = new System.Drawing.Size(131, 23);
            this.numInput.TabIndex = 18;
            this.numInput.ValueChanged += new System.EventHandler(this.numInput_ValueChanged);
            // 
            // FormKonversiSuhu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 305);
            this.Controls.Add(this.numInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hasilSuhu);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbKtC);
            this.Controls.Add(this.rdbCtK);
            this.Controls.Add(this.rdbFtC);
            this.Controls.Add(this.rdbCtF);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormKonversiSuhu";
            this.Text = "FormKonversiSuhu";
            ((System.ComponentModel.ISupportInitialize)(this.numInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbCtF;
        private System.Windows.Forms.RadioButton rdbFtC;
        private System.Windows.Forms.RadioButton rdbCtK;
        private System.Windows.Forms.RadioButton rdbKtC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.TextBox hasilSuhu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numInput;
    }
}