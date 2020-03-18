using AliExpress.ViewModel.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AliExpressUTest.ViewModel.Services
{
    /// <summary>
    /// Descripción resumida de GeneradorExpresionesViewModelServiceUTest
    /// </summary>
    [TestClass]
    public class GeneradorExpresionesViewModelServiceUTest
    {       
        [TestMethod]
        public void GenerarExpresionUno_FechaMenorAFechaDeHoy_RetornaCadenaSalio()
        {
            //Arrange.
            var SUT = new GeneradorExpresionesViewModelService();
            var dtFechaRecepcion = new DateTime(2020, 03, 15).Date;

            //Act.
            var cCadenaResultado = SUT.GenerarExpresionUno(dtFechaRecepcion);

            //Assert.
            Assert.AreEqual("salió", cCadenaResultado);
        }

        [TestMethod]
        public void GenerarExpresionUno_FechaMayorAFechaDeHoy_RetornaCadenaHaSalido()
        {
            //Arrange.
            var SUT = new GeneradorExpresionesViewModelService();
            var dtFechaRecepcion = new DateTime(2020, 04, 15).Date;

            //Act.
            var cCadenaResultado = SUT.GenerarExpresionUno(dtFechaRecepcion);

            //Assert.
            Assert.AreEqual("ha salido", cCadenaResultado);
        }

        [TestMethod]
        public void GenerarExpresionDos_FechaMenorAFechaDeHoy_RetornaCadenaLlego()
        {
            //Arrange.
            var SUT = new GeneradorExpresionesViewModelService();
            var dtFechaRecepcion = new DateTime(2020, 03, 15).Date;

            //Act.
            var cCadenaResultado = SUT.GenerarExpresionDos(dtFechaRecepcion);

            //Assert.
            Assert.AreEqual("llegó", cCadenaResultado);
        }

        [TestMethod]
        public void GenerarExpresionDos_FechaMayorAFechaDeHoy_RetornaCadenaLlegara()
        {
            //Arrange.
            var SUT = new GeneradorExpresionesViewModelService();
            var dtFechaRecepcion = new DateTime(2020, 04, 15).Date;

            //Act.
            var cCadenaResultado = SUT.GenerarExpresionDos(dtFechaRecepcion);

            //Assert.
            Assert.AreEqual("llegará", cCadenaResultado);
        }

        [TestMethod]
        public void GenerarExpresionTres_FechaMenorAFechaDeHoy_RetornaCadenaHace()
        {
            //Arrange.
            var SUT = new GeneradorExpresionesViewModelService();
            var dtFechaRecepcion = new DateTime(2020, 03, 15).Date;

            //Act.
            var cCadenaResultado = SUT.GenerarExpresionTres(dtFechaRecepcion);

            //Assert.
            Assert.AreEqual("hace", cCadenaResultado);
        }

        [TestMethod]
        public void GenerarExpresionTres_FechaMayorAFechaDeHoy_RetornaCadenaLlegara()
        {
            //Arrange.
            var SUT = new GeneradorExpresionesViewModelService();
            var dtFechaRecepcion = new DateTime(2020, 04, 15).Date;

            //Act.
            var cCadenaResultado = SUT.GenerarExpresionTres(dtFechaRecepcion);

            //Assert.
            Assert.AreEqual("dentro de", cCadenaResultado);
        }

        [TestMethod]
        public void GenerarExpresionCuatro_FechaMenorAFechaDeHoy_RetornaCadenaTuvo()
        {
            //Arrange.
            var SUT = new GeneradorExpresionesViewModelService();
            var dtFechaRecepcion = new DateTime(2020, 03, 15).Date;

            //Act.
            var cCadenaResultado = SUT.GenerarExpresionCuatro(dtFechaRecepcion);

            //Assert.
            Assert.AreEqual("tuvo", cCadenaResultado);
        }

        [TestMethod]
        public void GenerarExpresionCuatro_FechaMayorAFechaDeHoy_RetornaCadenaTuvo()
        {
            //Arrange.
            var SUT = new GeneradorExpresionesViewModelService();
            var dtFechaRecepcion = new DateTime(2020, 04, 15).Date;

            //Act.
            var cCadenaResultado = SUT.GenerarExpresionCuatro(dtFechaRecepcion);

            //Assert.
            Assert.AreEqual("tendrá", cCadenaResultado);
        }
    }
}