using System.Collections.Generic;

namespace AliExpress.Interfaces.Business
{
    /// <summary>
    /// Interfaz de la clase ObtenedorDatosArchivoService.
    /// </summary>
    public interface IObtenedorDatosArchivoService
    {
        /// <summary>
        /// Método para obtener los datos del archivo de tipo csv.
        /// </summary>
        /// <param name="cRutaArchivo">Ruta del archivo a consultar.</param>
        /// <returns>Retorna un arreglo de string con la cadena de los datos obtenidos del archivo.</returns>
        string[,] ObtenerDatosArchivo(string cRutaArchivo);
    }
}
