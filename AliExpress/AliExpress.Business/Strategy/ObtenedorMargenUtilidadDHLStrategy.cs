using AliExpress.Interfaces.Business.Strategy;
using System;

namespace AliExpress.Business.Strategy
{
    public class ObtenedorMargenUtilidadDHLStrategy : IObtenedorMargenUtilidadPaqueteria
    {
        /// <summary>
        /// Método para obtener el margen de utilidad de la paquetería con base a la fecha en la que se realizó el pedido.
        /// </summary>
        /// <param name="dtFechaPedido">Fecha del pedido.</param>
        /// <returns>Retorna el margen de utilidad con base a la fecha del pedido.</returns>
        public int ObtenerMargenUtilidad(DateTime dtFechaPedido)
        {
            int iPorcentaje = 0;
            var iMes = dtFechaPedido.Month;

            if (iMes >= 1 && iMes <= 6)
            {
                iPorcentaje = 50;
            }
            else
            {
                iPorcentaje = 30;
            }

            return iPorcentaje;
        }
    }
}
