using AliExpress.ConfiguracionDependencia;
using AliExpress.Interfaces.Business;
using ContenedorDependencias;
using System;
using System.IO;

namespace AliExpress
{
    public class Program
    {
        private static IObtenedorColorMensaje srvObtenedorColorMensaje;

        static void Main(string[] args)
        {
            ContenedorDIFactory.ConfigurarStructureMap(new DI_AliExpress());

            srvObtenedorColorMensaje = ContenedorDIFactory.CrearMetodoFabrica.CrearInstancia<IObtenedorColorMensaje>();

            string cPrueba = "Prueba de proyecto";

            Console.ForegroundColor = srvObtenedorColorMensaje.ObtenerColorMensaje(true);

            string cPrueba2 = "Prueba de proyecto";
            Console.WriteLine(cPrueba);
            Console.ResetColor();

            Console.ForegroundColor = srvObtenedorColorMensaje.ObtenerColorMensaje(false);

            Console.WriteLine(cPrueba2);
            var fullPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "InformacionPedidos.csv");// Path.GetFullPath("InformacionPedidos.csv");
            var fullPat2 = Path.GetDirectoryName("InformacionPedidos.csv");
            string sampleCSV = @"C:/Buenas Practicas/Repositorio-Git/AliExpress/Documentos/Pruebas.csv";

            string[,] values = LoadCSV(sampleCSV);
            int num_rows = values.GetUpperBound(0) + 1;
            int num_cols = values.GetUpperBound(1) + 1;

            // Display the data to show we have it.

            //for (int c = 0; c < num_cols; c++)
            //    Console.WriteLine(values[0, c] + "\t");

            //Read the data.
            for (int r = 0; r < num_rows; r++)
            {
                //  dgvValues.Rows.Add();
               // Console.WriteLine();
                for (int c = 0; c < num_cols; c++)
                {
                    Console.WriteLine(values[r, c]);
                }
            }


            Console.WriteLine("GetFullPath('{0}') returns '{1}'",
                "InformacionPedidos.csv", fullPath);
            Console.WriteLine(fullPat2);

            Console.ReadKey();
        }       

        private static string[,] LoadCSV(string cRutaArchivo)
        {
            var cExtension = Path.GetExtension(cRutaArchivo);
            string[,] cDatosArchivo = new string[0, 0];

            if (cExtension == ".csv" && File.Exists(cRutaArchivo))
            {
                string cTextoArchivoObtenido = File.ReadAllText(cRutaArchivo);

                // Split into lines.
                cTextoArchivoObtenido = cTextoArchivoObtenido.Replace('\n', '\r');
                string[] lstLineas = cTextoArchivoObtenido.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

                // See how many rows and columns there are.
                int rows = lstLineas.Length;
                int cols = lstLineas[0].Split(',').Length;

                // Allocate the data array.
                cDatosArchivo = new string[rows, cols];

                // Load the array.
                for (int r = 0; r < rows; r++)
                {
                    string[] line_r = lstLineas[r].Split(',');
                    for (int c = 0; c < cols; c++)
                    {
                        cDatosArchivo[r, c] = line_r[c];
                    }
                }
            }
            return cDatosArchivo;
        }
    }
}
