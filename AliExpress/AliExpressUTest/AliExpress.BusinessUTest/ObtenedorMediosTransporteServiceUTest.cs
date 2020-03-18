using Microsoft.VisualStudio.TestTools.UnitTesting;
using AliExpress.Business;
using AliExpress.Data.Entities.Enumeradores;

namespace AliExpress.BusinessUTest
{
    /// <summary>
    /// Descripción resumida de ObtenedorMediosTransporteServiceUTest
    /// </summary>
    [TestClass]
    public class ObtenedorMediosTransporteServiceUTest
    {
        [TestMethod]
        public void ObtenerMedioTransporte_TransporteMaritimo_RetornaTipoEnumeradorMaritimo()
        {
            //Arrange.
            var SUT = new ObtenedorMediosTransporteService();
            var cMedioTransporte = "marítimo";

            //Act.
            var eMedioTransporte = SUT.ObtenerMedioTransporte(cMedioTransporte);

            //Assert.
            Assert.AreEqual(eMediosTransporte.Maritimo, eMedioTransporte);
        }

        [TestMethod]
        public void ObtenerMedioTransporte_TransporteTerrestre_RetornaTipoEnumeradorTerrestre()
        {
            //Arrange.
            var SUT = new ObtenedorMediosTransporteService();
            var cMedioTransporte = "terrestre";

            //Act.
            var eMedioTransporte = SUT.ObtenerMedioTransporte(cMedioTransporte);

            //Assert.
            Assert.AreEqual(eMediosTransporte.Terrestre, eMedioTransporte);
        }

        [TestMethod]
        public void ObtenerMedioTransporte_TransporteAereo_RetornaTipoEnumeradorAereo()
        {
            //Arrange.
            var SUT = new ObtenedorMediosTransporteService();
            var cMedioTransporte = "aereo";

            //Act.
            var eMedioTransporte = SUT.ObtenerMedioTransporte(cMedioTransporte);

            //Assert.
            Assert.AreEqual(eMediosTransporte.Aereo, eMedioTransporte);
        }
    }
}
