using AliExpress.Data.Entities.DTO;
using AliExpress.Interfaces.Business;
using AliExpress.Interfaces.Business.Strategy;
using System;

namespace AliExpress.Business.Strategy
{
    public class CalculadorTiempoTrasladoMaritimoStrategy : ICalculadorTiempoTrasladoMedioTransporte
    {
        private readonly IObtenedorEstacionAnio srvObtenedorEstacionAnio;
        private readonly IObtenedorVariacionVelocidadPorEstacionAnioService srvObtenedorVariacionVelocidadPorEstacionAnioService;
        private readonly ITruncadorDecimales truncadorDecimales;

        public CalculadorTiempoTrasladoMaritimoStrategy(IObtenedorEstacionAnio srvObtenedorEstacionAnio, IObtenedorVariacionVelocidadPorEstacionAnioService srvObtenedorVariacionVelocidadPorEstacionAnioService, ITruncadorDecimales truncadorDecimales)
        {
            this.srvObtenedorEstacionAnio = srvObtenedorEstacionAnio ?? throw new ArgumentNullException(nameof(srvObtenedorEstacionAnio));
            this.srvObtenedorVariacionVelocidadPorEstacionAnioService = srvObtenedorVariacionVelocidadPorEstacionAnioService ?? throw new ArgumentNullException(nameof(srvObtenedorVariacionVelocidadPorEstacionAnioService));
            this.truncadorDecimales = truncadorDecimales ?? throw new ArgumentNullException(nameof(truncadorDecimales));
        }

        /// <summary>
        /// Método para obtener el tiempo de traslado con base al medio de transporte a instanciar.
        /// </summary>
        /// <param name="datosPedidoDTO">Pedidos DTO.</param>
        /// <returns>Retorna el tiempo de traslado del medio de transporte.</returns>
        public decimal ObtenerTiempoTraslado(DatosPedidoDTO datosPedidoDTO)
        {
            ValidarParametroDatosPedidoDTO(datosPedidoDTO);

            decimal dTiempoTraslado = 0;

            var eEstacionAnio = srvObtenedorEstacionAnio.ObtenerEstacionAnio(datosPedidoDTO.dtFechaHoraPedido);

            var dVariacionVelocidad = srvObtenedorVariacionVelocidadPorEstacionAnioService.ObtenerVariacionVelocidad(eEstacionAnio);

            var dPorcentajeEstacion = dVariacionVelocidad / 100M;

            var dVelocidad = 46 + (46 * dPorcentajeEstacion);
            dTiempoTraslado = datosPedidoDTO.dDistancia / dVelocidad;
           
            return truncadorDecimales.TruncarNumero(dTiempoTraslado);
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
