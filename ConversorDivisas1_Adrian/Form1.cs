﻿using System;
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
        bool bdolares;
        bool bPesetas;
        bool bPesos;
        bool bEuros;
        public Form1()
        {
            InitializeComponent();
            bool bdolares=false;
            bool bPesetas = false;
            bool bPesos = false;
            bool bEuros = false;
        }

        private void Conversor(double cantidad, string moneda)
        {
            if (moneda == "Euros")
            {
                double euros = Convert.ToDouble(cantidad);
                tbDolares.Text = (Convert.ToDouble(euros) * 0.99).ToString();
                tbPesetas.Text = (Convert.ToDouble(euros) * 166.386).ToString();
                tbPesos.Text = (Convert.ToDouble(euros) * 19.75).ToString();
            }
            if (moneda == "Dolares")
            {
                double dolares = Convert.ToDouble(cantidad);
                tbEuros.Text = (Convert.ToDouble(dolares) * 1.01).ToString();
                tbPesetas.Text = (Convert.ToDouble(dolares) * 171.122).ToString();
                tbPesos.Text = (Convert.ToDouble(dolares) * 20.03).ToString();
            }
            if (moneda == "Pesos")
            {
                double pesos = Convert.ToDouble(cantidad);
                tbDolares.Text = (Convert.ToDouble(pesos) * 0.050).ToString();
                tbEuros.Text = (Convert.ToDouble(pesos) * 0.051).ToString();
                tbPesetas.Text = (Convert.ToDouble(pesos) * 8.52632).ToString();
            }
            if (moneda == "Pesetas")
            {
                double pesetas = Convert.ToDouble(cantidad);
                tbDolares.Text = (Convert.ToDouble(pesetas) * 0.00589336).ToString();
                pesetas = pesetas / 166.386;
                tbEuros.Text = pesetas.ToString();
                tbPesos.Text = (Convert.ToDouble(tbDolares.Text) * 20.04).ToString();
            }
        }

        private void tbPesetas_TextChanged(object sender, EventArgs e)
        {
            if (bPesetas == true)
            {
                if (!string.IsNullOrEmpty(tbPesetas.Text))
                {
                    if (tbPesetas.Text.All(char.IsDigit) || (!tbPesetas.Text.StartsWith(",")))
                    {
                        if (tbPesetas.Text.All(char.IsDigit))
                        {
                            double valor = Convert.ToDouble(tbPesetas.Text);
                            Conversor(valor, "Pesetas");
                        }
                    }
                    else
                    {
                        tbPesetas.Text = tbPesetas.Text.Remove(tbPesetas.Text.Length - 1, 1);
                    }
                }
            }
        }

        private void tbEuros_TextChanged_1(object sender, EventArgs e)
        {
            if (bEuros == true)
            {
                if (!string.IsNullOrEmpty(tbEuros.Text))
            {
                    if (tbEuros.Text.All(char.IsDigit) || (!tbEuros.Text.StartsWith(",")))
                    {
                        double valor = Convert.ToDouble(tbEuros.Text);
                        Conversor(valor, "Euros");

                    }
                    else
                    {
                        tbEuros.Text = tbEuros.Text.Remove(tbEuros.Text.Length - 1, 1);
                    }
                }
            }
        }

        private void tbDolares_TextChanged_1(object sender, EventArgs e)
        {
            if (bdolares == true)
            {
                if (!string.IsNullOrEmpty(tbDolares.Text))
                {
                    if (tbDolares.Text.All(char.IsDigit) || (!tbDolares.Text.StartsWith(",")))
                    {
                        double valor = Convert.ToDouble(tbDolares.Text);
                        Conversor(valor, "Dolares");
                    }
                    else
                    {
                        tbDolares.Text = tbDolares.Text.Remove(tbDolares.Text.Length - 1, 1);
                    }
                }

            }
        }

        private void tbPesos_TextChanged_1(object sender, EventArgs e)
        {
            if (bPesos == true)
            {
                if (!string.IsNullOrEmpty(tbPesos.Text))
                {
                    if (tbPesos.Text.All(char.IsDigit) || (!tbPesos.Text.StartsWith(",")))
                    {
                        double valor = Convert.ToDouble(tbPesos.Text);
                        Conversor(valor, "Pesos");
                    }
                    else
                    {
                        tbPesos.Text = tbPesos.Text.Remove(tbPesos.Text.Length - 1, 1);
                    }
                    
                }
            }
        }

        private void tbDolares_Click(object sender, EventArgs e)
        {
            tbEuros.Text = ""; tbPesos.Text = ""; tbPesetas.Text = ""; tbDolares.Text = "";
            bdolares = true;
            bEuros = false;
            bPesetas = false;
            bPesos = false;
        }

        private void tbPesos_Click(object sender, EventArgs e)
        {
            tbEuros.Text = ""; tbDolares.Text = ""; tbPesetas.Text = ""; tbPesos.Text = "";
            bdolares = false;
            bEuros = false;
            bPesetas = false;
            bPesos = true;
        }

        private void tbPesetas_Click(object sender, EventArgs e)
        {
            tbPesetas.Text = ""; tbEuros.Text = ""; tbDolares.Text = ""; tbPesos.Text = "";
            bdolares = false;
            bEuros = false;
            bPesetas = true;
            bPesos = false;
        }

        private void tbEuros_Click(object sender, EventArgs e)
        {
            tbPesetas.Text = ""; tbDolares.Text = ""; tbPesos.Text = ""; tbEuros.Text = "";
            bdolares = false;
            bEuros = true;
            bPesetas = false;
            bPesos = false;
        }

        private void tbPesetas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            if (e.KeyChar==',')
            {
                if (tbPesetas.Text.Contains(","))
                {
                    e.Handled = true;
                }
                else
                {
                    if (tbPesetas.Text == (","))
                    {
                        e.Handled = true;
                    }
                }


            }
        }

        private void tbEuros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',')
            {
                if (tbEuros.Text.Contains(","))
                {
                    e.Handled = true;
                }
                else
                {
                    if (tbEuros.Text == (","))
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void tbPesos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',')
            {
                if (tbPesos.Text == "")
                {
                    tbPesos.Text = "";
                }
                if (tbPesos.Text.Contains(","))
                {
                    e.Handled = true;
                }

            }
        }

        private void tbDolares_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',')
            {
                if (tbDolares.Text.Contains(","))
                {
                    e.Handled = true;
                }
                else
                {
                    if (tbDolares.Text == (","))
                    {
                        e.Handled = true;
                    }
                }
            }
        }
    }
}
