using System;

namespace RepasoPersona.Core
{
    public class EnteConSaldo
    {
        public virtual double saldo {get; private set;}
        public EnteConSaldo() => saldo = 0;
        public EnteConSaldo(double Efectivo)
        {
            Efectivo = saldo;
        }
        public void Debitar(double monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto tiene que ser mayor a cero.");

            if (monto > saldo)
                throw new InvalidOperationException("El monto supera al efectivo.");
            saldo -= monto;
        }
        public void Acreditar(double monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto tiene que ser mayor a cero.");
            saldo += monto;
        }
        
    }
}