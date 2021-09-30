using System;

namespace Atividade_aula13
{
    class Program
    {
        static void mostrarArea(IForma forma)
        {
            Console.WriteLine(forma.calcularArea());
        }
        static void Main(string[] args)
        {
            IForma forma = new Quadrado(8.0);
            mostrarArea(forma);

            forma = new Retangulo(3.0, 5.0);
            mostrarArea(forma);

            forma = new Circulo(3.0);
            mostrarArea(forma);

            forma = new Triangulo(9.0, 3.5);
            mostrarArea(forma);
        }
    }
}
