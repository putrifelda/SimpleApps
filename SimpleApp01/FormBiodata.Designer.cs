
namespace SimpleApp01
{
    partial class FormBiodata
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
            this.maskNpm = new System.Windows.Forms.MaskedTextBox();
            this.txtNPM = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.rdbLaki = new System.Windows.Forms.RadioButton();
            this.rdbPerempuan = new System.Windows.Forms.RadioButton();
            this.TglLahir = new System.Windows.Forms.Label();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.txtFakultas = new System.Windows.Forms.Label();
            this.cmbFakultas = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProdi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numSemester = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbMatkul1 = new System.Windows.Forms.CheckBox();
            this.ckbMatkul2 = new System.Windows.Forms.CheckBox();
            this.ckbMatkul3 = new System.Windows.Forms.CheckBox();
            this.ckbMatkul4 = new System.Windows.Forms.CheckBox();
            this.ckbMatkul5 = new System.Windows.Forms.CheckBox();
            this.ckbMatkul6 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSemester)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM BIODATA MAHASISWA";
            // 
            // maskNpm
            // 
            this.maskNpm.Location = new System.Drawing.Point(137, 35);
            this.maskNpm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskNpm.Mask = "00.00.0000";
            this.maskNpm.Name = "maskNpm";
            this.maskNpm.Size = new System.Drawing.Size(110, 23);
            this.maskNpm.TabIndex = 1;
            // 
            // txtNPM
            // 
            this.txtNPM.AutoSize = true;
            this.txtNPM.Location = new System.Drawing.Point(10, 38);
            this.txtNPM.Name = "txtNPM";
            this.txtNPM.Size = new System.Drawing.Size(34, 15);
            this.txtNPM.TabIndex = 2;
            this.txtNPM.Text = "NPM";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(10, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(39, 15);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "Nama";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(137, 67);
            this.txtNama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(196, 23);
            this.txtNama.TabIndex = 4;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(10, 108);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(78, 15);
            this.label.TabIndex = 5;
            this.label.Text = "Jenis Kelamin";
            // 
            // rdbLaki
            // 
            this.rdbLaki.AutoSize = true;
            this.rdbLaki.Checked = true;
            this.rdbLaki.Location = new System.Drawing.Point(137, 104);
            this.rdbLaki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbLaki.Name = "rdbLaki";
            this.rdbLaki.Size = new System.Drawing.Size(72, 19);
            this.rdbLaki.TabIndex = 6;
            this.rdbLaki.TabStop = true;
            this.rdbLaki.Text = "Laki-Laki";
            this.rdbLaki.UseVisualStyleBackColor = true;
            // 
            // rdbPerempuan
            // 
            this.rdbPerempuan.AutoSize = true;
            this.rdbPerempuan.Location = new System.Drawing.Point(238, 104);
            this.rdbPerempuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbPerempuan.Name = "rdbPerempuan";
            this.rdbPerempuan.Size = new System.Drawing.Size(86, 19);
            this.rdbPerempuan.TabIndex = 7;
            this.rdbPerempuan.TabStop = true;
            this.rdbPerempuan.Text = "Perempuan";
            this.rdbPerempuan.UseVisualStyleBackColor = true;
            // 
            // TglLahir
            // 
            this.TglLahir.AutoSize = true;
            this.TglLahir.Location = new System.Drawing.Point(10, 141);
            this.TglLahir.Name = "TglLahir";
            this.TglLahir.Size = new System.Drawing.Size(77, 15);
            this.TglLahir.TabIndex = 8;
            this.TglLahir.Text = "Tanggal Lahir";
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTanggalLahir.Location = new System.Drawing.Point(137, 135);
            this.dtpTanggalLahir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTanggalLahir.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpTanggalLahir.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(110, 23);
            this.dtpTanggalLahir.TabIndex = 9;
            // 
            // txtFakultas
            // 
            this.txtFakultas.AutoSize = true;
            this.txtFakultas.Location = new System.Drawing.Point(13, 175);
            this.txtFakultas.Name = "txtFakultas";
            this.txtFakultas.Size = new System.Drawing.Size(50, 15);
            this.txtFakultas.TabIndex = 10;
            this.txtFakultas.Text = "Fakultas";
            // 
            // cmbFakultas
            // 
            this.cmbFakultas.FormattingEnabled = true;
            this.cmbFakultas.Items.AddRange(new object[] {
            "Ilmu Komputer",
            "Sains dan Teknologi",
            "Ekonomi dan Sosial"});
            this.cmbFakultas.Location = new System.Drawing.Point(137, 175);
            this.cmbFakultas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFakultas.Name = "cmbFakultas";
            this.cmbFakultas.Size = new System.Drawing.Size(196, 23);
            this.cmbFakultas.TabIndex = 11;
            this.cmbFakultas.Text = "--Pilih fakultas--";
            this.cmbFakultas.SelectedIndexChanged += new System.EventHandler(this.cmbFakultas_SelectedIndexChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(242, 476);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(82, 22);
            this.btnShow.TabIndex = 12;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Program Studi";
            // 
            // cmbProdi
            // 
            this.cmbProdi.FormattingEnabled = true;
            this.cmbProdi.Items.AddRange(new object[] {
            "Ilmu Komputer",
            "Sains dan Teknologi",
            "Ekonomi dan Sosial"});
            this.cmbProdi.Location = new System.Drawing.Point(137, 215);
            this.cmbProdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProdi.Name = "cmbProdi";
            this.cmbProdi.Size = new System.Drawing.Size(196, 23);
            this.cmbProdi.TabIndex = 14;
            this.cmbProdi.Text = "--Pilih Program Studi--";
            this.cmbProdi.SelectedIndexChanged += new System.EventHandler(this.cmbProdi_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Semester";
            // 
            // numSemester
            // 
            this.numSemester.Location = new System.Drawing.Point(137, 253);
            this.numSemester.Name = "numSemester";
            this.numSemester.Size = new System.Drawing.Size(39, 23);
            this.numSemester.TabIndex = 16;
            this.numSemester.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Favorite Mata Kuliah";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ckbMatkul1
            // 
            this.ckbMatkul1.AutoSize = true;
            this.ckbMatkul1.Location = new System.Drawing.Point(62, 332);
            this.ckbMatkul1.Name = "ckbMatkul1";
            this.ckbMatkul1.Size = new System.Drawing.Size(102, 19);
            this.ckbMatkul1.TabIndex = 18;
            this.ckbMatkul1.Text = "Pemrograman";
            this.ckbMatkul1.UseVisualStyleBackColor = true;
            this.ckbMatkul1.CheckedChanged += new System.EventHandler(this.ckbMatkul1_CheckedChanged);
            // 
            // ckbMatkul2
            // 
            this.ckbMatkul2.AutoSize = true;
            this.ckbMatkul2.Location = new System.Drawing.Point(62, 357);
            this.ckbMatkul2.Name = "ckbMatkul2";
            this.ckbMatkul2.Size = new System.Drawing.Size(126, 19);
            this.ckbMatkul2.TabIndex = 19;
            this.ckbMatkul2.Text = "Hardware Software";
            this.ckbMatkul2.UseVisualStyleBackColor = true;
            // 
            // ckbMatkul3
            // 
            this.ckbMatkul3.AutoSize = true;
            this.ckbMatkul3.Location = new System.Drawing.Point(62, 382);
            this.ckbMatkul3.Name = "ckbMatkul3";
            this.ckbMatkul3.Size = new System.Drawing.Size(70, 19);
            this.ckbMatkul3.TabIndex = 20;
            this.ckbMatkul3.Text = "Jaringan";
            this.ckbMatkul3.UseVisualStyleBackColor = true;
            // 
            // ckbMatkul4
            // 
            this.ckbMatkul4.AutoSize = true;
            this.ckbMatkul4.Location = new System.Drawing.Point(194, 332);
            this.ckbMatkul4.Name = "ckbMatkul4";
            this.ckbMatkul4.Size = new System.Drawing.Size(87, 19);
            this.ckbMatkul4.TabIndex = 23;
            this.ckbMatkul4.Text = "Multimedia";
            this.ckbMatkul4.UseVisualStyleBackColor = true;
            // 
            // ckbMatkul5
            // 
            this.ckbMatkul5.AutoSize = true;
            this.ckbMatkul5.Location = new System.Drawing.Point(194, 357);
            this.ckbMatkul5.Name = "ckbMatkul5";
            this.ckbMatkul5.Size = new System.Drawing.Size(79, 19);
            this.ckbMatkul5.TabIndex = 24;
            this.ckbMatkul5.Text = "Basis Data";
            this.ckbMatkul5.UseVisualStyleBackColor = true;
            // 
            // ckbMatkul6
            // 
            this.ckbMatkul6.AutoSize = true;
            this.ckbMatkul6.Location = new System.Drawing.Point(194, 382);
            this.ckbMatkul6.Name = "ckbMatkul6";
            this.ckbMatkul6.Size = new System.Drawing.Size(108, 19);
            this.ckbMatkul6.TabIndex = 25;
            this.ckbMatkul6.Text = "Mikrokontroller";
            this.ckbMatkul6.UseVisualStyleBackColor = true;
            this.ckbMatkul6.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // FormBiodata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 508);
            this.Controls.Add(this.ckbMatkul6);
            this.Controls.Add(this.ckbMatkul5);
            this.Controls.Add(this.ckbMatkul4);
            this.Controls.Add(this.ckbMatkul3);
            this.Controls.Add(this.ckbMatkul2);
            this.Controls.Add(this.ckbMatkul1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numSemester);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.cmbFakultas);
            this.Controls.Add(this.txtFakultas);
            this.Controls.Add(this.dtpTanggalLahir);
            this.Controls.Add(this.TglLahir);
            this.Controls.Add(this.rdbPerempuan);
            this.Controls.Add(this.rdbLaki);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNPM);
            this.Controls.Add(this.maskNpm);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormBiodata";
            this.Text = "FormBiodata";
            this.Load += new System.EventHandler(this.FormBiodata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSemester)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskNpm;
        private System.Windows.Forms.Label txtNPM;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.RadioButton rdbLaki;
        private System.Windows.Forms.RadioButton rdbPerempuan;
        private System.Windows.Forms.Label TglLahir;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
        private System.Windows.Forms.Label txtFakultas;
        private System.Windows.Forms.ComboBox cmbFakultas;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numSemester;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbMatkul1;
        private System.Windows.Forms.CheckBox ckbMatkul2;
        private System.Windows.Forms.CheckBox ckbMatkul3;
        private System.Windows.Forms.CheckBox ckbMatkul4;
        private System.Windows.Forms.CheckBox ckbMatkul5;
        private System.Windows.Forms.CheckBox ckbMatkul6;
    }
}