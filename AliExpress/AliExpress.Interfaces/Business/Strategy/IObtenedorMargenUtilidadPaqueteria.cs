using System;

namespace AliExpress.Interfaces.Business.Strategy
{
    public interface IObtenedorMargenUtilidadPaqueteria
    {
        /// <summary>
        /// Método para obtener el margen de utilidad de la paquetería con base a la fecha en la que se realizó el pedido.
        /// </summary>
        /// <param name="dtFechaPedido">Fecha del pedido.</param>
        /// <returns>Retorna el margen de utilidad con base a la fecha del pedido.</returns>
        int ObtenerMargenUtilidad(DateTime dtFechaPedido);
    }
}
