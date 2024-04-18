using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPractico_Integral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CPila pila1 = new CPila();
            CCola cola = new CCola();
            CColeccionMultiple multiple = new CColeccionMultiple(pila1, cola);

            Console.WriteLine(" está utilizando llenarAlumnos en la pila");
            llenarAlumnos(pila1);
            Console.WriteLine(" está utilizando llenarAlumnos en la cola");
            llenarAlumnos(cola);
            Console.WriteLine(" informando multiple ");
            informar(multiple);

            Console.WriteLine("Presione para continuar . . .");
            Console.ReadKey(true);
        }

        //ejercicio 5
        public static void llenar(IColeccionable coleccionable)
        {

            Random random = new Random();
            for (int i = 1; i <= 20; i++)
            {
                coleccionable.agregar(new CNumero(random.Next(100)));
            }
        }

        public static void informar(IColeccionable coleccionable)
        {
            Console.WriteLine(coleccionable.cuantos() + " esto es cuantos ");
            Console.WriteLine(coleccionable.minimo() + " esto es  minimo ");
            Console.WriteLine(coleccionable.maximo() + " esto es maximo ");

            Console.WriteLine("ingrese un numero para verificar si existe en la lista: ");
            IComparable elemento = new CNumero(int.Parse(Console.ReadLine()));

            if (coleccionable.contiene(elemento))
            {
                Console.WriteLine("El elemento leido está en la colección ");
            }
            else
            {
                Console.WriteLine("El elemento leido no está en la colección ");
            }
        }

        public static void llenarPersonas(IColeccionable coleccionable)
        {

            Random random = new Random();
            string nombre = "";
            int dni = 0;
            string[] nombres = { "Juan", "Ana", "Carlos", "Maria", "Pedro",
                                "Laura", "Jose", "Sofia", "Miguel", "Lucia" };
            CPersona persona = new CPersona(nombre, dni);

            for (int i = 1; i <= 20; i++)
            {

                persona.Nombre = nombres[random.Next(nombres.Length)];
                persona.Dni = random.Next(10000000, 99999999);
                CPersona comparable = new CPersona(persona.Nombre, persona.Dni);
                coleccionable.agregar(comparable);

            }
        }

        public static void llenarAlumnos(IColeccionable coleccionable)
        {
            Random random = new Random();
            string nombre = "";
            int dni = 0;
            int legajo = 0;
            double promedio = 0;
            string[] nombres = { "Juan", "Ana", "Carlos", "Maria", "Pedro",
                                "Laura", "Jose", "Sofia", "Miguel", "Lucia" };
            CAlumno alumno = new CAlumno(nombre, dni, legajo, promedio);

            for (int i = 0; i < 20; i++)
            {
                string Nombre = nombres[random.Next(nombres.Length)];
                int Dni = random.Next(10000000, 99999999);
                int Legajo = random.Next(1000, 9999);
                double Promedio = random.NextDouble() * (10.0 - 1.0) + 1.0;
                CAlumno comparable = new CAlumno(Nombre, Dni, Legajo, Promedio);
                coleccionable.agregar(comparable);
            }

        }

    }
}