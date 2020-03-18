using AliExpress.Data.Entities.DTO;
using AliExpress.Interfaces.Business.Strategy;
using System;

namespace AliExpress.Business.Strategy
{
    public class CalculadorCostoEnvioTerrestreStrategy : ICalculadorCostoEnvioMedioTransporte
    {
        /// <summary>
        /// Método para obtener el costo de envío con base al medio de transporte.
        /// </summary>
        /// <param name="datosPedidoDTO">Datos del pedido que se esta realizando el pedido.</param>
        /// <returns>Retorna el total del costo de envío.</returns>
        public decimal CalcularCostoEnvio(DatosPedidoDTO datosPedidoDTO)
        {
            ValidarParametroDatosPedidoDTO(datosPedidoDTO);
            var dCosto = 0;

            if (datosPedidoDTO.dDistancia >= 1 && datosPedidoDTO.dDistancia <= 50)
            {
                dCosto = 15;
            }
            else if (datosPedidoDTO.dDistancia >= 51 && datosPedidoDTO.dDistancia <= 200)
            {
                dCosto = 10;
            }
            else if (datosPedidoDTO.dDistancia >= 201 && datosPedidoDTO.dDistancia <= 300)
            {
                dCosto = 8;
            }
            else
            {
                dCosto = 7;
            }

            return dCosto;
        }

        private static void ValidarParametroDatosPedidoDTO(DatosPedidoDTO datosPedidoDTO)
        {
            if (datosPedidoDTO == null)
            {
                throw new ArgumentNullException(nameof(datosPedidoDTO));
            }
        }
    }
}
