using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using AliExpress.Interfaces.Business;
using AliExpress.Business.Strategy;
using AliExpress.Data.Entities.DTO;
using AliExpress.Data.Entities.Enumeradores;

namespace AliExpress.BusinessUTest.Strategy
{
    /// <summary>
    /// Descripción resumida de CalculadorTiempoTrasladoMaritimoStrategyUTest
    /// </summary>
    [TestClass]
    public class CalculadorTiempoTrasladoMaritimoStrategyUTest
    {
        [TestMethod]
        public void CalculadorTiempoTrasladoMaritimoStrategy_InstanciaIObtenedorEstacionAnioNulo_RetornaExepcion()
        {
            //Arrange.
            Mock<IObtenedorVariacionVelocidadPorEstacionAnioService> docObtenedorVariacionVelocidadPorEstacionAnioService = new Mock<IObtenedorVariacionVelocidadPorEstacionAnioService>();
            Mock<ITruncadorDecimales> docTruncador = new Mock<ITruncadorDecimales>();

            //Assert.
            Assert.ThrowsException<ArgumentNullException>(() => new CalculadorTiempoTrasladoMaritimoStrategy(null, docObtenedorVariacionVelocidadPorEstacionAnioService.Object, docTruncador.Object));
        }

        [TestMethod]
        public void CalculadorTiempoTrasladoMaritimoStrategy_InstanciaIObtenedorVariacionVelocidadPorEstacionAnioServiceNulo_RetornaExepcion()
        {
            //Arrange.
            Mock<IObtenedorEstacionAnio> docObtenedorEstacion = new Mock<IObtenedorEstacionAnio>();
            Mock<ITruncadorDecimales> docTruncador = new Mock<ITruncadorDecimales>();

            //Assert.
            Assert.ThrowsException<ArgumentNullException>(() => new CalculadorTiempoTrasladoMaritimoStrategy(docObtenedorEstacion.Object, null, docTruncador.Object));
        }

        [TestMethod]
        public void CalculadorTiempoTrasladoMaritimoStrategy_InstanciaITruncadorDecimalesNulo_RetornaExepcion()
        {
            //Arrange.
            Mock<IObtenedorEstacionAnio> docObtenedorEstacion = new Mock<IObtenedorEstacionAnio>();
            Mock<IObtenedorVariacionVelocidadPorEstacionAnioService> docObtenedorVariacionVelocidadPorEstacionAnioService = new Mock<IObtenedorVariacionVelocidadPorEstacionAnioService>();

            //Assert.
            Assert.ThrowsException<ArgumentNullException>(() => new CalculadorTiempoTrasladoMaritimoStrategy(docObtenedorEstacion.Object, docObtenedorVariacionVelocidadPorEstacionAnioService.Object, null));
        }

        [TestMethod]
        public void ObtenerTiempoTraslado_()
        {
            //Arrange.
            Mock<IObtenedorEstacionAnio> docObtenedorEstacion = new Mock<IObtenedorEstacionAnio>();
            Mock<IObtenedorVariacionVelocidadPorEstacionAnioService> docObtenedorVariacionVelocidadPorEstacionAnioService = new Mock<IObtenedorVariacionVelocidadPorEstacionAnioService>();
            Mock<ITruncadorDecimales> docTruncador = new Mock<ITruncadorDecimales>();

            var datosPedido = ObtenerDatosPedidoDTO();

            docObtenedorEstacion.Setup(doc => doc.ObtenerEstacionAnio(It.IsAny<DateTime>())).Returns(eEstacionesAnio.Invierno);

            docObtenedorVariacionVelocidadPorEstacionAnioService.Setup(doc => doc.ObtenerVariacionVelocidad(It.IsAny<eEstacionesAnio>())).Returns(-30);

            docTruncador.Setup(doc => doc.TruncarNumero(It.IsAny<decimal>())).Returns(37.2M);

            var SUT = new CalculadorTiempoTrasladoMaritimoStrategy(docObtenedorEstacion.Object, docObtenedorVariacionVelocidadPorEstacionAnioService.Object, docTruncador.Object);

            //Act.
            var dTiempoTraslado = SUT.ObtenerTiempoTraslado(datosPedido);

            //Assert.
            Assert.AreEqual(37.2M, dTiempoTraslado);
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
