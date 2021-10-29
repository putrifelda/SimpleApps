using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleApp01
{
    public partial class FormKalkulator : Form
    {
        public FormKalkulator()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            float num1 = Convert.ToSingle(txtNilai1.Text);
            float num2 = Convert.ToSingle(txtNilai2.Text);
            txtHasil.Text = (num1 + num2).ToString();
        }

    private void btnSubtract_Click(object sender, EventArgs e)
        {
            float num1 = Convert.ToSingle(txtNilai1.Text);
            float num2 = Convert.ToSingle(txtNilai2.Text);
            txtHasil.Text = (num1 - num2).ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            float num1 = Convert.ToSingle(txtNilai1.Text);
            float num2 = Convert.ToSingle(txtNilai2.Text);
            txtHasil.Text = (num1 * num2).ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            float num1 = Convert.ToSingle(txtNilai1.Text);
            float num2 = Convert.ToSingle(txtNilai2.Text);
            txtHasil.Text = (num1 / num2).ToString();
        }
    }
}
