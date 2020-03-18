using AliExpress.Data.Entities.DTO;
using AliExpress.Interfaces.Business.Strategy;
using System;

namespace AliExpress.Business.Strategy
{
    public class CalculadorTiempoTrasladoAereoStrategy : ICalculadorTiempoTrasladoMedioTransporte
    {
        /// <summary>
        /// Método para obtener el tiempo de traslado con base al medio de transporte a instanciar.
        /// </summary>
        /// <param name="datosPedidoDTO">Pedidos DTO.</param>
        /// <returns>Retorna el tiempo de traslado del medio de transporte.</returns>
        public decimal ObtenerTiempoTraslado(DatosPedidoDTO datosPedidoDTO)
        {
            ValidarParametroDatosPedidoDTO(datosPedidoDTO);

            var dTiempoTraslado = 0M;

            var dEscala = Math.Truncate(datosPedidoDTO.dDistancia / 1000M);

            decimal dTiempoExtra = dEscala * 6M;

            decimal dTraslado = datosPedidoDTO.dDistancia / 600M;

            dTiempoTraslado = dTiempoExtra + dTraslado;

            return dTiempoTraslado;
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
