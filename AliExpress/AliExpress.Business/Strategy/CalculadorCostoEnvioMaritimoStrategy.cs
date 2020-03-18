using AliExpress.Data.Entities.DTO;
using AliExpress.Interfaces.Business;
using AliExpress.Interfaces.Business.Strategy;
using System;

namespace AliExpress.Business.Strategy
{
    /// <summary>
    /// Clase para obtener el costo de envío de tipo de transporte marítimo.
    /// </summary>
    public class CalculadorCostoEnvioMaritimoStrategy : ICalculadorCostoEnvioMedioTransporte
    {
        private readonly IObtenedorEstacionAnio srvObtenedorEstacionAnio;
        private readonly IObtenedorVariacionCostoPorEstacionAnioService srvObtenedorVariacionCostoPorEstacionAnioService;

        public CalculadorCostoEnvioMaritimoStrategy(IObtenedorEstacionAnio srvObtenedorEstacionAnio, IObtenedorVariacionCostoPorEstacionAnioService srvObtenedorVariacionCostoPorEstacionAnioService)
        {
            this.srvObtenedorEstacionAnio = srvObtenedorEstacionAnio ?? throw new ArgumentNullException(nameof(srvObtenedorEstacionAnio));
            this.srvObtenedorVariacionCostoPorEstacionAnioService = srvObtenedorVariacionCostoPorEstacionAnioService ?? throw new ArgumentNullException(nameof(srvObtenedorVariacionCostoPorEstacionAnioService));
        }

        /// <summary>
        /// Método para obtener el costo de envío con base al medio de transporte.
        /// </summary>
        /// <param name="datosPedidoDTO">Datos del pedido que se esta realizando el pedido.</param>
        /// <returns>Retorna el total del costo de envío.</returns>
        public decimal CalcularCostoEnvio(DatosPedidoDTO datosPedidoDTO)
        {
            ValidarParametroDatosPedidoDTO(datosPedidoDTO);
            decimal dCosto = 0;

            var eEstacionAnio = srvObtenedorEstacionAnio.ObtenerEstacionAnio(datosPedidoDTO.dtFechaHoraPedido);

            decimal dRangoDistancia = ObtenerRangoDistancia(datosPedidoDTO.dDistancia);

            var dVariacionCosto = srvObtenedorVariacionCostoPorEstacionAnioService.ObtenerVariacionCosto(eEstacionAnio);

            var dSubTotal = datosPedidoDTO.dDistancia * dRangoDistancia;

            dCosto = dSubTotal * (1 + (dVariacionCosto / 100M));

            return dCosto;
        }

        /// <summary>
        /// Método para obtener el valor del costo de rango que se tiene.
        /// </summary>
        /// <param name="dDistancia">Distancia del pedido.</param>
        /// <returns>Retorna el costo de rango del transporte marítimo.</returns>
        private decimal ObtenerRangoDistancia(decimal dDistancia)
        {
            decimal dRangoCosto = 0;

            if (dDistancia >= 1 && dDistancia <= 100)
            {
                dRangoCosto = 1;
            }
            else if (dDistancia >= 101 && dDistancia <= 1000)
            {
                dRangoCosto = 0.5M;
            }
            else if (dDistancia >= 1001)
            {
                dRangoCosto = 0.3M;
            }

            return dRangoCosto;
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
