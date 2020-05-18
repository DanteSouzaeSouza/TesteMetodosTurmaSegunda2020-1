using System;
using System.Linq;
using System.Windows.Forms;

namespace TesteMetodosTurmaSegunda2020_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //declaração e implementação da função
        private int VerificaMaior(int[] nums)
        {
            // retornando o maior valor do array usando a biblioteca linq
            return nums.Max();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //declaração das variáveis
            //entrada de dados para as variáveis
            var a = Convert.ToInt32(txtA.Text);
            var b = Convert.ToInt32(txtB.Text);
            var c = Convert.ToInt32(txtC.Text);


            // Adicionando números ao array
            int[] arrayNumeros = {a, b, c};

            // chamando a função VerificaMaior 
            // e passando os argumentos para os parâmetros num1 e num2
            // TextBox txtMaior recebe o retorno da função
            txtMaior.Text = VerificaMaior(arrayNumeros).ToString();
        }
    }
}