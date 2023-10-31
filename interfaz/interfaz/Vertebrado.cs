using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaz
{
    internal class Vertebrado : Animal, AnimalInterfaz
    {
        public string? tipo;
        public bool tienePatas;
        public int numeroPatas;
        public bool esDomestico;
        public bool esHerviboro;
        public bool esCarnivoro;

        public void imprimir()
        {
            if (validar())
            {
                Console.WriteLine("Nombre: " + nombre);
            }

    
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Tamaño: " + tamano);
            Console.WriteLine("Familia: " + familia);

            Console.WriteLine("Tipo: " + tipo);
            Console.WriteLine("Tiene Patas: " + (tienePatas ? "yes" :"No"));
            mostrarmensajenumeroPatas();


            Console.WriteLine("Es Domestico: " + esDomestico);
            Console.WriteLine("Es Herviboro: " + esHerviboro);
            Console.WriteLine("Es Carmovoro: " + esCarnivoro);
      


        }

        public bool tienepatasanimal()
        {
            throw new NotImplementedException();
        }

        public bool validar()
        {
            if (nombre != null)
            {
                return true;

            }
            else
            {
                ; return false;
            }
        }

  
        void AnimalInterfaz.validar()
        {
            throw new NotImplementedException();
        }

        public void mostrarmensajenumeroPatas()
        {
            if (tienePatas)
            {
                if (numeroPatas != null)
                {
                    Console.WriteLine("numero de patas" + numeroPatas);
                }
                else
                {
                    Console.WriteLine("no tiene patas");
                }
            }
        }
    }


}
