using System;

namespace AliExpress.Interfaces.AliExpress.ViewModel
{
    /// <summary>
    /// Interfaz para generar las expresiones.
    /// </summary>
    public interface IGeneradorExpresionesViewModelService
    {
        /// <summary>
        /// Método para generar una expresión con base a la fecha de entrega.
        /// </summary>
        /// <param name="dtFechaEntrega">Fecha de entrega.</param>
        /// <returns>Retorna una cadena "salió", cuando la fecha de entrega es menor al día de hoy y "ha salido" en caso contrario.</returns>
        string GenerarExpresionUno(DateTime dtFechaEntrega);

        /// <summary>
        /// Método para generar una expresión con base a la fecha de entrega.
        /// </summary>
        /// <param name="dtFechaEntrega">Fecha de entrega.</param>
        /// <returns>Retorna una cadena "llegó", cuando la fecha de entrega es menor al día de hoy y "llegará" en caso contrario.</returns>
        string GenerarExpresionDos(DateTime dtFechaEntrega);

        /// <summary>
        /// Método para generar una expresión con base a la fecha de entrega.
        /// </summary>
        /// <param name="dtFechaEntrega">Fecha de entrega.</param>
        /// <returns>Retorna una cadena "hace", cuando la fecha de entrega es menor al día de hoy y "dentro de" en caso contrario.</returns>
        string GenerarExpresionTres(DateTime dtFechaEntrega);

        /// <summary>
        /// Método para generar una expresión con base a la fecha de entrega.
        /// </summary>
        /// <param name="dtFechaEntrega">Fecha de entrega.</param>
        /// <returns>Retorna una cadena "tuvo", cuando la fecha de entrega es menor al día de hoy y "tendrá" en caso contrario.</returns>
        string GenerarExpresionCuatro(DateTime dtFechaEntrega);
    }
}
