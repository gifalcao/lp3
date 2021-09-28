using System;

namespace Atividade_aula12
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado1 = new Quadrado(7.0);
            Quadrado quadrado2 = new Quadrado("Vermelho", 8.0);

            Circulo circulo1 = new Circulo(3.0);
            Circulo circulo2 = new Circulo("Roxo", 6.0);

            Retangulo retangulo1 = new Retangulo(8.0, 3.0);
            Retangulo retangulo2 = new Retangulo("Rosa",9.0,6.0);
            
            Triangulo triangulo1 = new Triangulo(6.0, 2.0);
            Triangulo triangulo2 = new Triangulo("Azul", 10.0, 5.0);
        }
    }
}
