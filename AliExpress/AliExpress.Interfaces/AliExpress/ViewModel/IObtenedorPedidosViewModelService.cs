using AliExpress.Data.Entities.DTO;
using System.Collections.Generic;

namespace AliExpress.Interfaces.AliExpress.ViewModel
{
    /// <summary>
    /// Interfaz de la clase ObtenedorPedidosViewModelService.
    /// </summary>
    public interface IObtenedorPedidosViewModelService
    {
        /// <summary>
        /// Método para obtener 
        /// </summary>
        /// <param name="cRutaArchivo"></param>
        /// <returns>Retorna una lista con los datos de los pedidos.</returns>
        List<DatosPedidoDTO> ObtenerListaPedidos(string cRutaArchivo);
    }
}
