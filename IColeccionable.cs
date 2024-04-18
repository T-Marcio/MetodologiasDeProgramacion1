using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPractico_Integral
{
    //ejercicio 3
    public interface IColeccionable
    {
        int cuantos();
        IComparable minimo();
        IComparable maximo();
        void agregar(IComparable comparable);
        bool contiene(IComparable comparable);
    }
}
