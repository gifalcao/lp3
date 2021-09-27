
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_Atividade
{
    public class Reptil : Animal
    {
        public Reptil()
        {
            this.Caracteristicas();
        }
        protected override void Caracteristicas()
        {
            base.Caracteristicas();
            Console.Write("Os repteis");
            Console.WriteLine("São animais ectotérmicos, tem uma pele escamada e texturizada");
        }
    }
}
