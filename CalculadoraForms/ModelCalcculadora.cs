using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraForms
{
    class ModelCalculadora
    {
        private double operacao;

        public ModelCalculadora() 
        {
            ConsultarOperacao = 0;
        }//Fim do construtor

        public double ConsultarOperacao
        { get { return operacao;} 
          set { this.operacao = value;}
        }

        public double Somar(double num)
        { 
            return ConsultarOperacao += num; 
        }//Fim do Somar

        public double Subtrair(double num)
        {
            if (ConsultarOperacao <= 0)
            {
                return ConsultarOperacao = num;
            } 
            return ConsultarOperacao -= num;
        }//Fim do Subtrair

        public double Mutiplicacao(double num)
        {
            if (ConsultarOperacao <= 0)
            {
                return ConsultarOperacao = num;
            }
            return ConsultarOperacao *= num;
        }//Fim do Mutiplicar

        public double Divisao(double num)
        {
            if (ConsultarOperacao <= 0)
            {
                return ConsultarOperacao = num;
            }
            return ConsultarOperacao /= num;
        }//Fim da Divisao

        public double Raiz(double num)
        {
            return ConsultarOperacao = Math.Sqrt(num);
        }//Fim da Raiz

        public double Potencia(double num)
        {
            if (ConsultarOperacao <= 0)
            {
                return ConsultarOperacao = num; 
            }
            return Math.Pow(ConsultarOperacao, num); 
        }

        public double clear(double num)
        {
            return ConsultarOperacao = 0;
        }//FIm do Clear
    }
}
