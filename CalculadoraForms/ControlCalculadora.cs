using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForms
{
    public partial class ControlCalculadora : Form
    {
        ModelCalculadora modelo;
        
        public ControlCalculadora()
        {
            InitializeComponent();
            this.modelo = new ModelCalculadora();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.modelo.Divisao(Convert.ToDouble(maskedTextBox1.Text));
        }//Fim da Divisao

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.modelo.Somar(Convert.ToDouble(maskedTextBox1.Text));
        }//Fim da soma

        private void button3_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.modelo.Subtrair(Convert.ToDouble(maskedTextBox1.Text));
        }//Fim da subtração

        private void button4_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.modelo.Mutiplicacao(Convert.ToDouble(maskedTextBox1.Text));
        }//Fim da Mutiplicação

        private void button1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.modelo.clear(Convert.ToDouble(maskedTextBox1.Text));
        }//Fim do Resultado

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }// Onde vai digitar

        private void button6_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.modelo.Raiz(Convert.ToDouble(maskedTextBox1.Text));
        }//Raiz

        private void button7_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.modelo.Potencia(Convert.ToDouble(maskedTextBox1.Text));
        }//Potencia

        private void label1_Click(object sender, EventArgs e)
        {

        }//Observação da mensagem
    }//Fim da classe
}//Fim do Projeto
