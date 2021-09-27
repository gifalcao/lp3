using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_Atividade
{
    public class Sapo : Anfibio
    {
        public Sapo()
        {
            //    this.Caracteristicas();
        }
        protected override void Caracteristicas()
        {
            base.Caracteristicas();
            Console.WriteLine("São animais encontrados perto de águas, tem uma pele seca e lisa.");
        }
    }
