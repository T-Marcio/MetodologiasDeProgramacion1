using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPractico_Integral
{
    //ejercjcio 1
    public interface IComparable
    {
        bool SosIgual(IComparable comparable);
        bool SosMenor(IComparable comparable);
        bool SosMayor(IComparable comparable);
    }
}
