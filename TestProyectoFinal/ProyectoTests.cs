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
        public async void Probando_conversion_de_dolar_a_peso()
        {
            // ARRANGE
            decimal tasaCorrecta = StubBuscadorTasas.TASA_USD_DOP_POPULAR;
            IBuscadorTasas buscadorTasas = new StubBuscadorTasas();
            ConvertidorMoneda sut = new ConvertidorMoneda(buscadorTasas);

            // ACT
            decimal pesos = await sut.ConvertidorDolaresAPesos(20);

            // ASSERT
            Assert.Equal(20 * tasaCorrecta, pesos, 2);
            Assert.Equal(1, ((StubBuscadorTasas)buscadorTasas).cantidadDeLlamadasParaObtenerTasas);
        }

        [Fact]
        public async void Probando_conversion_de_peso_a_dolar()
        {
            // ARRANGE
            decimal tasaCorrecta = StubBuscadorTasas.TASA_USD_DOP_POPULAR;
            IBuscadorTasas buscadorTasas = new StubBuscadorTasas();
            ConvertidorMoneda sut = new ConvertidorMoneda(buscadorTasas);

            // ACT
            Transacciones transaccionInicial = new Transacciones(1, "Ingreso", "23145", "Pago Trabajo", 250, "DOP", "Pago de salario trabajo", DateTime.Now);
            Transacciones transaccionRespuesta = await sut.ConvertidorTransaccionesPesosADolares(transaccionInicial);

            // ASSERT
            Assert.Equal(transaccionRespuesta.Moneda, "USD");
            Assert.Equal(transaccionInicial.Monto / tasaCorrecta, transaccionRespuesta.Monto, 2);
            Assert.Equal(1, ((StubBuscadorTasas)buscadorTasas).cantidadDeLlamadasParaObtenerTasas);
        }
    }

    public class TestingCuenta
    {
        [Fact]
        public void Probando_Calcular_Balance()
        {
            // ARRANGE
            Cuentas sut = new Cuentas("123456789", "Cuenta de nomina", 0, "Corriente");
            Transacciones transaccion = new Transacciones(1, "Ingreso", "123456789", "Salario", 45000, "DOP", "Pago quincenal de nomina", DateTime.Now);

            // ACT
            sut.Transacciones.Add(transaccion);
            decimal balance = sut.calcularBalance();

            // ASSERT
            Assert.Equal(0, sut.Balance);
            Assert.Equal(45000, balance);
        }
    }

    public class TestingUsuario
    {
        [Fact]
        public void Probando_Agregar_Transaccion_Ingreso()
        {
            // ARRANGE
            Usuario sut = new Usuario();
            Cuentas cuenta = sut.crearCuenta("123456789", "Cuenta de nomina", 15000, "Corriente");
           
            // ACT
            sut.crearTransaccion("Ingreso", cuenta, "Salario", 45000, "DOP", "Pago quincenal de nomina", DateTime.Now);         

            // ASSERT
            Assert.Equal(60000, sut.cuentas[0].Balance);
        }

        [Fact]
        public void Probando_Agregar_Transaccion_Gasto()
        {
            // ARRANGE
            Usuario sut = new Usuario();
            Cuentas cuenta = sut.crearCuenta("123456789", "Cuenta de nomina", 15000, "Corriente");

            // ACT
            sut.crearTransaccion("Gasto", cuenta, "Salario", 15000, "DOP", "Pago quincenal de nomina", DateTime.Now);

            // ASSERT
            Assert.Equal(0, sut.cuentas[0].Balance);
        }

        [Fact]
        public void Probando_NoCuenta_tira_excepción_si_no_es_numérico()
        {
            // ARRANGE
            Usuario sut = new Usuario();

            // ACT & ASSERT 
            Assert.Throws <ArgumentException> (() => sut.crearCuenta("l644565", "Cuenta de nomina", 15000, "Corriente"));
        }
    }

}