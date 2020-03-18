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
            Console.WriteLine(cPrueba);

            string cPrueba2 = "Prueba de proyecto";
            Console.ResetColor();

            Console.ForegroundColor = srvObtenedorColorMensaje.ObtenerColorMensaje(false);


            Console.WriteLine(cPrueba2);
        
            string cRutaArchivo = @"C:/Buenas Practicas/Repositorio-Git/AliExpress/Documentos/Pruebas.csv";

            Console.ReadKey();
        }       
    }
}
