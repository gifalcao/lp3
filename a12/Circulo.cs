using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_aula12
{
    class Circulo : Forma
    {
        private double raio;

        public Circulo(double raio)
        {
            base.setCor("Azul");
            this.raio = raio;
            Console.WriteLine("Área do Círculo: " + this.calculcarArea() + "\n");
        }

        public Circulo(string cor, double raio)
        {
            base.setCor(cor);
            this.raio = raio;
            Console.WriteLine("Área do Círculo: " + this.calculcarArea() + "\n");
        }
        public override double calculcarArea()
        {
            return 3.14 * (Math.Pow(raio, 2));
        }
    }
}
