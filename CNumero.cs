using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TPractico_Integral
{
    //ejercicio 2
    public class CNumero: IComparable
    {
        private int valor;

        public CNumero(int valor)
        {
            this.valor = valor;
        }

        public int getValor()
        {
            return this.valor; 
        }

        public bool SosIgual(IComparable comparable)
        {
            CNumero numero = comparable as CNumero;
            return numero != null && valor == numero.valor;
        }

        public bool SosMenor(IComparable comparable)
        {
            CNumero numero = comparable as CNumero;
            return numero != null && valor < numero.valor;
        }

        public bool SosMayor(IComparable comparable)
        {
            CNumero numero = comparable as CNumero;
            return numero != null && valor > numero.valor;
        }

        public override string ToString()
        {
            return this.valor.ToString();
        }
    }
}
