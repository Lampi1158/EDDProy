using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_No_Lineales.Clases
{
    internal class MiPila
    {
        MiNodo _tope;
        public MiNodo Tope()
        {
            return _tope;
        }


        public void aplicar(MiNodo unNodo)
        {
            if (_tope == null)
            {
                _tope = unNodo;

            }
            else
            {
                MiNodo auxiliar = _tope;
                _tope = unNodo;
                _tope.siguiente = auxiliar;
            }

        }

        public void desaplilar()

        {
            if (_tope != null)
            {
                _tope = _tope.siguiente;
            }


        }
    }
}
