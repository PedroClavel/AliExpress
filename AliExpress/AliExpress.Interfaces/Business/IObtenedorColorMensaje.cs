using System;

namespace AliExpress.Interfaces.Business
{
    /// <summary>
    /// Interfaz para procesar los colores que debe de tener la información a pintar.
    /// </summary>
    public interface IObtenedorColorMensaje
    {
        /// <summary>
        /// Método para obtener el color a pintar el mensaje con base al parámetro que se recibe.
        /// </summary>
        /// <param name="lEntregado">Variable booleano para indicar si  se entrego el pedido o no.</param>
        /// <returns>Retorna el tipo de color a pintar el mensaje que se pintará.</returns> 
        ConsoleColor ObtenerColorMensaje(bool lEntregado);
    }
}
