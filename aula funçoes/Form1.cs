using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace aula_funçoes
{
    public partial class lbresultado : Form
    {
        public lbresultado()
        {
            InitializeComponent();
        }

        
        //Função para chamar resultado(ou o root em css hehhe)
        public int ResultadoSoma(int num1, int num2)
        {
            int resultado = 0;

                resultado = num1 + num2;

                    return resultado;
        }
        //
        //
        public int ResultadoSubtracao(int num1, int num2) 
        { 
            int subtracao = 0;

                subtracao = num1 - num2;

                    return subtracao;
        }
        //
        //
        public int ResultadoVezes(int num1, int num2) 
        { 
        
            int vezes = 0;

                vezes = num1 * num2;

                    return vezes;
        }
        //
        //
        public int ResultadoDividir(int num1, int num2) 
        { 
        
            int dividir = 0;

                dividir = num1 / num2;

                    return dividir;
        }
        //
        public int CalculosMath(int num1, int num2, string operador) 
        {

            int resultado = 0;

                if (operador == "+")
                {
                    resultado = num1 + num2;
                }
                else if (operador == "-") 
                { 
                    resultado = num1 - num2;
                }
                else if (operador == "x") 
                {
                    resultado = num1 * num2;
                }
                else if (operador == "/") 
                {
                    resultado = num1 / num2;
                }    
             
                
                    return resultado;
        }
        //Fim das Funções
        

        

        //botoes
        private void btn1_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txb1.Text);
            int numero2 = int.Parse(txb2.Text);

            Button botao  = (Button)sender;

            String operadorSelecionado = botao.Text;

            int total;
                
            total= CalculosMath(numero1, numero2, operadorSelecionado);

            lbresultadoo.Text = total.ToString();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txb1.Text);
            int numero2 = int.Parse(txb2.Text);

            int total;

            total = CalculosMath(numero1, numero2, "-");

            lbresultadoo.Text = total.ToString();

        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txb1.Text);
            int numero2 = int.Parse(txb2.Text);

            int total;

            total = CalculosMath(numero1, numero2, "*");

            lbresultadoo.Text = total.ToString();

        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txb1.Text);
            int numero2 = int.Parse(txb2.Text);

            int total; 
            
            total = CalculosMath(numero1, numero2, "/");

            lbresultadoo.Text = total.ToString();

        }
        //Fim dos Botoes
    }
}
