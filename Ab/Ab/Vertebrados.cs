using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab
{
    internal class Vertebrados : Animal
    {
        public string? tipo;
        public bool? tienePatas;
        public bool? esDomestico;
        public bool? esHerviboro;
        public bool? esCarnivoro;

        public override void imprimir()
        {
            if (validar())
            {
                Console.WriteLine("tipo: " + tipo);
            }
            Console.WriteLine("tienePatas: " + tienePatas);
            Console.WriteLine("esDomestico: " + esDomestico);
            Console.WriteLine("esHerviboro: " + esHerviboro);
            Console.WriteLine("esCarnivoro: " + esCarnivoro);

        }

        public override bool validar()
        {
            if (tipo != null)
            {
                return true;
            }
            else { return false; }

        }
    }
}
