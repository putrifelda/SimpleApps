using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleApp01
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="felda" && txtPassword.Text == "amikom")
            {
                this.Hide();
                FormHome2 form = new FormHome2();
                form.Show();
            }else
            {
                MessageBox.Show("Maaf username/password salah !");
                txtUsername.Text = "Username";
                txtPassword.Text = "Password";
                txtUsername.Focus();
            }
        }
    }
}
