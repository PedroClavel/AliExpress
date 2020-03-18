using AliExpress.Data.Entities.DTO;

namespace AliExpress.Interfaces.Business.Strategy
{
    /// <summary>
    /// Interfaz de tipo fabrica para obtener la instancia del costo de envío.
    /// </summary>
    public interface ICalculadorCostoEnvioMedioTransporte
    {
        /// <summary>
        /// Método para obtener el costo de envío con base al medio de transporte.
        /// </summary>
        /// <param name="datosPedidoDTO">Datos del pedido que se esta realizando el pedido.</param>
        /// <returns>Retorna el total del costo de envío.</returns>
        decimal CalcularCostoEnvio(DatosPedidoDTO datosPedidoDTO);
    }
}