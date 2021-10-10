using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleApp01
{
    public partial class FormBiodata : Form
    {
        public FormBiodata()
        {
            InitializeComponent();
        }

        void AddProdi()
        {
            cmbProdi.Items.Clear();
            if (cmbFakultas.SelectedItem.ToString() == "Ilmu Komputer")
            {
                cmbProdi.Items.Add("D3 Teknik Informatika");
                cmbProdi.Items.Add("D3 Manajemen Informatika");
                cmbProdi.Items.Add("S1 Teknik Komputer");
                cmbProdi.Items.Add("S1 Informatika");
                cmbProdi.Items.Add("S1 Teknologi Informasi");
                cmbProdi.Items.Add("S1 Sistem Informasi");
            }
            else if(cmbFakultas.SelectedItem.ToString() == "Ekomomi dan Sosial")
            {
                cmbProdi.Items.Add("S1 Akuntansi");
                cmbProdi.Items.Add("S1 Ekonomi");
                cmbProdi.Items.Add("S1 Hubungan Internasional");
            }
            else if(cmbFakultas.SelectedItem.ToString() == "Sains dan Teknologi")
            {
                cmbProdi.Items.Add("S1 Arsitektur");
                cmbProdi.Items.Add("S1 Geografi");
            }
            else
            {
                cmbProdi.Items.Add("");
            }
        }
        //function data matkul favorite
        string favorit()
        {
            string matkul = " ";
            if (ckbMatkul1.Checked)
            {
                matkul = matkul + " " + ckbMatkul1.Text;
            }
            if (ckbMatkul2.Checked)
            {
                matkul = matkul + " " + ckbMatkul2.Text;
            }
            if (ckbMatkul3.Checked)
            {
                matkul = matkul + " " + ckbMatkul3.Text;
            }
            if (ckbMatkul4.Checked)
            {
                matkul = matkul + " " + ckbMatkul4.Text;
            }
            if (ckbMatkul5.Checked)
            {
                matkul = matkul + " " + ckbMatkul5.Text;
            }
            if (ckbMatkul6.Checked)
            {
                matkul = matkul + " " + ckbMatkul6.Text;
            }
            return matkul;

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            String jk = " ";
            if (rdbLaki.Checked)
            {
                jk = rdbLaki.Text;
            }
            else 
            {
                jk = rdbPerempuan.Text;
            }

            MessageBox.Show("NPM  : " + maskNpm.Text + "\n" +
                            "Nama : " + txtNama.Text + "\n" +
                            "Jenis Kelamin : " + jk + "\n" +
                            "Tanggal lahir : " + dtpTanggalLahir.Value + " \n" +
                            "Fakultas : " + cmbFakultas.SelectedItem.ToString() + "\n" +
                            "program Studi : " + cmbProdi.SelectedItem.ToString() + "\n" +
                            "Semester : " + numSemester.Value + "\n" +
                            "Mata Kuliah Favorit : " + favorit());

        }

        //fungction untuk add data cmd
        private void cmbFakultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddProdi();
        }

        private void cmbProdi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormBiodata_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ckbMatkul1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
