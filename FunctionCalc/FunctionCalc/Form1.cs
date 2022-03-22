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
            panX.Visible = false;
        }
        //variáveis globais
        double delta, raizDelta, x1, x2;
        int a, b, c;

        private void btnCalc_Click(object sender, EventArgs e) // Primeiro método para cálculo de Delta e raíz de Delta
        {

            //Zerar variáveis x1 e x2 para nova consulta
            this.lblX1.Text = "0";
            this.lblX2.Text = "0";

            //Apresentar resultados
            panResultado.Visible = true;

            //Pegando valores dos spinners
            a = Convert.ToInt32(numA.Value);
            b = Convert.ToInt32(numB.Value);
            c = Convert.ToInt32(numC.Value);

            //Cálculo do delta utilizando a fórmula de Bhaskara delta = B²-4.A.C
            delta = Math.Pow(b, 2) - 4 * a * c;

            //Exibir resultado de delta
            this.lblDeltaRes.Text = Convert.ToString(delta);

            //Cálculo da raíz de delta
            raizDelta = Math.Sqrt(delta);

            //Exibir na tela o resultado da raiz de delta
            if (delta <= 0)
            {
                panX.Visible = false; //esconder painel em caso de nova consulta

                this.lblRaizDelta.Text = "Não existe raiz negativa.";
            }
            else
            {
                panX.Visible = true; //mostrar painel de cálculo para x1 e x2

                this.lblRaizDelta.Text = String.Format("{0:0.0}", raizDelta);
            }
            //Condicional para raízes reais (não existe raiz negativa)
            String text1 = "Existem raízes reais para a sua equação.";
            String text2 = "Não existe raízes negativas, \nverifique sua equação e tente novamente.";

            String tipo = (delta >= 0) ? text1 : text2;

            //Saída do resultado da condicional
            this.lblTipo.Text = tipo;

        }

        private void btnCalcX_Click(object sender, EventArgs e) //Segundo método para cálculo de X1 e X2
        {

            //Cálculo de x1 e x2 (-b² +- raiz de delta / 2 . a)
            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            //Saída dos resultados dos cálculos de x1 e x2
            this.lblX1.Text = String.Format("{0:0.0}", x1);
            this.lblX2.Text = String.Format("{0:0.0}", x2);
            
        }

        private void numA_ValueChanged(object sender, EventArgs e)
        {
            //Mudar texto da equação de acordo com a mudança do spinner A
            this.lblA.Text = Convert.ToString(numA.Value);
        }

        private void numB_ValueChanged(object sender, EventArgs e)
        {
            //Mudar texto da equação de acordo com a mudança do spinner B
            this.lblB.Text = Convert.ToString(numB.Value);
        }

        private void numC_ValueChanged(object sender, EventArgs e)
        {
            //Mudar texto da equação de acordo com a mudança do spinner C
            this.lblC.Text = Convert.ToString(numC.Value);
        }

    }
}
