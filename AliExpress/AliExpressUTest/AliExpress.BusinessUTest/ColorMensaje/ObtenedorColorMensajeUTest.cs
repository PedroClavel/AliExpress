using AliExpress.ColorMensaje;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AliExpress.BusinessUTest.ColorMensaje
{
    /// <summary>
    /// Clase para las pruebas unitarias de la clase  ObtenedorColorMensajeUTest.
    /// </summary>
    [TestClass]
    public class ObtenedorColorMensajeUTest
    {
        [TestMethod]
        public void ObtenerColorMensaje_EntregagoConValorFalse_RetornaColorYellow()
        {
            //Arrange.
            var SUT = new ObtenedorColorMensaje();
            bool lEntregado = false;

            //Act.
            var colorMensaje = SUT.ObtenerColorMensaje(lEntregado);

            //Assert.
            Assert.AreEqual(ConsoleColor.Yellow, colorMensaje);
        }

        [TestMethod]
        public void ObtenerColorMensaje_EntregagoConValorTrue_RetornaColorGreen()
        {
            //Arrange.
            var SUT = new ObtenedorColorMensaje();
            bool lEntregado = true;

            //Act.
            var colorMensaje = SUT.ObtenerColorMensaje(lEntregado);

            //Assert.
            Assert.AreEqual(ConsoleColor.Green, colorMensaje);
        }
    }
}
