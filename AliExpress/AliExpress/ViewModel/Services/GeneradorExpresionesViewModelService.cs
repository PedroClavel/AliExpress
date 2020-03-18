using AliExpress.Interfaces.AliExpress.ViewModel;
using System;

namespace AliExpress.ViewModel.Services
{
    public class GeneradorExpresionesViewModelService : IGeneradorExpresionesViewModelService
    {
        /// <summary>
        /// Método para generar una expresión con base a la fecha de entrega.
        /// </summary>
        /// <param name="dtFechaEntrega">Fecha de entrega.</param>
        /// <returns>Retorna una cadena "salió", cuando la fecha de entrega es menor al día de hoy y "ha salido" en caso contrario.</returns>
        public string GenerarExpresionUno(DateTime dtFechaEntrega)
        {
            var dtFechaHoy = DateTime.Now.Date;

            if (dtFechaEntrega.Date < dtFechaHoy)
            {
                return "salió";
            }
            else
            {
                return "ha salido";
            }
        }

        /// <summary>
        /// Método para generar una expresión con base a la fecha de entrega.
        /// </summary>
        /// <param name="dtFechaEntrega">Fecha de entrega.</param>
        /// <returns>Retorna una cadena "llegó", cuando la fecha de entrega es menor al día de hoy y "llegará" en caso contrario.</returns>
        public string GenerarExpresionDos(DateTime dtFechaEntrega)
        {
            var dtFechaHoy = DateTime.Now.Date;

            if (dtFechaEntrega.Date < dtFechaHoy)
            {
                return "llegó";
            }
            else
            {
                return "llegará";
            }
        }

        /// <summary>
        /// Método para generar una expresión con base a la fecha de entrega.
        /// </summary>
        /// <param name="dtFechaEntrega">Fecha de entrega.</param>
        /// <returns>Retorna una cadena "hace", cuando la fecha de entrega es menor al día de hoy y "dentro de" en caso contrario.</returns>
        public string GenerarExpresionTres(DateTime dtFechaEntrega)
        {
            var dtFechaHoy = DateTime.Now.Date;

            if (dtFechaEntrega.Date < dtFechaHoy)
            {
                return "hace";
            }
            else
            {
                return "dentro de";
            }
        }

        /// <summary>
        /// Método para generar una expresión con base a la fecha de entrega.
        /// </summary>
        /// <param name="dtFechaEntrega">Fecha de entrega.</param>
        /// <returns>Retorna una cadena "tuvo", cuando la fecha de entrega es menor al día de hoy y "tendrá" en caso contrario.</returns>
        public string GenerarExpresionCuatro(DateTime dtFechaEntrega)
        {
            var dtFechaHoy = DateTime.Now.Date;

            if (dtFechaEntrega.Date < dtFechaHoy)
            {
                return "tuvo";
            }
            else
            {
                return "tendrá";
            }
        }
    }
}