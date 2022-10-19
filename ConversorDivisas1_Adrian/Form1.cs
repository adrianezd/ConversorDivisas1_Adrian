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

        private void Conversor(double cantidad, string moneda)
        {
            if(moneda == "Euros")
            {
                double euros = Convert.ToDouble(cantidad);
                lbResultadoDolares.Text = (Convert.ToDouble(euros) * 0.99).ToString();
                lbResultadoPeseta.Text = (Convert.ToDouble(euros) * 166.386).ToString();
                lbResultadoPesos.Text = (Convert.ToDouble(euros) * 19.75).ToString();
            }
            if (moneda == "Dolares")
            {
                double dolares = Convert.ToDouble(cantidad);
                lbResultadoEuro.Text = (Convert.ToDouble(dolares) * 1.01).ToString();
                lbResultadoPeseta.Text = (Convert.ToDouble(dolares) * 171.122).ToString();
                lbResultadoPesos.Text = (Convert.ToDouble(dolares) * 20.03).ToString();
            }
            if (moneda == "Pesos")
            {
                double pesos = Convert.ToDouble(cantidad);
                lbResultadoDolares.Text = (Convert.ToDouble(pesos) * 0.050).ToString();
                lbResultadoEuro.Text = (Convert.ToDouble(pesos) * 0.051).ToString();
                lbResultadoPeseta.Text = (Convert.ToDouble(pesos) * 8.52632).ToString();
            }
            if (moneda == "Pesetas")
            {
                double pesetas = Convert.ToDouble(cantidad);
                lbResultadoDolares.Text = (Convert.ToDouble(pesetas) * 0.00589336).ToString();
                pesetas = pesetas / 166.386;
                lbResultadoEuro.Text = pesetas.ToString();
                lbResultadoPesos.Text = (Convert.ToDouble(lbResultadoDolares.Text) * 20.04).ToString();
            }
        }

        private void tbPesetas_TextChanged(object sender, EventArgs e)
        {
            tbEuros.Text = ""; tbDolares.Text = ""; tbPesos.Text = "";
            if (!string.IsNullOrEmpty(tbPesetas.Text)){
                if (tbPesetas.Text.All(char.IsDigit) || (!tbPesetas.Text.StartsWith(",")))
                {
                    if (tbPesetas.Text.All(char.IsDigit))
                    {
                        double valor = Convert.ToDouble(tbPesetas.Text);
                        Conversor(valor, "Pesetas");
                    }
                    else
                    {
                        tbPesetas.Text = tbPesetas.Text.Remove((tbPesetas.Text).Length - 1);
                    }
                }
                else
                {
                    tbPesetas.Text = "";
                }
            }

            if (!string.IsNullOrEmpty(tbPesetas.Text))
            {
                lbResultadoPeseta.Text = tbPesetas.Text;
            }

        }

        private void tbEuros_TextChanged_1(object sender, EventArgs e)
        {
            tbPesetas.Text = ""; tbDolares.Text = ""; tbPesos.Text = "";
            if (!string.IsNullOrEmpty(tbEuros.Text))
            {
                if (tbEuros.Text.All(char.IsDigit) || (!tbEuros.Text.StartsWith(",")))
                {
                    if (tbEuros.Text.All(char.IsDigit))
                    {
                        double valor = Convert.ToDouble(tbEuros.Text);
                        Conversor(valor, "Euros");
                    }
                    else
                    {
                        tbEuros.Text = tbEuros.Text.Remove((tbEuros.Text).Length - 1);
                    }
                }
                else
                {
                    tbEuros.Text = tbEuros.Text.Remove((tbEuros.Text).Length - 1);
                }
            }

            if (!string.IsNullOrEmpty(tbEuros.Text))
            {
                lbResultadoEuro.Text = tbEuros.Text;
            }

        }

        private void tbDolares_TextChanged_1(object sender, EventArgs e)
        {
            tbEuros.Text = ""; tbPesetas.Text = ""; tbPesos.Text = "";
            if (!string.IsNullOrEmpty(tbDolares.Text))
            {
                if (tbDolares.Text.All(char.IsDigit))
                {
                    double valor = Convert.ToDouble(tbDolares.Text);
                    Conversor(valor, "Dolares");
                }
                else
                {
                    tbDolares.Text = tbDolares.Text.Remove((tbDolares.Text).Length - 1);
                }
            }
            if (!string.IsNullOrEmpty(tbDolares.Text))
            {
                lbResultadoDolares.Text = tbDolares.Text;
            }

        }

        private void tbPesos_TextChanged_1(object sender, EventArgs e)
        {
            tbEuros.Text = ""; tbDolares.Text = ""; tbPesetas.Text = "";
            if (!string.IsNullOrEmpty(tbPesos.Text))
            {
                if (tbPesos.Text.All(char.IsDigit) || (!tbPesos.Text.StartsWith(",")))
                {
                    if (tbPesos.Text.All(char.IsDigit))
                    {
                        double valor = Convert.ToDouble(tbPesos.Text);
                        Conversor(valor, "Pesos");
                    }
                    else
                    {
                        tbPesos.Text = tbPesos.Text.Remove((tbPesos.Text).Length - 1);
                    }
                }
                else
                {
                    tbPesos.Text = tbPesos.Text.Remove((tbPesos.Text).Length - 1);
                }
            }

            if (!string.IsNullOrEmpty(tbPesos.Text))
            {
                lbResultadoPesos.Text = tbPesos.Text;
            }

        }
    }
}
