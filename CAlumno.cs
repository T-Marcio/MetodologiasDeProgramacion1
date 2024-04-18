using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPractico_Integral
{
    public class CAlumno: CPersona, IComparable
    {
        private int legajo;
        private double promedio;

        public CAlumno(string nombre, int dni, int legajo, double promedio) : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
        }

        public int getLegajo()
        {
            return legajo;
        }

        public double getPromedio() 
        {
            return promedio;
        }

        public bool  SosIgual(IComparable comparable)
        {
            CAlumno alumno = comparable as CAlumno;
            return alumno != null && legajo == alumno.legajo;
        }
        public bool SosMenor(IComparable comparable)
        {
            CAlumno alumno = comparable as CAlumno;
            return alumno != null && legajo < alumno.legajo;
        }
        public bool SosMayor(IComparable comparable)
        {
            CAlumno alumno = comparable as CAlumno;
            return alumno != null && legajo > alumno.legajo;
        }

        public int Legajo
        {
            get
            {
                return legajo;
            }

            set 
            {
                legajo = value;
            }
        }

        public double Promedio
        {
            get 
            {
                return promedio;
            } 
            set 
            {
                promedio = value;
            }
        }

    }
}
