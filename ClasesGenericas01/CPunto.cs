using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGenericas01
{
    //Ojo a la declaración de la clase, especificando el tipo con el que va a trabajar
    class CPunto<T>
    {
        //Se han añadido dos atributos genéricos, aunque podría haber otro de tipos "normales"
        private T x;
        private T y;

        //Constructor, usando el tipo genérico que se asignarán a los atributos.
        public CPunto(T px, T py)
        {
            x = px;
            y = py;
        }

        public override string ToString()
        {
            //x e Y deberán tener su propio ToString
            return string.Format("x={0}, y={1}", x, y);
        }

        public void Reset()
        {
            //para asignar un valor por defecto al tipo, tenemos que usar default. En tiempo de programación no se conoce, pero en tiempo
            //de ejecución sí. Por ejemplo, para un tipo int, dará un cero, para un string, una cadena vacía, etc.
            x = default(T);
            y = default(T);
        }

        public void EncuentraTipo()
        {
            //Para saber qué tipo estamos usando , utilizamos typeof(T)
            if (typeof(T) == typeof(int))
            {
                Console.WriteLine("Trabajo como entero");
            } else
            {
                Console.WriteLine("Trabajo como otro tipo");
            }
        }
    }
}
