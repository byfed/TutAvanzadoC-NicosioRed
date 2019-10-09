using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic01
{
    class CConDynamic
    {
        //atributo dinamico
        private dynamic atributo;

        //propiedad dinámica
        public dynamic propiedad
        {
            get { return atributo; }
            set { atributo = value; }
        }

        public void imprime()
        {
            Console.WriteLine(atributo);
        }
        //Metdo que recibe un parámetro dinámico
        public void recibe(dynamic parametro)
        {
            Console.WriteLine("REcibi {0}",parametro);
        }

        //Funcion que devuelve un dinámico
        public dynamic regresa (int a)
        {
            if (a < 0)
                return 5;
            else
                return "positivo";
        }
    }
}
