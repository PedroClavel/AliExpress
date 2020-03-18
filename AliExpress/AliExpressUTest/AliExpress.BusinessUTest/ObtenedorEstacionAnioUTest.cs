using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AliExpress.Business;
using AliExpress.Data.Entities.Enumeradores;

namespace AliExpress.BusinessUTest
{
    /// <summary>
    /// Descripción resumida de ObtenedorEstacionAnioUTest
    /// </summary>
    [TestClass]
    public class ObtenedorEstacionAnioUTest
    {     
        [TestMethod]
        public void ObtenerEstacionAnio_FechaMarzoDia21_RetornaPrimavera()
        {
            //Assert.
            var SUT = new ObtenedorEstacionAnio();            

            //Act.
            var eEstacionAnio = SUT.ObtenerEstacionAnio(new DateTime(2020, 03, 21));

            //Assert.
            Assert.AreEqual(eEstacionesAnio.Primavera, eEstacionAnio);
        }

        [TestMethod]
        public void ObtenerEstacionAnio_FechaMesMarzoDia11_RetornaInvierno()
        {
            //Assert.
            var SUT = new ObtenedorEstacionAnio();

            //Act.
            var eEstacionAnio = SUT.ObtenerEstacionAnio(new DateTime(2020, 03, 11));

            //Assert.
            Assert.AreEqual(eEstacionesAnio.Invierno, eEstacionAnio);
        }

        [TestMethod]
        public void ObtenerEstacionAnio_FechaMesNoviembreDia11_RetornaOtonio()
        {
            //Assert.
            var SUT = new ObtenedorEstacionAnio();

            //Act.
            var eEstacionAnio = SUT.ObtenerEstacionAnio(new DateTime(2020, 11, 11));

            //Assert.
            Assert.AreEqual(eEstacionesAnio.Otonio, eEstacionAnio);
        }

        [TestMethod]
        public void ObtenerEstacionAnio_FechaMesJunioDia22_RetornaVerano()
        {
            //Assert.
            var SUT = new ObtenedorEstacionAnio();

            //Act.
            var eEstacionAnio = SUT.ObtenerEstacionAnio(new DateTime(2020, 06, 22));

            //Assert.
            Assert.AreEqual(eEstacionesAnio.Verano, eEstacionAnio);
        }
    }
}