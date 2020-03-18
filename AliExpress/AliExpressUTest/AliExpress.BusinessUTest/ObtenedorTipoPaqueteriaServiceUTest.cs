using Microsoft.VisualStudio.TestTools.UnitTesting;
using AliExpress.Business;
using AliExpress.Data.Entities.Enumeradores;

namespace AliExpress.BusinessUTest
{
    /// <summary>
    /// Descripción resumida de ObtenedorTipoPaqueteriaServiceUTest
    /// </summary>
    [TestClass]
    public class ObtenedorTipoPaqueteriaServiceUTest
    {
        [TestMethod]
        public void ObtenerTipoPaqueteria_cNombreDHL_RetornaEnumeradorDHL()
        {
            //Arrange.
            var cNombrePaqueteria = "DHL";
            var SUT = new ObtenedorTipoPaqueteriaService();

            //Act.
            var ePaqueterias = SUT.ObtenerTipoPaqueteria(cNombrePaqueteria);

            //Assert.
            Assert.AreEqual(ePaqueteria.DHL, ePaqueterias);
        }

        [TestMethod]
        public void ObtenerTipoPaqueteria_cNombreESTAFETA_RetornaEnumeradorESTAFETA()
        {
            //Arrange.
            var cNombrePaqueteria = "estafeta";
            var SUT = new ObtenedorTipoPaqueteriaService();

            //Act.
            var ePaqueterias = SUT.ObtenerTipoPaqueteria(cNombrePaqueteria);

            //Assert.
            Assert.AreEqual(ePaqueteria.Estafeta, ePaqueterias);
        }

        [TestMethod]
        public void ObtenerTipoPaqueteria_cNombreFEDEX_RetornaEnumeradorFEDEX()
        {
            //Arrange.
            var cNombrePaqueteria = "fedex";
            var SUT = new ObtenedorTipoPaqueteriaService();

            //Act.
            var ePaqueterias = SUT.ObtenerTipoPaqueteria(cNombrePaqueteria);

            //Assert.
            Assert.AreEqual(ePaqueteria.Fedex, ePaqueterias);
        }
    }
}
