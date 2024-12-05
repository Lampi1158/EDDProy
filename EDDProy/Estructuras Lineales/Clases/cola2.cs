using EDDemo.Estructuras_No_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class cola2
    {
        MiNodo _inicio;

        public void encolar(MiNodo unNodo)
        {
            if (_inicio == null)
            {
                _inicio = unNodo;
            }
            else
            {
                MiNodo aux = BuscarUltimo(_inicio);
                aux.siguiente = unNodo;
            }
        }

        private MiNodo BuscarUltimo(MiNodo unNodo)
        {
            if (unNodo.siguiente == null)
            {
                return unNodo;
            }
            else
            {
                return BuscarUltimo(unNodo.siguiente);
            }

        }


        public void desencolar()
        {
            _inicio = _inicio.siguiente;
        }

        public MiNodo inicio
        {
            get
            {
                return _inicio;
            }
        }

        public bool Vacia()
        {
            return (inicio == null);
        }
    }

}
