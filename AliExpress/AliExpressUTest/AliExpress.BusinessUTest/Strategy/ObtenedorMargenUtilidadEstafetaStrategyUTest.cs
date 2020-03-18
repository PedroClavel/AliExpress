using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AliExpress.Business.Strategy;

namespace AliExpress.BusinessUTest.Strategy
{
    /// <summary>
    /// Descripción resumida de ObtenedorMargenUtilidadEstafetaStrategyUTest
    /// </summary>
    [TestClass]
    public class ObtenedorMargenUtilidadEstafetaStrategyUTest
    {
        [TestMethod]
        public void ObtenerMargenUtilidad_Fecha14Febrero_Retorna10()
        {
            //Arrange.
            var dtFecha = new DateTime(2020, 02, 14);
            var SUT = new ObtenedorMargenUtilidadEstafetaStrategy();

            //Act.
            var iPorcentaje = SUT.ObtenerMargenUtilidad(dtFecha);

            //Assert.
            Assert.AreEqual(10, iPorcentaje);
        }

        [TestMethod]
        public void ObtenerMargenUtilidad_MesDiciembre_Retorna50()
        {
            //Arrange.
            var dtFecha = new DateTime(2020, 12, 14);
            var SUT = new ObtenedorMargenUtilidadEstafetaStrategy();

            //Act.
            var iPorcentaje = SUT.ObtenerMargenUtilidad(dtFecha);

            //Assert.
            Assert.AreEqual(50, iPorcentaje);
        }

        [TestMethod]
        public void ObtenerMargenUtilidad_DiferenteAFecha14FebreroYMesDiciembre_Retorna45()
        {
            //Arrange.
            var dtFecha = new DateTime(2020, 11, 14);
            var SUT = new ObtenedorMargenUtilidadEstafetaStrategy();

            //Act.
            var iPorcentaje = SUT.ObtenerMargenUtilidad(dtFecha);

            //Assert.
            Assert.AreEqual(45, iPorcentaje);
        }
    }
}
