using AliExpress.Interfaces.Business;
using System;
using System.IO;

namespace AliExpress.Business.Validaciones
{
    /// <summary>
    /// Clase para validar datos del archivo donde se tienen los pedidos.
    /// </summary>
    public class ValidadorDatosArchivoService : IValidadorDatosArchivoService
    {
        /// <summary>
        /// Método para validar que la cantidad de columnas por cada fila del archivo sea correcto.
        /// </summary>
        /// <param name="lstLineas">Lista de lineas que se tienen en el archivo.</param>
        public void ValidarColumnasPedidos(string[] lstLineas)
        {
            ValidarListaLineas(lstLineas);

            int rows = lstLineas.Length;
            for (int a = 0; a < rows; a++)
            {
                int cols = lstLineas[a].Split(',').Length; // Debe de ser igual a 8.

                if (cols != 8)
                {
                    throw new Exception("El archivo no se encuentra configurado correctamente.");
                }
            }
        }

        /// <summary>
        /// Método para validar la obtención del archivo.
        /// </summary>
        /// <param name="cExtension">Extensión del archivo.</param>
        /// <param name="cRuta">Ruta del archivo.</param>
        public void ValidarObtencionArchivo(string cExtension, string cRuta)
        {
            if (!File.Exists(cRuta))
            {
                throw new Exception("El archivo no existe.");
            }
            if (cExtension != ".csv")
            {
                throw new Exception("El archivo no es de la extensión correcta.");
            }
        }

        private static void ValidarListaLineas(string[] lstLineas)
        {
            if (lstLineas == null)
            {
                throw new ArgumentNullException(nameof(lstLineas));
            }
        }        
    }
}