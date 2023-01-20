using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class LGTV : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";




        public LGTV()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void botaosoma_Click(object sender, EventArgs e)
        {
           valor1 = decimal.Parse(resultado.Text,CultureInfo.InvariantCulture);
            resultado.Text = "";
            operacao = "soma";
            labelOperacao.Text = "+";
            valor1 = 0;
            valor2 = 0;
        }

        private void botao9_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "9";
        }

        private void botao7_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "7";



        }

        private void botao2_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "2";
        }

        private void botao3_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "3";
        }

        private void botao4_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "4";
        }

        private void botao5_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "5";
        }

        private void botao6_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "6";
        }

        private void botao8_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "8";
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "1";
        }

        private void botaomenos_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(resultado.Text,CultureInfo.InvariantCulture);
            resultado.Text = "";
            operacao = "menos";
            labelOperacao.Text = "-";
        }

        private void botaoce_Click(object sender, EventArgs e)
        {
            resultado.Text = "";
        }

        private void botaoc_Click(object sender, EventArgs e)
        {
            resultado.Text = "";
            labelOperacao.Text = "";
            valor2 = 0;
            valor1 = 0;

        }

        private void botaox_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(resultado.Text, CultureInfo.InvariantCulture);
            resultado.Text = "";
            operacao = "mult";
            labelOperacao.Text = "X";
        }

        private void botaodivisao_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(resultado.Text, CultureInfo.InvariantCulture);
            resultado.Text = "";
            operacao = "div";
            labelOperacao.Text = "/";
            

        
        
        }

        private void botaoresultado_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(resultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "soma")
            {
                resultado.Text = Convert.ToString(valor1 + valor2);
            }

            if (operacao == "menos")
            {
                resultado.Text = Convert.ToString(valor1 - valor2);
            }
            if (operacao == "div")
            {
                resultado.Text = Convert.ToString(valor1 / valor2);
            }
            if (operacao == "mult")
            {
                resultado.Text = Convert.ToString(valor1 * valor2);
            }


        }
    }
}
