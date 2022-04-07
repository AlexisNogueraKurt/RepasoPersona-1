using System;
using System.Collections.Generic;


namespace RepasoPersona.Core
{
    public class EnteConSaldo
    {
        public virtual double Saldo { get; set; }
        public void Debitar(double monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto tiene que ser mayor a cero.");

            if (monto > Saldo)
                throw new InvalidOperationException("El monto supera al efectivo.");
            Saldo -= monto;
        }
        public void Acreditar(double monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto tiene que ser mayor a cero.");
            Saldo += monto;
        }
        
    }
}