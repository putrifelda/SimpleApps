using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleApp01
{
    public partial class FormKonversiSuhu : Form
    {
        public FormKonversiSuhu()
        {
            InitializeComponent();
        }

        double CalculateSuhu(int input)
        {
            if (rdbCtF.Checked)
            {
                return input * 1.8 + 32;
            }
            if (rdbFtC.Checked)
            {
                return (input - 32) / 1.8;
            }
            if (rdbCtK.Checked)
            {
                return input + 273.15;
            }
            if (rdbKtC.Checked)
            {
                return input - 273.15;
            }
            return input;
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            int input = (int)numInput.Value;
            double hasilproses = CalculateSuhu(input);

            hasilSuhu.Text = hasilproses.ToString();
        }

        private void numInput_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
