using AliExpress.Interfaces.Business;
using System;

namespace AliExpress.ColorMensaje
{
    /// <summary>
    /// Clase para procesar los colores que debe de tener la información a pintar.
    /// </summary>
    public class ObtenedorColorMensaje : IObtenedorColorMensaje
    {
        /// <summary>
        /// Método para obtener el color a pintar el mensaje con base al parámetro que se recibe.
        /// </summary>
        /// <param name="lEntregado">Variable booleano para indicar si  se entrego el pedido o no.</param>
        /// <returns>Retorna el tipo de color a pintar el mensaje que se pintará.</returns>
        public ConsoleColor ObtenerColorMensaje(bool lEntregado)
        {
            var consoleColor = new ConsoleColor();

            if (lEntregado)
            {
                consoleColor = ConsoleColor.Green;
            }
            else
            {
                consoleColor = ConsoleColor.Yellow;
            }

            return consoleColor;
        }
    }
}
