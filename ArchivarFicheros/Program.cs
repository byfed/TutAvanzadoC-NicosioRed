using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace ArchivarFicheros
{
    class Program
    {
        static void Main(string[] args)
        {
            //directorio Actual
            string currentDir = Directory.GetCurrentDirectory();
            DirectoryInfo curDir = new DirectoryInfo(currentDir);

            //Creación de directorio procesados (si no existe)
            string procesedDir = curDir + "\\procesados";
            if (!Directory.Exists(procesedDir))
            {
                DirectoryInfo procDir = Directory.CreateDirectory(procesedDir);
            }
            
            Console.WriteLine(currentDir);

            //Obtengo el nombre del ejecutable actual
            string fullName = Assembly.GetEntryAssembly().Location;
            string myName = Path.GetFileName(fullName);


            //copia ficheros y sobreescribe si existe
            string[] files = System.IO.Directory.GetFiles(curDir.FullName);
            foreach (string s in files)
            {
                // Use static Path methods to extract only the file name from the path.
                string fileName = System.IO.Path.GetFileName(s);
                //No copia el ejecutable actual
                if (fileName == myName) continue;
                string destFile = System.IO.Path.Combine(procesedDir, fileName);
                try
                {
                    System.IO.File.Move(s, destFile);
                    Console.WriteLine("{0}->{1} : OK ",fileName,destFile);
                } catch (Exception e)
                {
                    Console.WriteLine("{0}->{1} : KO ", fileName, destFile);
                }
                
            }
            Console.ReadKey(); 

        }
    }
}
