using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AliExpress.Business.Strategy;

namespace AliExpress.BusinessUTest.Strategy
{
    /// <summary>
    /// Descripción resumida de ObtenedorMargenUtilidadDHLStrategyUTest
    /// </summary>
    [TestClass]
    public class ObtenedorMargenUtilidadDHLStrategyUTest
    {
        [TestMethod]
        public void ObtenerMargenUtilidad_PimerSemestre_Retorna50()
        {
            //Arrange.
            var dtFecha = new DateTime(2020, 5, 12);
            var SUT = new ObtenedorMargenUtilidadDHLStrategy();

            //Act.
            var iPorcentaje = SUT.ObtenerMargenUtilidad(dtFecha);

            //Asser.
            Assert.AreEqual(50, iPorcentaje);
        }

        [TestMethod]
        public void ObtenerMargenUtilidad_SegundoSemestre_Retorna30()
        {
            //Arrange.
            var dtFecha = new DateTime(2020, 12, 12);
            var SUT = new ObtenedorMargenUtilidadDHLStrategy();

            //Act.
            var iPorcentaje = SUT.ObtenerMargenUtilidad(dtFecha);

            //Asser.
            Assert.AreEqual(30, iPorcentaje);
        }
    }
}
