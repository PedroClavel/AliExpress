using AliExpress.Data.Entities.DTO;
using AliExpress.Interfaces.Business.Strategy;
using System;

namespace AliExpress.Business.Strategy
{
    /// <summary>
    /// Clase para obtener el costo de envío del transporte Aéreo.
    /// </summary>
    public class CalculadorCostoEnvioAereoStrategy : ICalculadorCostoEnvioMedioTransporte
    {       
        /// <summary>
        /// Método para obtener el costo de envío del transporte Aéreo.
        /// </summary>
        /// <param name="datosPedidoDTO">Datos del pedido de tipo DTO.</param>
        /// <returns>Retorna el costo del envío.</returns>
        public decimal CalcularCostoEnvio(DatosPedidoDTO datosPedidoDTO)
        {
            ValidarParametroDatosPedidoDTO(datosPedidoDTO);
            decimal dCosto = 0;

            var dEscala = Math.Truncate(datosPedidoDTO.dDistancia / 1000M);

            var dCargoExtra = dEscala * 200;

            var dTarifa = datosPedidoDTO.dDistancia * 10M;

            dCosto = dTarifa + dCargoExtra;

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
