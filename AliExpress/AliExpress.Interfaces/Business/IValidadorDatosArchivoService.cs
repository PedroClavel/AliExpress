namespace AliExpress.Interfaces.Business
{
    /// <summary>
    /// Interfaz para validar la cantidad de columnas que se tiene en el archivo.
    /// </summary>
    public interface IValidadorDatosArchivoService
    {
        /// <summary>
        /// Método para validar que la cantidad de columnas por cada fila del archivo sea correcto.
        /// </summary>
        /// <param name="lstLineas">Lista de lineas que se tienen en el archivo.</param>
        void ValidarColumnasPedidos(string[] lstLineas);

        /// <summary>
        /// Método para validar la obtención del archivo.
        /// </summary>
        /// <param name="cExtension">Extensión del archivo.</param>
        /// <param name="cRuta">Ruta del archivo.</param>
        void ValidarObtencionArchivo(string cExtension, string cRuta);
    }
}
