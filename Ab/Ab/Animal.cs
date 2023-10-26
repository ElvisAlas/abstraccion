using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab
{
    internal abstract class Animal
    {


        public string? nombre;
        public string? color;
        public string? tamano;
        public string? familia;

        public abstract void imprimir();


        public abstract bool validar();


    }
}
