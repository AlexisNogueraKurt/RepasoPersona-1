using System;
using System.Collections.Generic;
namespace RepasoPersona.Core
{
    public class Persona : EnteConSaldo
    {
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public double Efectivo { get; private set; }
        public int Dni {get; private set;}
        public Persona() => Efectivo = 0;
        public Persona(string nombre, string apellido, double efectivo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Efectivo = efectivo;
        } 
        List<Cuenta> cuenta = new List<Cuenta>();
    }
}
