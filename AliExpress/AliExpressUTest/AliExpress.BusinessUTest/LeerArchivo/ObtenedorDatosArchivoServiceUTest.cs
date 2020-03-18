using Microsoft.VisualStudio.TestTools.UnitTesting;
using AliExpress.Business.LeerArchivo;
using AliExpress.Interfaces.Business;
using Moq;

namespace AliExpress.BusinessUTest.LeerArchivo
{
    /// <summary>
    /// Pruebas de la clase ObtenedorDatosArchivoService.
    /// </summary>
    [TestClass]
    public class ObtenedorDatosArchivoServiceUTest
    {
        [TestMethod]
        public void ObtenerDatosArchivo_NombreArchivoCorrectoYArchivoConDatos_RetornaCadenaArchivo()
        {
            //Arrange.
            Mock<IValidadorDatosArchivoService> docValidadorDatosArchivo = new Mock<IValidadorDatosArchivoService>();
            var cRutaArchivo = "Documentos/InformacionPedidos.csv";
            string[,] cDatosResultado = ObtenerDatosResultado();
            var SUT = new ObtenedorDatosArchivoService(docValidadorDatosArchivo.Object);

            //Act.
            string[,] cDatosArchivo = SUT.ObtenerDatosArchivo(cRutaArchivo);

            //Assert.
            Assert.AreEqual(cDatosResultado, cDatosArchivo);
        }

        /// <summary>
        /// Método privado para simular los datos de salida del método a probar.
        /// </summary>
        /// <returns>Retorna una cadena con la obtención realizada.</returns>
        private string[,] ObtenerDatosResultado()
        {
            string[,] cDatosResultado = new string[2,2];

            cDatosResultado[0, 0] = "Prueba";
            cDatosResultado[0, 1] = "Prueba";
            cDatosResultado[1, 0] = "Prueba";
            cDatosResultado[1, 1] = "Prueba";

            return cDatosResultado;
        }
    }
}
