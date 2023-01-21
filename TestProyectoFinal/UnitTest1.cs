using Xunit;
using System.Collections.Generic;
using System;
using ProyectoFinal_Grupo7_IDS326;
using ProyectoFinal_Grupo7_IDS326.Models;

namespace TestProyectoFinal
{
    public class StubBuscadorTasas : IBuscadorTasas
    {
        public const decimal TASA_USD_DOP_POPULAR = 55.5m;
        public const decimal TASA_DOP_USD_POPULAR = 45.6m;

        public int cantidadDeLlamadasParaObtenerTasas = 0;
        public async Task<List<Tasa>> ObtenerTasas()
        {
            cantidadDeLlamadasParaObtenerTasas++;
            List<Tasa> tasas = new List<Tasa>();
            tasas.Add(new Tasa(TASA_USD_DOP_POPULAR, "USD", "DOP", "Banco Popular"));
            tasas.Add(new Tasa(TASA_DOP_USD_POPULAR, "DOP", "USD", "Banco Popular"));
            return tasas;
        }
    }

    public class TestingConvertidorDeMoneda
    {
        [Fact]
        public async void Probando_una_compra_de_dolares_en_el_popular()
        {
            // ARRANGE
            decimal tasaCorrecta = StubBuscadorTasas.TASA_DOP_USD_POPULAR;
            IBuscadorTasas buscadorTasas = new StubBuscadorTasas();
            ConvertidorMoneda sut = new ConvertidorMoneda(buscadorTasas);

            // ACT
            decimal dolares = await sut.ConvertidorDolaresAPesos(20);

            // ASSERT
            Assert.Equal(20 / tasaCorrecta, dolares, 2);
            Assert.Equal(1, ((StubBuscadorTasas)buscadorTasas).cantidadDeLlamadasParaObtenerTasas);
        }

        //[Theory]
        //[InlineData(300)]
        //[InlineData(123)]
        //[InlineData(456)]
        //[InlineData(427)]
        //[InlineData(564)]
        //public void Probando_varias_compras_de_dolares_en_el_popular(float pesos)
        //{
        //    // ARRANGE
        //    decimal tasaCorrecta = StubBuscadorTasas.TASA_DOP_USD_POPULAR;
        //    IBuscadorTasas buscadorTasas = new StubBuscadorTasas();
        //    ConvertidorMoneda sut = new ConvertidorMoneda(buscadorTasas);

        //    // ACT
        //    decimal dolares = await sut.ComprarDolaresEnElPopular(pesos);

        //    // ASSERT
        //    Assert.Equal(pesos / tasaCorrecta, dolares, 2);
        //    Assert.Equal(1, ((StubBuscadorTasas)buscadorTasas).cantidadDeLlamadasParaObtenerTasas);
        //}
    }

    public class TestingCuenta
    {
        [Fact]
        public async void Probando_Calcular_Balance()
        {
            // ARRANGE
            Cuentas cuentas = new Cuentas("123456789", "Cuenta de nomina", 0, "Corriente");
            Transacciones transaccion = new Transacciones(1, "Ingreso", "123456789", "Salario", 45000, "DOP", "Pago quincenal de nomina", DateTime.Now);
            cuentas.Transacciones.Add(transaccion);

            // ACT
            decimal balance = cuentas.calcularBalance();

            // ASSERT
            Assert.Equal(45000, cuentas.Balance);
            Assert.Equal(45000, balance);
        }
    }
}