using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepcion02
{
    class CCaldera
    {
        private int tempMax = 120;
        private int tempActual = 0;
        private string marca = "";
        private bool funciona = true;

        public int Temperatura
        {
            get { return tempActual; }
            set { tempActual = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value;  }

        }

        public bool Funciona
        {
            get { return funciona; }
        }

        public CCaldera(string pMarca, int pTemp)
        {
            tempActual = pTemp;
            marca = pMarca;
        }


        //SEGUNDA VERSION
        //public void Trabajar(int pAumento)
        //{
        //    if (!funciona)
        //        Console.WriteLine("La caldera {0} no funciona", marca);
        //    else
        //    {
        //        tempActual += pAumento;
        //        Console.WriteLine("La temperatura actual es {0}", tempActual);

        //        if (tempActual > tempMax)
        //        {
        //            Console.WriteLine("{0} supero la temperatura, tiene {1}", marca, tempActual);
        //            tempActual = tempMax;
        //            funciona = false;

        //            Creamos una instancia de la excepción en lugar de lanzarla directamente:
        //            CalderaExcepcion ex = new CalderaExcepcion(
        //                                       string.Format("La caldera {0} se sobreclaiente", marca),
        //                                       "Ha trabajado demasiado tiempo",
        //                                       DateTime.Now
        //                                       );

        //            ex.HelpLink = "http://www.google.es";
        //            datos propios
        //            ex.Data.Add("Momento: ", string.Format("Ocurrio en {0}", DateTime.Now));
        //            ex.Data.Add("Temperatural actual: ", string.Format("{0} grados", tempActual));
        //            ex.Data.Add("Incremento: ", string.Format("{0}", pAumento));

        //            throw ex;
        //        }
        //    }
        //}
        public void Trabajar(int pAumento)
        {
            //Excepcion para afgumento inválido
            if (pAumento < 0)
                //se usa para parámetros fuera de rango válido
                throw new ArgumentOutOfRangeException("Aumento", "El aumento no puede ser negativo");

            if (!funciona)
                Console.WriteLine("La caldera {0} no funciona", marca);
            else
            {
                tempActual += pAumento;
                Console.WriteLine("La temperatura actual es {0}", tempActual);

                if (tempActual > tempMax)
                {
                    Console.WriteLine("{0} supero la temperatura, tiene {1}", marca, tempActual);
                    tempActual = tempMax;
                    funciona = false;

                    //Creamos una instancia de la excepción en lugar de lanzarla directamente:
                    CalderaExcepcion ex = new CalderaExcepcion(
                                               string.Format("La caldera {0} se sobreclaiente", marca),
                                               "Ha trabajado demasiado tiempo",
                                               DateTime.Now
                                               );

                    ex.HelpLink = "http://www.google.es";
                    throw ex;
                }
            }
        }


    } // aquí finaliza la clase caldera
    //aquí creamos nuestra excepción de aplicación (debe tener acceso público)
    //VERSION 1
    //public class CalderaExcepcion : ApplicationException
    //{
    //    private string mensaje = "";
    //    private DateTime momento;
    //    private string causa;

    //    public DateTime Momento { get { return momento; } set { momento = value; } }
    //    public string Causa {  get { return causa; } set { causa = value; } }

    //    public CalderaExcepcion (string pMensaje, string pCausa, DateTime pMomento)
    //    {
    //        mensaje = pMensaje;
    //        causa = pCausa;
    //        momento = pMomento;
    //    }

    //    //override de Exception.Message
    //    public override string Message
    //    {
    //        get
    //        {
    //            return string.Format("Mensaje de excepción -> {0}", mensaje);
    //        }
    //    }
    //}

    //VERSION SEGUNDA
    public class CalderaExcepcion : ApplicationException
    {
        //En esta ocasión no creamos el mensaje, sino que lo metemos en la case base
        private DateTime momento;
        private string causa;

        public DateTime Momento { get { return momento; } set { momento = value; } }
        public string Causa { get { return causa; } set { causa = value; } }

        public CalderaExcepcion(string pMensaje, string pCausa, DateTime pMomento) : base(pMensaje)
        {
            causa = pCausa;
            momento = pMomento;
        }
    }


    //VERSION TERCERA
    //Esta es la forma estándar de .NET de definir excpecioens.
    //Dervidar de exception/ApplicationException
    //usar [System.serializable]
    //Definir constructor de default
    //Definir constructor que maneja excepciones internas
    //Definir constructor que maneja la serialización del tipo


    //[Serializable]
    //public class CalderaExcepcion : ApplicationException
    //{
    //    public CalderaExcepcion() { }
    //    public CalderaExcepcion(string pMensaje) : base(pMensaje) { }
    //    public CalderaExcepcion(string pMensaje, System.Exception inner) : base(pMensaje, inner) { }

    //    protected CalderaExcepcion(
    //        System.Runtime.Serialization.SerializationInfo info,
    //        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

    //    //Propiedades adiconales
    //    private DateTime momento;
    //    private string causa;

    //    public DateTime Momento { get { return momento; } set { momento = value; } }
    //    public string Causa { get { return causa; } set { causa = value; } }

    //    public CalderaExcepcion(string pMensaje, string pCausa, DateTime pMomento) : base(pMensaje)
    //    {
    //        causa = pCausa;
    //        momento = pMomento;
    //    }

    //}
}
