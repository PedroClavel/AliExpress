using AliExpress.Data.Entities.Enumeradores;
using AliExpress.Interfaces.Business;
using System;

namespace AliExpress.Business
{
    /// <summary>
    /// Clase para obtener la estación del año correspondiente a la fecha de en que se realizó el pedido.
    /// </summary>
    public class ObtenedorEstacionAnio : IObtenedorEstacionAnio
    {
        /// <summary>
        /// Método para obtener la estación del año correspondiente a la fecha en la que se realizó el pedido.
        /// </summary>
        /// <param name="dtFechaPedido">Fecha del pedido.</param>
        /// <returns>Retorna el enumerador con el nombre de la estación del año correspondiente.</returns>
        public eEstacionesAnio ObtenerEstacionAnio(DateTime dtFechaPedido)
        {
            var estacionesAnio = new eEstacionesAnio();

            var dtFechaPrimavera = new DateTime(dtFechaPedido.Year, 3, 21);
            var dtFechaPrimavera1 = new DateTime(dtFechaPedido.Year, 6, 20);

            var dtVerano = new DateTime(dtFechaPedido.Year, 6, 21);
            var dtVerano1 = new DateTime(dtFechaPedido.Year, 9, 23);

            var dtOtonio = new DateTime(dtFechaPedido.Year, 9, 24);
            var dtOtonio1 = new DateTime(dtFechaPedido.Year, 12, 21);

            if (dtFechaPedido.Date >= dtFechaPrimavera && dtFechaPedido.Date <= dtFechaPrimavera1)
            {
                estacionesAnio = eEstacionesAnio.Primavera;
            }
            else if (dtFechaPedido.Date >= dtVerano && dtFechaPedido.Date <= dtVerano1)
            {
                estacionesAnio = eEstacionesAnio.Verano;
            }
            else if (dtFechaPedido.Date >= dtOtonio && dtFechaPedido.Date <= dtOtonio1)
            {
                estacionesAnio = eEstacionesAnio.Otonio;
            }
            else
            {
                estacionesAnio = eEstacionesAnio.Invierno;
            }

            return estacionesAnio;
        }
    }
}