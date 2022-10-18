using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorDivisas1_Adrian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbPesetas_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbPesetas.Text)){
                double pesetas = Convert.ToDouble((tbPesetas.Text));
                pesetas = pesetas / 166.386;
                lbResultadoEuro.Text = pesetas.ToString();
            }

            if (!string.IsNullOrEmpty(tbPesetas.Text))
            {
                lbResultadoPeseta.Text = tbPesetas.Text;
            }

        }
    }
}
