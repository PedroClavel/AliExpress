using AliExpress.Business.Strategy;
using AliExpress.Data.Entities.DTO;
using AliExpress.Data.Entities.Enumeradores;
using AliExpress.Interfaces.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace AliExpress.BusinessUTest.Strategy
{
    /// <summary>
    /// Descripción resumida de CalculadorCostoEnvioMaritimoStrategyUTest
    /// </summary>
    [TestClass]
    public class CalculadorCostoEnvioMaritimoStrategyUTest
    {       
        [TestMethod]
        public void CalculadorCostoEnvioMaritimoStrategy_InstanciaIObtenedorEstacionAnioNulo_RetornaExcepcion()
        {
            //Arrange.
            Mock<IObtenedorVariacionCostoPorEstacionAnioService> docObtenedorVariacionCostoPorEstacionAnioService = new Mock<IObtenedorVariacionCostoPorEstacionAnioService>();

            //Assert.
            Assert.ThrowsException<ArgumentNullException>(() => new CalculadorCostoEnvioMaritimoStrategy(null, docObtenedorVariacionCostoPorEstacionAnioService.Object));
        }

        [TestMethod]
        public void CalculadorCostoEnvioMaritimoStrategy_InstanciaIObtenedorVariacionCostoPorEstacionAnioServiceNulo_RetornaExcepcion()
        {
            //Arrange.
            Mock<IObtenedorEstacionAnio> docObtenedorEstacionAnio = new Mock<IObtenedorEstacionAnio>();

            //Assert.
            Assert.ThrowsException<ArgumentNullException>(() => new CalculadorCostoEnvioMaritimoStrategy(docObtenedorEstacionAnio.Object, null));
        }

        [TestMethod]
        public void CalcularCostoEnvio_ParametroDatosPedidoDTONulo_RetornaExcepcion()
        {
            //Arrange.
            Mock<IObtenedorEstacionAnio> docObtenedorEstacionAnio = new Mock<IObtenedorEstacionAnio>();
            Mock<IObtenedorVariacionCostoPorEstacionAnioService> docObtenedorVariacionCostoPorEstacionAnioService = new Mock<IObtenedorVariacionCostoPorEstacionAnioService>();

            var SUT = new CalculadorCostoEnvioMaritimoStrategy(docObtenedorEstacionAnio.Object, docObtenedorVariacionCostoPorEstacionAnioService.Object);

            //Assert.
            Assert.ThrowsException<ArgumentNullException>(() => SUT.CalcularCostoEnvio(null));
        }

        [TestMethod]
        public void CalcularCostoEnvio_EstacionInvierno_RetornaExcepcion()
        {
            //Arrange.
            Mock<IObtenedorEstacionAnio> docObtenedorEstacionAnio = new Mock<IObtenedorEstacionAnio>();
            Mock<IObtenedorVariacionCostoPorEstacionAnioService> docObtenedorVariacionCostoPorEstacionAnioService = new Mock<IObtenedorVariacionCostoPorEstacionAnioService>();
            var datosPedido = ObtenerDatosPedidoDTO();

            docObtenedorEstacionAnio.Setup(doc => doc.ObtenerEstacionAnio(It.IsAny<DateTime>())).Returns(eEstacionesAnio.Invierno);
            docObtenedorVariacionCostoPorEstacionAnioService.Setup(doc => doc.ObtenerVariacionCosto(It.IsAny<eEstacionesAnio>())).Returns(23);

            var SUT = new CalculadorCostoEnvioMaritimoStrategy(docObtenedorEstacionAnio.Object, docObtenedorVariacionCostoPorEstacionAnioService.Object);

            //Act.
            var dCostoEnvio = SUT.CalcularCostoEnvio(datosPedido);

            //Assert.
            Assert.AreEqual(442.8M, dCostoEnvio);
        }

        /// <summary>
        /// Método privado para obtener los datos del pedido en la entidad de tipo DTO.
        /// </summary>
        /// <returns>Retorna la entidad de tipo DatosPedidoDTO.</returns>
        private DatosPedidoDTO ObtenerDatosPedidoDTO()
        {
            var datosPedidoDTO = new DatosPedidoDTO();

            datosPedidoDTO.dDistancia = 1200;
            datosPedidoDTO.dtFechaHoraPedido = new DateTime(2020, 2, 22);

            return datosPedidoDTO;
        }
    }
}
