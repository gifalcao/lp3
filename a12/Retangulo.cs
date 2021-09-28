using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_aula12
{
    class Retangulo : Forma
    {
        private double lado;
        private double altura;

        public Retangulo(double lado, double altura)
        {
            base.setCor("Roxo");
            this.lado = lado;
            this.altura = altura;
            Console.WriteLine("Área do Retangulo: " + this.calculcarArea() + "\n");
        }

        public Retangulo(string cor, double lado, double altura)
        {
            base.setCor(cor);
            this.lado = lado;
            this.altura = altura;
            Console.WriteLine("Área do Retangulo: " + this.calculcarArea() + "\n");
        }
        public override double calculcarArea()
        {
            return lado * altura;
        }
    }
}
