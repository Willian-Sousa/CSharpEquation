using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Omitir painel de resultados
            panResultado.Visible = false;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Apresentar resultados
            panResultado.Visible = true;

            //Pegando valores dos spinners
            int a = Convert.ToInt32(numA.Value);
            int b = Convert.ToInt32(numB.Value);
            int c = Convert.ToInt32(numC.Value);

            //Cálculo do delta utilizando a fórmula de Bhaskara delta = B²-4.A.C
            double delta = Math.Pow(b, 2) - 4 * a * c;

            //Exibir resultado de delta
            this.lblDeltaRes.Text = Convert.ToString(delta);

            //Cálculo da raíz de delta
            double raizDelta = Math.Sqrt(delta);

            //Exibir na tela o resultado da raíz de delta
            if (delta <= 0)
            {
                this.lblRaizDelta.Text = "Não existe raíz negativa.";
            }
            else
            {
                this.lblRaizDelta.Text = String.Format("{0:0.0}", raizDelta);
            }
            //Condicional para raízes reais (não existe raiz negativa)
            String text1 = "Existem raízes reais para sua equação.";
            String text2 = "Não existe raízes negativas, \nverifique sua equação e tente novamente.";

            String tipo = (delta >= 0) ? text1 : text2;

            //Saída do resultado da condicional
            this.lblTipo.Text = tipo;


            //Cálculo de x1 e x2
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            //Saída dos relultados dos cálculos de x1 e x2
            if (delta <= 0)
            {
                this.lblX1.Text = "Sem solução.";
                this.lblX2.Text = "Sem solução.";
            }
            else 
            {
                this.lblX1.Text = String.Format("{0:0.0}", x1);
                this.lblX2.Text = String.Format("{0:0.0}", x2);
            }


        }

        private void numA_ValueChanged(object sender, EventArgs e)
        {
            //Mudar texto da equação de acordo com a mudança do spinner A
            lblA.Text = Convert.ToString(numA.Value);
        }

        private void numB_ValueChanged(object sender, EventArgs e)
        {
            //Mudar texto da equação de acordo com a mudança do spinner B
            lblB.Text = Convert.ToString(numB.Value);
        }

        private void numC_ValueChanged(object sender, EventArgs e)
        {
            //Mudar texto da equação de acordo com a mudança do spinner C
            lblC.Text = Convert.ToString(numC.Value);
        }
    }
}
