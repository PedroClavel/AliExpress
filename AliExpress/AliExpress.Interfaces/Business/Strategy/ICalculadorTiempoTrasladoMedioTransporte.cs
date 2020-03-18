using AliExpress.Data.Entities.DTO;

namespace AliExpress.Interfaces.Business.Strategy
{
    public interface ICalculadorTiempoTrasladoMedioTransporte
    {
        /// <summary>
        /// Método para obtener el tiempo de traslado con base al medio de transporte a instanciar.
        /// </summary>
        /// <param name="datosPedidoDTO">Pedidos DTO.</param>
        /// <returns>Retorna el tiempo de traslado del medio de transporte.</returns>
        decimal ObtenerTiempoTraslado(DatosPedidoDTO datosPedidoDTO);
    }
}
