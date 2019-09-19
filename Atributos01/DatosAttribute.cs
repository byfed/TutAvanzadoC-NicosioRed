using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributos01
{
    //La clase debe ser publica y sellada
    //Este atributo guarda el dato s en el assembly
    //Para que una clase sea un atributo, tiene que heredad de System.Attribute
    public sealed class DatosAttribute: System.Attribute
    {
        string dato = "";
        public string Dato { get { return dato; } set { dato = value; } }

        public DatosAttribute()
        {
            //Constructor vacío
        }

        public DatosAttribute (string pDato)
        {
            dato = pDato;
        }

        //Este enumerado permite determinar en qué elementos se pueden usar los atributos
        //public enum AttributeTargets
        //{
        //    All, Assembly, Class, Constructor, Delegate, Enum, Event, Field, GenericParameter, 
        //    Interface, Method, Module, Parameter, Property, ReturnValue, Struct
        //}
        //Esto se colocaría justo antes de la definición de la clase (antes del public sealed class)
        //[AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct)]


    }
}
