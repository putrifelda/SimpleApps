using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleApp01
{
    public partial class FormKasir : Form
    {
        public FormKasir()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // add data ke dlm data grid view
            int row = 0, subtotal = 0;
            dgvBarang.Rows.Add();
            row = dgvBarang.Rows.Count - 2;
            // input data ke dlm dara grid view
            dgvBarang[0, row].Value = dgvBarang.Rows.Count - 1;
            dgvBarang[1, row].Value = txtNama.Text;
            dgvBarang[2, row].Value = txtHarga.Text;
            dgvBarang[3, row].Value = txtJumlah.Text;
            subtotal = (int)(long.Parse(txtHarga.Text) * long.Parse(txtJumlah.Text));
            dgvBarang[4, row].Value = subtotal;

            //show total
            txtTotal.Text = (long.Parse(txtTotal.Text) + subtotal).ToString();

            // reset
            txtNama.Text = " ";
            txtHarga.Text = " ";
            txtJumlah.Text = " ";
            txtNama.Focus();
        }

        private void txtBayar_TextChanged(object sender, EventArgs e)
        {
            if(txtBayar.Text != "")
            {
                long kembali = long.Parse(txtBayar.Text) - long.Parse(txtTotal.Text);
                txtKembali.Text = kembali.ToString();
            }
        }
    }
}
