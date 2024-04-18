using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPractico_Integral
{
    //ejercicio 4
    public class CPila: IColeccionable
    {
        private List<IComparable> elementos;

        public CPila()
        {
            this.elementos = new List<IComparable>();
        }

        public void apilar(IComparable comparable)
        {
            this.elementos.Add(comparable);
        }

        public IComparable desapilar()
        {
            IComparable elemento = this.elementos[this.elementos.Count-1];
            this.elementos.RemoveAt(this.elementos.Count-1);
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
                    masGrande = this.elementos[i];
                }
            }
            return masGrande;
            
        }


        public void agregar(IComparable comparable)
        {
            this.apilar(comparable);
        }

        public bool contiene(IComparable comparable)
        {
            foreach(IComparable elemento in this.elementos)
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
