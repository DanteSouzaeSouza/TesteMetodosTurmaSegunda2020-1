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
            
            // Adicionando números ao array
            int[] arrayNumeros = { Convert.ToInt32(txtA.Text), Convert.ToInt32(txtB.Text), Convert.ToInt32(txtC.Text) };

            // chamando a função VerificaMaior 
            // e passando os argumentos para os parâmetros num1 e num2
            // TextBox txtMaior recebe o retorno da função
            txtMaior.Text = VerificaMaior(arrayNumeros).ToString();
        }
    }
}