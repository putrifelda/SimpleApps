using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleApp01
{
    public partial class FormBuku : Form
    {
        public FormBuku()
        {
            InitializeComponent();
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            int cb1 = 65300;
            int cb2 = 42750;
            int cb3 = 50000;
            int cb4 = 85225;
            int hasilbayar = 0;

            if (cbPCSharp.Checked == true)
            {
                hasilbayar = hasilbayar + cb1;
            }
            if (cbPJav.Checked == true)
            {
                hasilbayar = hasilbayar + cb2;
            }
            if (cbSql.Checked == true)
            {
                hasilbayar = hasilbayar + cb3;
            }
            if (cbSeo.Checked == true)
            {
                hasilbayar = hasilbayar + cb4;
            }

            String bayar, komen;
            if(rdbFullPayment.Checked)
            {
                bayar = rdbFullPayment.Text;
                komen = "Very few books are available";
            }
            else
            {
                bayar = rdbInstallments.Text;
                komen = "More books please...";
            }

            txtboxHasil.Text = komen;

            MessageBox.Show("You Purchased :" +
                Buku() + "\n" +

                "The total payment due is Rp." + hasilbayar + "\n" +
                "The select mode of payment is : " + bayar + "\n" +
                "You comments about us are : " + komen);
        }

     
        private void btnkKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        void bayar()
        {
            btnBeli.Enabled = true;
            rdbFullPayment.Enabled = true;
            rdbInstallments.Enabled = true;                     
        }

        private void cbPCSharp_CheckedChanged(object sender, EventArgs e)
        {
            bayar();
        }

        private void cbPJav_CheckedChanged(object sender, EventArgs e)
        {
            bayar();
        }

        private void cbSql_CheckedChanged(object sender, EventArgs e)
        {
            bayar();
        }

        private void cbSeo_CheckedChanged(object sender, EventArgs e)
        {
            bayar();
        }

        String Buku()
        {
            String buku = " ";
            if (cbPCSharp.Checked)
            {
                buku = buku + "\n" + "              " + cbPCSharp.Text;
            }
            if (cbPJav.Checked)
            {
                buku = buku + "\n" + "              " + cbPJav.Text;
            }
            if (cbSql.Checked)
            {
                buku = buku + "\n" + "              " + cbSql.Text;
            }
            if (cbSeo.Checked)
            {
                buku = buku + "\n" + "              " + cbSeo.Text;
            }
            return buku;
        }

    }
}
