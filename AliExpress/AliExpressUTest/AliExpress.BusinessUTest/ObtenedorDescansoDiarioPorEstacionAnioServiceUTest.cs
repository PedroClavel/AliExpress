using Microsoft.VisualStudio.TestTools.UnitTesting;
using AliExpress.Data.Entities.Enumeradores;
using AliExpress.Business;

namespace AliExpress.BusinessUTest
{
    /// <summary>
    /// Descripción resumida de ObtenedorDescansoDiarioPorEstacionAnioServiceUTest
    /// </summary>
    [TestClass]
    public class ObtenedorDescansoDiarioPorEstacionAnioServiceUTest

    {
        [TestMethod]
        public void ObtenerDescansoDiario_EstacionInverno_Retorna8()
        {
            //Arrange.
            var SUT = new ObtenedorDescansoDiarioPorEstacionAnioService();

            //Act.
            var iVariacion = SUT.ObtenerDescansoDiario(eEstacionesAnio.Invierno);

            //Assert.
            Assert.AreEqual(8, iVariacion);
        }

        [TestMethod]
        public void ObtenerDescansoDiario_EstacionPrimavera_Retorna4()
        {
            //Arrange.
            var SUT = new ObtenedorDescansoDiarioPorEstacionAnioService();

            //Act.
            var iVariacion = SUT.ObtenerDescansoDiario(eEstacionesAnio.Primavera);

            //Assert.
            Assert.AreEqual(4, iVariacion);
        }

        [TestMethod]
        public void ObtenerDescansoDiario_EstacionOtonio_Retorna5()
        {
            //Arrange.
            var SUT = new ObtenedorDescansoDiarioPorEstacionAnioService();

            //Act.
            var iVariacion = SUT.ObtenerDescansoDiario(eEstacionesAnio.Otonio);

            //Assert.
            Assert.AreEqual(5, iVariacion);
        }

        [TestMethod]
        public void ObtenerDescansoDiario_EstacionVerano_Retorna6()
        {
            //Arrange.
            var SUT = new ObtenedorDescansoDiarioPorEstacionAnioService();

            //Act.
            var iVariacion = SUT.ObtenerDescansoDiario(eEstacionesAnio.Verano);

            //Assert.
            Assert.AreEqual(6, iVariacion);
        }
    }
}
