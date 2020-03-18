using Microsoft.VisualStudio.TestTools.UnitTesting;
using AliExpress.Business;
using AliExpress.Data.Entities.Enumeradores;

namespace AliExpress.BusinessUTest.Strategy
{
    /// <summary>
    /// Descripción resumida de ObtenedorVariacionVelocidadPorEstacionAnioServiceUTest
    /// </summary>
    [TestClass]
    public class ObtenedorVariacionVelocidadPorEstacionAnioServiceUTest
    {      
        [TestMethod]
        public void ObtenerVariacionVelocidad_EstacionInverno_RetornaMenos30()
        {
            //Arrange.
            var SUT = new ObtenedorVariacionVelocidadPorEstacionAnioService();

            //Act.
            var iVariacion = SUT.ObtenerVariacionVelocidad(eEstacionesAnio.Invierno);

            //Assert.
            Assert.AreEqual(-30, iVariacion);
        }

        [TestMethod]
        public void ObtenerVariacionVelocidad_EstacionPrimavera_Retorna0()
        {
            //Arrange.
            var SUT = new ObtenedorVariacionVelocidadPorEstacionAnioService();

            //Act.
            var iVariacion = SUT.ObtenerVariacionVelocidad(eEstacionesAnio.Primavera);

            //Assert.
            Assert.AreEqual(0, iVariacion);
        }

        [TestMethod]
        public void ObtenerVariacionVelocidad_EstacionOtonio_RetornaMas15()
        {
            //Arrange.
            var SUT = new ObtenedorVariacionVelocidadPorEstacionAnioService();

            //Act.
            var iVariacion = SUT.ObtenerVariacionVelocidad(eEstacionesAnio.Otonio);

            //Assert.
            Assert.AreEqual(15, iVariacion);
        }

        [TestMethod]
        public void ObtenerVariacionVelocidad_EstacionVerano_RetornaMenos10()
        {
            //Arrange.
            var SUT = new ObtenedorVariacionVelocidadPorEstacionAnioService();

            //Act.
            var iVariacion = SUT.ObtenerVariacionVelocidad(eEstacionesAnio.Verano);

            //Assert.
            Assert.AreEqual(-10, iVariacion);
        }
    }
}
