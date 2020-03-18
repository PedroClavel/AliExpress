using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AliExpress.Business.Strategy;

namespace AliExpress.BusinessUTest.Strategy
{
    /// <summary>
    /// Descripción resumida de ObtenedorMargenUtilidadFedexStrategyUTest
    /// </summary>
    [TestClass]
    public class ObtenedorMargenUtilidadFedexStrategyUTest
    {
        [TestMethod]
        public void ObtenerMargenUtilidad_NumeroPar_Retorna40()
        {
            //Arrange.
            var SUT = new ObtenedorMargenUtilidadFedexStrategy();
            DateTime dtFechaPedido = new DateTime(2020, 02, 12);

            //Act.
            var iPorcentaje = SUT.ObtenerMargenUtilidad(dtFechaPedido);

            //Assert.
            Assert.AreEqual(40, iPorcentaje);
        }

        [TestMethod]
        public void ObtenerMargenUtilidad_NumeroImPar_Retorna30()
        {
            //Arrange.
            var SUT = new ObtenedorMargenUtilidadFedexStrategy();
            DateTime dtFechaPedido = new DateTime(2020, 05, 12);

            //Act.
            var iPorcentaje = SUT.ObtenerMargenUtilidad(dtFechaPedido);

            //Assert.
            Assert.AreEqual(30, iPorcentaje);
        }
    }
}
