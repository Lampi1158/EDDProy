using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class ListaDoble
    {
        public Nodos Inicio { get; private set; }
        public Nodos Fin { get; private set; }

        public ListaDoble()
        {
            Inicio = null;
            Fin = null;

        }

        public void AgregarInicio( int dato)
        {
            Nodos nuevo = new Nodos(dato);
            if (Inicio == null)
            {
                Inicio = Fin = nuevo;
            }
            else
            {
                nuevo.Siguiente = Inicio;
                Inicio.Anterior = nuevo;
                Inicio = nuevo;
            }
        }

        public void AgregarFinal( int dato)
    {
        Nodos nuevo = new Nodos(dato);
        if (Fin == null)
        {
            Inicio = Fin = nuevo;
        }
        else
        {
            Fin.Siguiente = nuevo;
            nuevo.Anterior = Fin;
            Fin = nuevo;
        }
    }

    public void EliminarInicio()
    {
        if (Inicio != null)
        {
            if (Inicio == Fin)
            {
                Inicio = Fin = null;
            }
            else
            {
                Inicio = Inicio.Siguiente;
                Inicio.Anterior = null;
            }
        }
    }

    public void EliminarFinal()
    {
        if (Fin != null)
        {
            if (Inicio == Fin)
            {
                Inicio = Fin = null;
            }
            else
            {
                Fin = Fin.Anterior;
                Fin.Siguiente = null;
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
