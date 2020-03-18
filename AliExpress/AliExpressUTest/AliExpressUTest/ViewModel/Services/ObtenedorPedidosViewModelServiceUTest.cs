using AliExpress.Data.Entities.DTO;
using AliExpress.Interfaces.Business;
using AliExpress.ViewModel.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliExpressUTest.ViewModel.Services
{
    /// <summary>
    /// Pruebas de la clase ObtenedorPedidos.
    /// </summary>
    [TestClass]
    public class ObtenedorPedidosViewModelServiceUTest
    {
        [TestMethod]
        public void ObtenerListaPedidos_DatosArchivosExistente_Retorna1Registro()
        {
            //Arrange.
            Mock<IObtenedorDatosArchivoService> DOCObtenedorPedidosViewModelService = new Mock<IObtenedorDatosArchivoService>();
            string cRutaArchivo = "c:/Documentos/Prueba.csv";
            string[,] cCadenaResultado = ObtenerDatosResultado();

            DOCObtenedorPedidosViewModelService.Setup(doc => doc.ObtenerDatosArchivo(It.IsAny<string>())).Returns(cCadenaResultado);

            var SUT = new ObtenedorPedidosViewModelService(DOCObtenedorPedidosViewModelService.Object);

            //Act.
            var lstPedido = SUT.ObtenerListaPedidos(cRutaArchivo);

            //Assert.
            Assert.AreEqual(1, lstPedido.Count());
        }
      
        /// <summary>
        /// Método privado para simular los datos de salida del método a probar.
        /// </summary>
        /// <returns>Retorna una cadena con la obtención realizada.</returns>
        private string[,] ObtenerDatosResultado()
        {
            string[,] cDatosResultado = new string[1, 8];

            cDatosResultado[0, 0] = "80";
            cDatosResultado[0, 1] = "Estafeta";
            cDatosResultado[0, 2] = "Terrestre";
            cDatosResultado[0, 3] = new DateTime().ToString();
            cDatosResultado[0, 4] = "México";
            cDatosResultado[0, 5] = "Ticul";
            cDatosResultado[0, 6] = "México";
            cDatosResultado[0, 7] = "Motul";

            return cDatosResultado;
        }

        /// <summary>
        /// Método privado para obtener la lista de pedidos.
        /// </summary>
        /// <returns>Retorna una lista de pedidos de tipo DatosPedidoDTO.</returns>
        private List<DatosPedidoDTO> ObtenerDatosPedidoResultado()
        {
            var lstDatosPedidp = new List<DatosPedidoDTO>();

            lstDatosPedidp.Add(new DatosPedidoDTO()
            {
                cCuidadDestino = "Motul",
                cCuidadOrigen = "Ticul",
                cMedioTransporte = "Terrestre",
                cPaisDestino = "México",
                cPaisOrigen = "México",
                cPaqueteria = "Estafeta",
                dDistancia = 80,
                dtFechaHoraPedido = new DateTime(2020, 01, 23, 12, 00, 00)
            });

            return lstDatosPedidp;
        }
    }
}