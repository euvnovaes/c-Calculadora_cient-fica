using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjCalculadoraCientifica
{
    public partial class Form1 : Form
    {

        String operador = "";
        double valor1 = 0.0;
        Calcula calc = new Calcula();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }

            
            lblDisplay.Text += "1";
           
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }


            lblDisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }


            lblDisplay.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }


            lblDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }


            lblDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }


            lblDisplay.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }


            lblDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }


            lblDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }


            lblDisplay.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "0";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                lblOperador.Text = "/";

                valor1 = double.Parse(lblDisplay.Text);
                lblDisplay.Text = "";
                operador = "/";
            } catch (Exception erro) { }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            try
            {
                lblOperador.Text = "x";

                valor1 = double.Parse(lblDisplay.Text);
                lblDisplay.Text = "";
                operador = "x";
            } catch (Exception erro) { }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                lblOperador.Text = "-";

                valor1 = double.Parse(lblDisplay.Text);
                lblDisplay.Text = "";
                operador = "-";
            } catch (Exception erro) { }
            
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            try
            {
                lblOperador.Text = "+";

                valor1 = double.Parse(lblDisplay.Text);
                lblDisplay.Text = "";
                operador = "+";
            } catch (Exception erro) { }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            lblOperador.Text = "=";
            
            Double v2 = Double.Parse(lblDisplay.Text);
            Double res = calc.Calcular(valor1, v2, operador);

            lblDisplay.Text = res.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            lblOperador.Text = "";
            valor1 = 0.0;
        }

        private void btnVirg_Click(object sender, EventArgs e)
        {

            if (lblDisplay.Text == "")
            {
                lblDisplay.Text += "0,";
            }
            else if (!lblDisplay.Text.Contains(","))
            {
                lblDisplay.Text += ",";
            }

        }

        private void btnSeno_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = calc.mSeno(lblDisplay.Text);
            lblOperador.Text = "=";
        }

        private void btnCosseno_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = calc.mCosseno(lblDisplay.Text);
            lblOperador.Text = "=";
        }

        private void rdBinario_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBinario.Checked)
            {
                lblDisplay.Text = calc.Binário(lblDisplay.Text);
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
            }
        }

        private void rdDecimal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDecimal.Checked)
            {
                lblDisplay.Text = calc.Decimal(lblDisplay.Text);
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
            }
            
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {

            if (lblDisplay.Text.Length > 1)
            {
                lblDisplay.Text = lblDisplay.Text.Remove(lblDisplay.Text.Length - 1);
            }
            else if (lblDisplay.Text.Length == 1)
            {
                lblDisplay.Text = "0";
            }
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = calc.Invertido(lblDisplay.Text);
        }
    }
}
