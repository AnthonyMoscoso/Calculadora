//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Calculadora.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ecuacion
    {
        public int IdEcuacion { get; set; }
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public double Result { get; set; }
        public string Operador { get; set; }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}={3}",Num1,Operador,Num2,Result);
        }
    }
}
