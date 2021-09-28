using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_aula12
{
    abstract class Forma
    {
        private string cor;

        protected void setCor(string cor)
        {
            this.cor = cor;
            Console.WriteLine("Cor da forma: " + cor);
        }

        public abstract double calculcarArea();

    }
}
