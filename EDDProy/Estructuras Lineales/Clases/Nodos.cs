using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class Nodos
    {
        public int Dato { get; set; }
        public Nodos Siguiente { get; set; }
        public Nodos Anterior { get; set; }

        public Nodos(int dato)
        {
            Dato = dato;
            Siguiente = null;
            Anterior = null;
        }
    }
}
