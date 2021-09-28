using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_aula12
{
    class Triangulo : Forma
    {
        private double baseTriangulo;
        private double altura;

        public Triangulo(double baseTriangulo, double altura)
        {
            base.setCor("Verde");
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
            Console.WriteLine("Área do Quadrado: " + this.calculcarArea() + "\n");
        }

        public Triangulo(string cor, double baseTriangulo, double altura)
        {
            base.setCor(cor);
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
            Console.WriteLine("Área do Quadrado: " + this.calculcarArea() + "\n");
        }
        public override double calculcarArea()
        {
            return (baseTriangulo * altura) / 2;
        }
    }
}
