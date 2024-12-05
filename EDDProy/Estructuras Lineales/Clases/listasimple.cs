using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class listasimple
    {
        public Nodos Inicio { get; private set; }

        public listasimple()
        {
            Inicio = null;
        }

        public void AgregarInicio(int dato)
        {
            Nodos nuevo = new Nodos(dato);
            nuevo.Siguiente = Inicio;
            Inicio = nuevo;
        }

        public void AgregarFinal(int dato)
        {
            Nodos nuevo = new Nodos(dato);
            if (Inicio == null)
            {
                Inicio = nuevo;
            }
            else
            {
                Nodos actual = Inicio;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
        }

        public void EliminarInicio()
        {
            if (Inicio != null)
            {
                Inicio = Inicio.Siguiente;
            }
        }

        public void EliminarFinal()
        {
            if (Inicio != null)
            {
                if (Inicio.Siguiente == null)
                {
                    Inicio = null;
                }
                else
                {
                    Nodos actual = Inicio;
                    while (actual.Siguiente.Siguiente != null)
                    {
                        actual = actual.Siguiente;
                    }
                    actual.Siguiente = null;
                }
            }
        }

        public bool Buscar(int dato)
        {
            Nodos actual = Inicio;
            while (actual != null)
            {
                if (actual.Dato == dato)
                    return true;
                actual = actual.Siguiente;
            }
            return false;
        }

        public List<int> ObtenerLista()
        {
            List<int> lista = new List<int>();
            Nodos actual = Inicio;
            while (actual != null)
            {
                lista.Add(actual.Dato);
                actual = actual.Siguiente;
            }
            return lista;
        }
    }
}
