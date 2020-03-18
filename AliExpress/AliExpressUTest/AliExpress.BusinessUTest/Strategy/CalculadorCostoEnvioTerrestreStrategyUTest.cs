using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AliExpress.Business.Strategy;
using AliExpress.Data.Entities.DTO;

namespace AliExpress.BusinessUTest.Strategy
{
    /// <summary>
    /// Descripción resumida de CalculadorCostoEnvioTerrestreStrategyUTest
    /// </summary>
    [TestClass]
    public class CalculadorCostoEnvioTerrestreStrategyUTest
    {
        [TestMethod]
        public void CalcularCostoEnvio_DistanciaIgual30_Retorna15()
        {
            //Arrange.
            var datosPedido = ObtenerDatosPedidoDTO(30);
            var SUT = new CalculadorCostoEnvioTerrestreStrategy();

            //Act.
            var dCosto = SUT.CalcularCostoEnvio(datosPedido);

            //Assert.
            Assert.AreEqual(15M, dCosto);
        }

        [TestMethod]
        public void CalcularCostoEnvio_DistanciaIgual100_Retorna10()
        {
            //Arrange.
            var datosPedido = ObtenerDatosPedidoDTO(100);
            var SUT = new CalculadorCostoEnvioTerrestreStrategy();

            //Act.
            var dCosto = SUT.CalcularCostoEnvio(datosPedido);

            //Assert.
            Assert.AreEqual(10M, dCosto);
        }

        [TestMethod]
        public void CalcularCostoEnvio_DistanciaIgual201_Retorna8()
        {
            //Arrange.
            var datosPedido = ObtenerDatosPedidoDTO(201);
            var SUT = new CalculadorCostoEnvioTerrestreStrategy();

            //Act.
            var dCosto = SUT.CalcularCostoEnvio(datosPedido);

            //Assert.
            Assert.AreEqual(8M, dCosto);
        }

        [TestMethod]
        public void CalcularCostoEnvio_DistanciaIgual1000_Retorna7()
        {
            //Arrange.
            var datosPedido = ObtenerDatosPedidoDTO(1000);
            var SUT = new CalculadorCostoEnvioTerrestreStrategy();

            //Act.
            var dCosto = SUT.CalcularCostoEnvio(datosPedido);

            //Assert.
            Assert.AreEqual(7M, dCosto);
        }

        /// <summary>
        /// Método privado para obtener los datos del pedido en la entidad de tipo DTO.
        /// </summary>
        /// <param name="dDistancia">Distancia del pedido.</param>
        /// <returns>Retorna la entidad de tipo DatosPedidoDTO.</returns>
        private DatosPedidoDTO ObtenerDatosPedidoDTO(decimal dDistancia)
        {
            var datosPedidoDTO = new DatosPedidoDTO();

            datosPedidoDTO.dDistancia = dDistancia;
            datosPedidoDTO.dtFechaHoraPedido = new DateTime(2020, 2, 22);

            return datosPedidoDTO;
        }
    }
}
