using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AliExpress.Business.Validaciones;

namespace AliExpress.BusinessUTest.Validaciones
{
    /// <summary>
    /// Descripción resumida de ValidadorDatosArchivoServiceUTest
    /// </summary>
    [TestClass]
    public class ValidadorDatosArchivoServiceUTest
    {
        [TestMethod]
        public void ValidarColumnasPedidos_ListaPedidosIncompleta_RetornaMensajeCorrecto()
        {
            //Arrange.
            string[] lstPedidos = ObtenerDatosArchivo();
            var SUT = new ValidadorDatosArchivoService();

            try
            {
                //Act.
                SUT.ValidarColumnasPedidos(lstPedidos);
            }
            catch (Exception cError)
            {
                //Assert.
                Assert.AreEqual("El archivo no se encuentra configurado correctamente.", cError.Message);
            }          
        }

        [TestMethod]
        public void ValidarObtencionArchivo_RutaIncorrecta_RetornaMensajeCorrecto()
        {
            //Arrange.
            string cRuta = string.Empty;
            string cExtension = ".doc";
            var SUT = new ValidadorDatosArchivoService();

            try
            {
                //Act.
                SUT.ValidarObtencionArchivo(cExtension, cRuta);
            }
            catch (Exception cError)
            {
                //Assert.
                Assert.AreEqual("El archivo no existe.", cError.Message);
            }
        }
        
        private string[] ObtenerDatosArchivo()
        {
            string[] lstPedidos = new string[2];

            lstPedidos[0] = "dato1,dato2,dato3,dato4,dato5,dato6,dato7,dato8";
            lstPedidos[1] = "dato1,dato2,dato3,dato4,dato5,dato6,dato7";

            return lstPedidos;
        }
    }
}
