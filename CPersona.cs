using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPractico_Integral
{
    public class CPersona : IComparable
    {
        protected string nombre;
        protected int dni;

        public CPersona(string nombre, int dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public int getDni()
        {
            return this.dni;
        }

        public bool SosIgual(IComparable comparable)
        {
            CPersona persona = comparable as CPersona;
            return persona != null && dni == persona.dni;
        }

        public bool SosMenor(IComparable comparable)
        {
            CPersona persona = comparable as CPersona;
            return persona != null && dni < persona.dni;
        }

        public bool SosMayor(IComparable comparable)
        {
            CPersona persona = comparable as CPersona;
            return persona != null && dni > persona.dni;
        }

        public override string ToString()
        {
            return this.dni.ToString();
        }

        public string Nombre    
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public int Dni
        {
            get 
            {
                return dni;
            }
            set 
            {
                dni = value;
            }
        }
    }
}
