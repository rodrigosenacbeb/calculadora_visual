using System;
using System.Windows.Forms;

namespace calculadora_visual
{
    public partial class Form1 : Form
    {
        string operacao = "";
        bool operacaoSelecionada = false;


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
            lblValor.Text = "0";
            operacao = "";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                if (txtDisplay.Text.Length == 0)
                {
                    txtDisplay.Text = "0";
                    lblValor.Text = "0";
                    operacao = "";
                }
            }
        }

        void Input(string valor)
        {
            if (txtDisplay.Text == "0" || operacaoSelecionada == true)
                txtDisplay.Text = "";

            operacaoSelecionada = false;
            txtDisplay.Text += valor;
        }

        void Operacao(string operador)
        {
            operacaoSelecionada = true;

            switch (operacao)
            {
                case "+":
                    lblValor.Text = (Convert.ToDouble(lblValor.Text) + Convert.ToDouble(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    lblValor.Text = (Convert.ToDouble(lblValor.Text) - Convert.ToDouble(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    lblValor.Text = (Convert.ToDouble(lblValor.Text) * Convert.ToDouble(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    lblValor.Text = (Convert.ToDouble(lblValor.Text) / Convert.ToDouble(txtDisplay.Text)).ToString();
                    break;
                default:
                    lblValor.Text = txtDisplay.Text;
                    break;
            }

            operacao = operador;
        }


        private void btnAdicao_Click(object sender, EventArgs e)
        {
            Operacao("+");
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            switch (operacao)
            {
                case "+":
                    lblValor.Text = (Convert.ToDouble(lblValor.Text) + Convert.ToDouble(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    lblValor.Text = (Convert.ToDouble(lblValor.Text) - Convert.ToDouble(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    lblValor.Text = (Convert.ToDouble(lblValor.Text) * Convert.ToDouble(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    lblValor.Text = (Convert.ToDouble(lblValor.Text) / Convert.ToDouble(txtDisplay.Text)).ToString();
                    break;
            }

            txtDisplay.Text = lblValor.Text;
            lblValor.Text = "0";
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

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.IndexOf(",") <= 0)
            {
                if (txtDisplay.Text == "0")
                    Input("0,");
                else
                    Input(",");
            }
        }
    }
}
