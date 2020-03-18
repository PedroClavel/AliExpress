using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AliExpress.Interfaces.Business;
using Moq;
using AliExpress.Business.Strategy;
using AliExpress.Data.Entities.DTO;
using AliExpress.Data.Entities.Enumeradores;

namespace AliExpress.BusinessUTest.Strategy
{
    /// <summary>
    /// Descripción resumida de CalculadorTiempoTrasladoTerrestreStrategyUTest
    /// </summary>
    [TestClass]
    public class CalculadorTiempoTrasladoTerrestreStrategyUTest
    {
        [TestMethod]
        public void CalculadorTiempoTrasladoMaritimoStrategy_InstanciaIObtenedorEstacionAnioNulo_RetornaExepcion()
        {
            //Arrange.
            Mock<IObtenedorDescansoDiarioPorEstacionAnioService> docObtenedorDescansoDiarioPorEstacionAnioService = new Mock<IObtenedorDescansoDiarioPorEstacionAnioService>();
            Mock<ITruncadorDecimales> docTruncador = new Mock<ITruncadorDecimales>();

            //Assert.
            Assert.ThrowsException<ArgumentNullException>(() => new CalculadorTiempoTrasladoTerrestreStrategy(null, docObtenedorDescansoDiarioPorEstacionAnioService.Object, docTruncador.Object));
        }

        [TestMethod]
        public void CalculadorTiempoTrasladoMaritimoStrategy_InstanciaIObtenedorDescansoDiarioPorEstacionAnioServiceNulo_RetornaExepcion()
        {
            //Arrange.
            Mock<IObtenedorEstacionAnio> docObtenedorEstacionAnio = new Mock<IObtenedorEstacionAnio>();
            Mock<ITruncadorDecimales> docTruncador = new Mock<ITruncadorDecimales>();

            //Assert.
            Assert.ThrowsException<ArgumentNullException>(() => new CalculadorTiempoTrasladoTerrestreStrategy(docObtenedorEstacionAnio.Object, null, docTruncador.Object));
        }

        [TestMethod]
        public void CalculadorTiempoTrasladoMaritimoStrategy_InstanciaITruncadorDecimalesNulo_RetornaExepcion()
        {
            //Arrange.
            Mock<IObtenedorDescansoDiarioPorEstacionAnioService> docObtenedorDescansoDiarioPorEstacionAnioService = new Mock<IObtenedorDescansoDiarioPorEstacionAnioService>();
            Mock<IObtenedorEstacionAnio> docObtenedorEstacionAnio = new Mock<IObtenedorEstacionAnio>();

            //Assert.
            Assert.ThrowsException<ArgumentNullException>(() => new CalculadorTiempoTrasladoTerrestreStrategy(docObtenedorEstacionAnio.Object, docObtenedorDescansoDiarioPorEstacionAnioService.Object, null));
        }

        [TestMethod]
        public void ObtenerTiempoTraslado_EstacionInvierno_Retorna8()
        {
            //Arrange.
            Mock<IObtenedorDescansoDiarioPorEstacionAnioService> docObtenedorDescansoDiarioPorEstacionAnioService = new Mock<IObtenedorDescansoDiarioPorEstacionAnioService>();
            Mock<IObtenedorEstacionAnio> docObtenedorEstacionAnio = new Mock<IObtenedorEstacionAnio>();
            Mock<ITruncadorDecimales> docTruncador = new Mock<ITruncadorDecimales>();
            var datosPedido = ObtenerDatosPedidoDTO();

            docObtenedorEstacionAnio.Setup(doc => doc.ObtenerEstacionAnio(It.IsAny<DateTime>())).Returns(eEstacionesAnio.Invierno);
            docObtenedorDescansoDiarioPorEstacionAnioService.Setup(doc => doc.ObtenerDescansoDiario(It.IsAny<eEstacionesAnio>())).Returns(8);
            docTruncador.Setup(doc => doc.TruncarNumero(It.IsAny<decimal>())).Returns(8);

            var SUT = new CalculadorTiempoTrasladoTerrestreStrategy(docObtenedorEstacionAnio.Object, docObtenedorDescansoDiarioPorEstacionAnioService.Object, docTruncador.Object);

            //Act.
            var dTiempoTraslado = SUT.ObtenerTiempoTraslado(datosPedido);

            //Assert.
            Assert.AreEqual(8 ,dTiempoTraslado);
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
