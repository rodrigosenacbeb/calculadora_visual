using System;
using System.Windows.Forms;

namespace calculadora_visual
{
    public partial class Form1 : Form
    {
        bool primeiroNumero = true;
        bool anterior = false;
        bool primeiraOperacao = true;
        double valorAnterior = 0;
        double valorAtual = 0;
        string ultimaOperacao;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            Input("0");
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            Input("1");
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            Input("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            Input("3");
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            Input("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            Input("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            Input("6");
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            Input("7");
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            Input("8");
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            Input("9");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            primeiroNumero = true;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                if (txtDisplay.Text.Length == 0)
                {
                    txtDisplay.Text = "0";
                    primeiroNumero = true;
                }
            }
        }

        void Input(string valor)
        {
            if (primeiroNumero)
            {
                txtDisplay.Text = "";
                primeiroNumero = false;
            }

            txtDisplay.Text += valor;
        }

        void Operacao(string operador)
        {
            if (operador == "+")
            {
                if (!anterior)
                {
                    valorAnterior = Convert.ToDouble(txtDisplay.Text);
                    anterior = !anterior;
                }
                else
                {
                    anterior = !anterior;
                }


                if (primeiraOperacao)
                {
                    txtDisplay.Text = valorAnterior.ToString();
                    primeiraOperacao = false;
                }
                else
                {
                    valorAtual = Convert.ToDouble(txtDisplay.Text) + valorAnterior;
                    txtDisplay.Text = valorAtual.ToString();
                }

                
                
                ultimaOperacao = "+";
                valorAtual = 0;
            }
            else if (operador == "-")
            {
                txtDisplay.Text = valorAnterior.ToString();
                valorAnterior -= Convert.ToDouble(txtDisplay.Text);
                ultimaOperacao = "-";                
                valorAnterior = 0;
            }
            else if (operador == "*")
            {
                txtDisplay.Text = valorAnterior.ToString();
                valorAnterior *= Convert.ToDouble(txtDisplay.Text);
                ultimaOperacao = "*";                               
                valorAnterior = 0;
            }
            else if (operador == "/")
            {
                txtDisplay.Text = valorAnterior.ToString();
                valorAnterior /= Convert.ToDouble(txtDisplay.Text);
                ultimaOperacao = "/";               
                valorAnterior = 0;
            }
            else if (operador == "=")
            {
                if (ultimaOperacao == "+")
                    valorAnterior += Convert.ToDouble(txtDisplay.Text);
                else if (ultimaOperacao == "-")
                    valorAnterior -= Convert.ToDouble(txtDisplay.Text);
                else if (ultimaOperacao == "*")
                    valorAnterior *= Convert.ToDouble(txtDisplay.Text);
                else if (ultimaOperacao == "/")
                    valorAnterior /= Convert.ToDouble(txtDisplay.Text);

                txtDisplay.Text = valorAnterior.ToString();
                valorAnterior = 0;
            }

            primeiroNumero = true;
        }
               

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            Operacao("+");
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            Operacao("=");
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            Operacao("-");
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            Operacao("*");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            Operacao("/");
        }
    }
}
