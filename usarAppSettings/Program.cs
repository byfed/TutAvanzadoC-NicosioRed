using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//este namespace permite acceder al appSettingsReader
using System.Configuration;

namespace usarAppSettings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Editamos el app.config y lo leemos desde la aplicación

            //objeto lector
            AppSettingsReader lector = new AppSettingsReader();

            string nombre = (string)lector.GetValue("Nombre", typeof(string));
            int edad = (int)lector.GetValue("Edad", typeof(int));

            Console.WriteLine("{0} tiene {1} años de edad",nombre,edad);

            Console.ReadKey();
        }
    }
}
