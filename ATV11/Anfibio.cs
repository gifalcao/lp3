
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_Atividade
{
    public class Anfibio : Animal
    {
        public Anfibio()
        {
            this.Caracteristicas();
        }
        protected override void Caracteristicas()
        {
            base.Caracteristicas();
            Console.Write("Animais anfibios:");
            Console.WriteLine("São animais com pele úmida e lisa, que vivem em ambientes úmidos e quentes.");
        }
    }
}
