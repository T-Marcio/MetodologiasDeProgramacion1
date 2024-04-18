using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TPractico_Integral
{
    public class CColeccionMultiple : IColeccionable
    {

        CPila pila;
        CCola cola;
        public CColeccionMultiple(CPila pila, CCola cola)
        {
            this.pila = pila;
            this.cola = cola;
        }

        public int cuantos()
        {
            return this.pila.cuantos() + this.cola.cuantos();
        }

        public IComparable minimo()
        {

            IComparable pilamasChico = this.pila.minimo();
            IComparable colamasChico = this.cola.minimo();

            if (pilamasChico.SosMenor(pilamasChico).CompareTo(colamasChico.SosMenor(colamasChico)) < 0 )
            {
                return pilamasChico;
            }
            else
            {
                return colamasChico;
            }

        }

        public IComparable maximo()
        {
            IComparable pilamasGrande = this.pila.maximo();
            IComparable colamasGrande = this.cola.maximo();
            //pilamasGrande.SosMayor(pila.maximo());
            //colamasGrande.SosMayor(cola.maximo());

            if (pilamasGrande.SosMayor(pilamasGrande).CompareTo(colamasGrande.SosMayor(cola.maximo())) > 0)
            {
                return cola.maximo();
            }
            else
            {
                return pila.maximo();
            }
        }

        public void agregar(IComparable comparable)
        {

        }

        public bool contiene(IComparable comparable)
        {
            if (this.pila.contiene(comparable) || this.cola.contiene(comparable))
            {
                return true;
            }
            return false;
        }
    }
}
