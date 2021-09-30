using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_aula13
{
    class Retangulo : IForma
    {
        private double lado;
        private double altura;
        public Retangulo(double lado, double altura)
        {      
            this.lado = lado;
            this.altura = altura;
        }

        public double calcularArea()
        {
            return lado * altura;
        }
    }
}
