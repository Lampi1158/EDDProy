using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        NodoBinario Raiz;
        public String strArbol;
        public String strRecorrido;

        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = "";
            strRecorrido = "";
        }

        public Boolean EstaVacio()
        {
            if (Raiz == null)
                return true;
            else
                return false;
        }
        public NodoBinario RegresaRaiz()
        {
            return Raiz;
        }

        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {
            if (Busqueda(Dato, Nodo))
            {

                MessageBox.Show("El valor " + Dato + " ya existe en el árbol.");
            }



            if (Nodo == null)
            {
                Nodo = new NodoBinario(Dato);
               // Nodo.Dato = Dato;
                //Nodo.Izq = null;
                //Nodo.Der = null;

                if (Raiz == null)
                    Raiz = Nodo;
            }
            else if (Dato < Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Izq);
            else if (Dato > Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Der);          
        }
        public void Muestra(int nivel, NodoBinario nodo )
        {
            if (nodo == null)
                return;
            Muestra(nivel + 1, nodo.Der);
            for(int i=0; i<nivel; i++)
            {
                strArbol = strArbol + "     ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            Muestra(nivel + 1, nodo.Izq); 
        }


        public String ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [side=L] {2} ", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            }
            return b.ToString();
        }

        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            strRecorrido = strRecorrido + nodo.Dato + ", ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);

            return;
        }
        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            InOrden(nodo.Izq);
            strRecorrido = strRecorrido + nodo.Dato + ", ";
            InOrden(nodo.Der);

            return;
        }
        public void PostOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + ", ";

            return;
        }
        

        public bool Busqueda(int Dato, NodoBinario nodo)
        {
            if (nodo == null)
                return false;

            if (Dato < nodo.Dato)
                return Busqueda(Dato, nodo.Izq);
            else if (Dato > nodo.Dato)
                return Busqueda(Dato, nodo.Der);
            else
                return true;
        }

        public void PodarArbol(ref NodoBinario nodo)
        {
            if (nodo == null)
                return;

            PodarArbol(ref nodo.Izq);

            PodarArbol(ref nodo.Der);

            nodo = null;
        }

        public void PodarTodoElArbol()
        {
            PodarArbol(ref Raiz);
        }


        public void eliminarPredecesor(int x, ref NodoBinario nodoPtr)
        {
            if (nodoPtr == null) return;

            if (x < nodoPtr.Dato)
            {
                eliminarPredecesor(x, ref nodoPtr.Izq);
            }
            else if (x > nodoPtr.Dato)
            {
                eliminarPredecesor(x, ref nodoPtr.Der);
            }
            else if (nodoPtr.Izq != null && nodoPtr.Der != null)
            {
                NodoBinario mayor = buscaMayor(nodoPtr.Izq);
                nodoPtr.Dato = mayor.Dato;
                eliminarPredecesor(mayor.Dato, ref nodoPtr.Izq);
            }
            else
            {
                NodoBinario temp = nodoPtr;
                if (nodoPtr.Izq == null) nodoPtr = nodoPtr.Der;
                else if (nodoPtr.Der == null) nodoPtr = nodoPtr.Izq;
                temp = null;
            }
        }

       
        public void eliminarSucesor(int x, ref NodoBinario nodoPtr)
        {
            if (nodoPtr == null) return;

            if (x < nodoPtr.Dato)
            {
                eliminarSucesor(x, ref nodoPtr.Izq);
            }
            else if (x > nodoPtr.Dato)
            {
                eliminarSucesor(x, ref nodoPtr.Der);
            }
            else if (nodoPtr.Izq != null && nodoPtr.Der != null)
            {
                NodoBinario menor = buscaMenor(nodoPtr.Der);
                nodoPtr.Dato = menor.Dato;
                eliminarSucesor(menor.Dato, ref nodoPtr.Der);
            }
            else
            {
                NodoBinario temp = nodoPtr;
                if (nodoPtr.Izq == null) nodoPtr = nodoPtr.Der;
                else if (nodoPtr.Der == null) nodoPtr = nodoPtr.Izq;
                temp = null;
            }
        }

       
        private NodoBinario buscaMayor(NodoBinario nodo)
        {
            while (nodo.Der != null) nodo = nodo.Der;
            return nodo;
        }

        private NodoBinario buscaMenor(NodoBinario nodo)
        {
            while (nodo.Izq != null) nodo = nodo.Izq;
            return nodo;
        }

        public int Altura(NodoBinario nodo)
        {
            if (nodo == null)
                return 0;
            return 1 + Math.Max(Altura(nodo.Izq), Altura(nodo.Der));
        }

        public void RecorridoPorNiveles(NodoBinario nodo)
        {
          

            if (Raiz == null) return;

            Queue<NodoBinario> colaAuxiliar = new Queue<NodoBinario>();
            colaAuxiliar.Enqueue(Raiz);

            while (colaAuxiliar.Count > 0)
            {
                NodoBinario nodoAuxiliar = colaAuxiliar.Dequeue();
                Console.Write(nodoAuxiliar.Dato + " ");
                strRecorrido += nodoAuxiliar.Dato + ", ";

                if (nodoAuxiliar.Izq != null)
                    colaAuxiliar.Enqueue(nodoAuxiliar.Izq);

                if (nodoAuxiliar.Der != null)
                    colaAuxiliar.Enqueue(nodoAuxiliar.Der);
            }
        }


        public int ContarHojas(NodoBinario nodo)
        {
            if (nodo == null)
                return 0;

            if (nodo.Izq == null && nodo.Der == null)
                return 1;

            return ContarHojas(nodo.Izq) + ContarHojas(nodo.Der);
        }

        
        public int ContarNodos(NodoBinario nodo)
        {
            if (nodo == null)
                return 0;

            return 1 + ContarNodos(nodo.Izq) + ContarNodos(nodo.Der);
        }

        public bool esLleno(NodoBinario nodoPtr)
        {
            if (nodoPtr == null) return true;
            if (nodoPtr.Izq == null && nodoPtr.Der == null) return true;
            if (nodoPtr.Izq != null && nodoPtr.Der != null)
                return esLleno(nodoPtr.Izq) && esLleno(nodoPtr.Der);
            return false;
        }

        // Método para verificar si el árbol está completo
        public bool esCompleto(NodoBinario nodoPtr)
        {
            if (nodoPtr == null) return true;

            Queue<NodoBinario> colaAuxiliar = new Queue<NodoBinario>();
            colaAuxiliar.Enqueue(nodoPtr);
            bool nodoNuloEncontrado = false;

            while (colaAuxiliar.Count > 0)
            {
                NodoBinario actual = colaAuxiliar.Dequeue();

                if (actual.Izq != null)
                {
                    if (nodoNuloEncontrado) return false;
                    colaAuxiliar.Enqueue(actual.Izq);
                }
                else
                {
                    nodoNuloEncontrado = true;
                }

                if (actual.Der != null)
                {
                    if (nodoNuloEncontrado) return false;
                    colaAuxiliar.Enqueue(actual.Der);
                }
                else
                {
                    nodoNuloEncontrado = true;
                }
            }

            return true;
        }


    }

}






