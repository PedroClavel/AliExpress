using AliExpress.Data.Entities.Enumeradores;
using System;

namespace AliExpress.Interfaces.Business
{
    /// <summary>
    /// Interfaz de la clase ObtenedorEstacionAnio.
    /// </summary>
    public interface IObtenedorEstacionAnio
    {
        /// <summary>
        /// Método para obtener la estación del año correspondiente a la fecha en la que se realizó el pedido.
        /// </summary>
        /// <param name="dtFechaPedido">Fecha del pedido.</param>
        /// <returns>Retorna el enumerador con el nombre de la estación del año correspondiente.</returns>
        eEstacionesAnio ObtenerEstacionAnio(DateTime dtFechaPedido);
    }
}
