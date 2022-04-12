using System;
using RepasoPersona.Core;
using Xunit;

namespace RepasoPersona.test
{
    public class CuentaTest
    {
        public Cuenta Uala { get; set; }

        public CuentaTest() => Uala = new Cuenta(000010, 0);

        [Fact]
        public void Constructor()
        {
            Assert.Equal(000010, Uala.CBU);
        }

        [Fact]
        public void AcreditarPositivo()
        {
            double esperado = 1000;
            Uala.Acreditar(esperado);
            
            Assert.Equal(esperado, Uala.Saldo, 3);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-157.34)]
        public void AcreditarCeroONegativo(double monto)
        {
            var ex = Assert.Throws<ArgumentException>(() => Uala.Acreditar(0));
            Assert.Equal("El monto tiene que ser mayor a cero.", ex.Message);
        }

        [Fact]
        public void Debitar()
        {
            double monto = 500.45;
            double debito = 135.45;
            Uala.Acreditar(monto);
            Uala.Debitar(debito);

            Assert.Equal(monto - debito, Uala.Saldo, 2);
        }

        [Fact]
        public void DebitarInsuficiente()
        {
            var ex = Assert.Throws<InvalidOperationException>(() => Uala.Debitar(1000));
            Assert.Equal("El monto supera al efectivo.", ex.Message);
        }
    }
}