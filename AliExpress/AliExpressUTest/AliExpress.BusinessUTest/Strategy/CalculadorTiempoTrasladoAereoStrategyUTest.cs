using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AliExpress.Data.Entities.DTO;
using AliExpress.Business.Strategy;

namespace AliExpress.BusinessUTest.Strategy
{
    /// <summary>
    /// Descripción resumida de CalculadorTiempoTrasladoAereoStrategyUTest
    /// </summary>
    [TestClass]
    public class CalculadorTiempoTrasladoAereoStrategyUTest
    {
        [TestMethod]
        public void ObtenerTiempoTraslado_()
        {
            //Arrange.
            var datosPedido = ObtenerDatosPedidoDTO();
            var SUT = new CalculadorTiempoTrasladoAereoStrategy();

            //Act.
            var dTiempoTraslado = SUT.ObtenerTiempoTraslado(datosPedido);

            //Assert.
            Assert.AreEqual(8M, dTiempoTraslado);
        }

        /// <summary>
        /// Método privado para obtener los datos del pedido en la entidad de tipo DTO.
        /// </summary>
        /// <returns>Retorna la entidad de tipo DatosPedidoDTO.</returns>
        private DatosPedidoDTO ObtenerDatosPedidoDTO()
        {
            var datosPedidoDTO = new DatosPedidoDTO();

            datosPedidoDTO.dDistancia = 1200;
            datosPedidoDTO.dtFechaHoraPedido = new DateTime(2020, 2, 22);

            return datosPedidoDTO;
        }
    }
}
