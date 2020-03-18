using AliExpress.Interfaces.Business;
using System;
using System.IO;

namespace AliExpress.Business.LeerArchivo
{
    /// <summary>
    /// Clase para obtener los datos de lectura del archivo csv.
    /// </summary>
    public class ObtenedorDatosArchivoService : IObtenedorDatosArchivoService
    {
        IValidadorDatosArchivoService srvValidadorDatosArchivo;

        public ObtenedorDatosArchivoService(IValidadorDatosArchivoService srvValidadorDatosArchivo)
        {
            this.srvValidadorDatosArchivo = srvValidadorDatosArchivo ?? throw new ArgumentNullException(nameof(srvValidadorDatosArchivo));
        }

        /// <summary>
        /// Método para obtener los datos del archivo de tipo csv.
        /// </summary>
        /// <param name="cRutaArchivo">Ruta del archivo a consultar.</param>
        /// <returns>Retorna un arreglo de string con la cadena de los datos obtenidos del archivo.</returns>
        public string[,] ObtenerDatosArchivo(string cRutaArchivo)
        {
            var cExtension = Path.GetExtension(cRutaArchivo);
            string[,] cDatosArchivo = new string[0, 0];

            srvValidadorDatosArchivo.ValidarObtencionArchivo(cExtension, cRutaArchivo);

            string cTextoArchivoObtenido = File.ReadAllText(cRutaArchivo);

            string[] lstLineas = cTextoArchivoObtenido.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            srvValidadorDatosArchivo.ValidarColumnasPedidos(lstLineas);

            cDatosArchivo = ObtenerCadenaDatos(lstLineas);
        
            return cDatosArchivo;
        }

        private string[,] ObtenerCadenaDatos(string[] lstLineas)
        {
            string[,] cDatosArchivo;
            int rows = lstLineas.Length;
            int cols = lstLineas[0].Split(',').Length; // Debe de ser igual a 8

            cDatosArchivo = new string[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lstLineas[r].Split(',');
                for (int c = 0; c < cols; c++)
                {
                    cDatosArchivo[r, c] = line_r[c];
                }
            }

            return cDatosArchivo;
        }
    }
}
