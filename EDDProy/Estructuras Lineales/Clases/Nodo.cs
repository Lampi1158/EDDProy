using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    public class Nodo
    {
       
        public Nodo sig;
        public string Dato { get; set; }
        public int Datos { get; set; }
        public Nodo Siguiente { get; set; }
        public Nodo Anterior { get; set; }


        public Nodo(string dato,int datos )
        {
            Dato = dato;
            Datos = datos;
            Siguiente = null;
            Anterior = null;
        }
    }
}
