using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmeticaAtributos
{
    //Este atributo es el que vamos a definir en el ejemplo
    [Datos("Mi clase de matematicas")]
    public class MisMates
    {
        private double a;
        private double b;
        private double r;

        public MisMates(double pA, double PB)
        {
            a = pA;
            b = PB;
            r = 0;
        }

        public double R { get { return r; } }

        public double suma()
        {
            r = a + b;
            return r;
        }
    }


    [Datos("Clase de prueba 1")]
    class CPrueba
    {
        public CPrueba()
        {
            Console.WriteLine("Version 1");
        }
    }


    [Datos("Clase de prueba 2")]
    class CPrueba2
    {
        public CPrueba2()
        {
            Console.WriteLine("Version 1");
        }
    }

    //Clase para el atributo
    public sealed class DatosAttribute : System.Attribute
    {
        string dato = "";
        public string Dato { get { return dato; } set { dato = value; } }

        public DatosAttribute(string pDato)
        {
            dato = pDato;
        }
    }



}

