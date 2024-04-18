using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPractico_Integral
{
    //ejercicio 4
    public class CCola: IColeccionable
    {
        private List<IComparable> elementos;

        public CCola()
        {
            this.elementos = new List<IComparable>();
        }

        public void encolar(IComparable comparable)
        {
            this.elementos.Add(comparable);
        }

        public IComparable desencolar()
        {
            IComparable elemento = this.elementos[0];
            this.elementos.RemoveAt(0);
            return elemento;
        }

        public int cuantos()
        {
            return this.elementos.Count;
        }

        public IComparable minimo()
        {
            IComparable masChico = this.elementos[0];
            for(int i = 1; i < this.elementos.Count; i++)
            {
                if (this.elementos[i].SosMenor(masChico))
                {
                    masChico = this.elementos[i];
                }
            }
            return masChico;
        }

        public IComparable maximo()
        {
            IComparable masGrande = this.elementos[0];
            for (int i = 1; i < this.elementos.Count; i++)
            {
                if (this.elementos[i].SosMayor(masGrande))
                {
                    masGrande = this.elementos[i] ;
                }
            }
            return masGrande;

        }

        public void agregar(IComparable comparable)
        {
            this.encolar(comparable);
        }

        public bool contiene(IComparable comparable)
        {
            foreach (IComparable elemento in this.elementos)
            {
                if (elemento.SosIgual(comparable))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
