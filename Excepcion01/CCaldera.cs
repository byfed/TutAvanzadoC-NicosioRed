using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepcion01
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

        //hacemos trabjar la caldera, sin usar excepciones
        //PRIMERA VERSION
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
        //        }
        //    }
        //}


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

        //            //lanzamos la excepción. Como parámetro se pasa un mnesaje con descripción del error.
        //            throw new Exception(string.Format("La caldera {0} se sobreclaiente", marca));
        //        }
        //    }
        //}

        //TERCERA VERSION
        //SEGUNDA VERSION
        public void Trabajar(int pAumento)
        {
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
                    Exception ex = new Exception(string.Format("La caldera {0} se sobreclaiente", marca));
                    ex.HelpLink = "http://www.google.es";
                    //datos propios
                    ex.Data.Add("Momento: ", string.Format("Ocurrio en {0}", DateTime.Now));
                    ex.Data.Add("Temperatural actual: ", string.Format("{0} grados", tempActual));
                    ex.Data.Add("Incremento: ", string.Format("{0}", pAumento));
                    throw ex;
                }
            }
        }
    }
}
