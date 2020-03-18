using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AliExpress.Business.Strategy;
using AliExpress.Data.Entities.DTO;

namespace AliExpress.BusinessUTest.Strategy
{
    /// <summary>
    /// Descripción resumida de CalculadorCostoEnvioAereoStrategyUTest
    /// </summary>
    [TestClass]
    public class CalculadorCostoEnvioAereoStrategyUTest
    {
        [TestMethod]
        public void CalcularCostoEnvio_ParametroDatosPedidoDTONulo_RetornaExcepcion()
        {
            //Arrange.           
            var SUT = new CalculadorCostoEnvioAereoStrategy();

            //Assert.
            Assert.ThrowsException<ArgumentNullException>(() => SUT.CalcularCostoEnvio(null));
        }

        [TestMethod]
        public void CalcularCostoEnvio_Distancia1200KM_RetornaCosto12200()
        {
            //Arrange.
            var SUT = new CalculadorCostoEnvioAereoStrategy();
            var datosPedido = ObtenerDatosPedidoDTO(1200);

            //Act.
            var dCosto = SUT.CalcularCostoEnvio(datosPedido);

            //Assert.
            Assert.AreEqual(12200, dCosto);
        }

        [TestMethod]
        public void CalcularCostoEnvio_Distancia550KM_RetornaCosto5500()
        {
            //Arrange.
            var SUT = new CalculadorCostoEnvioAereoStrategy();
            var datosPedido = ObtenerDatosPedidoDTO(550M);

            //Act.
            var dCosto = SUT.CalcularCostoEnvio(datosPedido);

            //Assert.
            Assert.AreEqual(5500, dCosto);
        }

        /// <summary>
        /// Método privado para obtener los datos del pedido en la entidad de tipo DTO.
        /// </summary>
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