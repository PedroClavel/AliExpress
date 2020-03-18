using Microsoft.VisualStudio.TestTools.UnitTesting;
using AliExpress.Data.Entities.Enumeradores;
using AliExpress.Business;

namespace AliExpress.BusinessUTest
{
    /// <summary>
    /// Descripción resumida de ObtenedorVariacionCostoPorEstacionAnioServiceUTest
    /// </summary>
    [TestClass]
    public class ObtenedorVariacionCostoPorEstacionAnioServiceUTest

    {
        [TestMethod]
        public void ObtenerVariacionCosto_EstacionInverno_Retorna23()
        {
            //Arrange.
            var SUT = new ObtenedorVariacionCostoPorEstacionAnioService();

            //Act.
            var iVariacion = SUT.ObtenerVariacionCosto(eEstacionesAnio.Invierno);

            //Assert.
            Assert.AreEqual(23, iVariacion);
        }

        [TestMethod]
        public void ObtenerVariacionCosto_EstacionPrimavera_Retorna0()
        {
            //Arrange.
            var SUT = new ObtenedorVariacionCostoPorEstacionAnioService();

            //Act.
            var iVariacion = SUT.ObtenerVariacionCosto(eEstacionesAnio.Primavera);

            //Assert.
            Assert.AreEqual(0, iVariacion);
        }

        [TestMethod]
        public void ObtenerVariacionCosto_EstacionOtonio_Retorna15()
        {
            //Arrange.
            var SUT = new ObtenedorVariacionCostoPorEstacionAnioService();

            //Act.
            var iVariacion = SUT.ObtenerVariacionCosto(eEstacionesAnio.Otonio);

            //Assert.
            Assert.AreEqual(15, iVariacion);
        }

        [TestMethod]
        public void ObtenerVariacionCosto_EstacionVerano_Retorna10()
        {
            //Arrange.
            var SUT = new ObtenedorVariacionCostoPorEstacionAnioService();

            //Act.
            var iVariacion = SUT.ObtenerVariacionCosto(eEstacionesAnio.Verano);

            //Assert.
            Assert.AreEqual(10, iVariacion);
        }
    }
}
