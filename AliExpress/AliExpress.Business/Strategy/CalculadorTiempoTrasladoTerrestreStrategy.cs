using AliExpress.Data.Entities.DTO;
using AliExpress.Interfaces.Business;
using AliExpress.Interfaces.Business.Strategy;
using System;

namespace AliExpress.Business.Strategy
{
    public class CalculadorTiempoTrasladoTerrestreStrategy : ICalculadorTiempoTrasladoMedioTransporte
    {
        private readonly IObtenedorEstacionAnio srvObtenedorEstacionAnio;
        private readonly IObtenedorDescansoDiarioPorEstacionAnioService srvObtenedorDescansoDiario;
        private readonly ITruncadorDecimales truncadorDecimales;

        public CalculadorTiempoTrasladoTerrestreStrategy(IObtenedorEstacionAnio srvObtenedorEstacionAnio, IObtenedorDescansoDiarioPorEstacionAnioService srvObtenedorDescansoDiario, ITruncadorDecimales truncadorDecimales)
        {
            this.srvObtenedorEstacionAnio = srvObtenedorEstacionAnio ?? throw new ArgumentNullException(nameof(srvObtenedorEstacionAnio));
            this.srvObtenedorDescansoDiario = srvObtenedorDescansoDiario ?? throw new ArgumentNullException(nameof(srvObtenedorDescansoDiario));
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

            var dDescansoDiario = srvObtenedorDescansoDiario.ObtenerDescansoDiario(eEstacionAnio);

            var dTiempoExtra = (6 * dDescansoDiario) / 24M;

            dTiempoTraslado = 6 + dTiempoExtra;

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
