using AliExpress.ColorMensaje;
using AliExpress.Interfaces.Business;
using StructureMap;

namespace AliExpress.ConfiguracionDependencia
{
    /// <summary>
    /// Clase contenedora de dependencias.
    /// </summary>
    public class DI_AliExpress : Registry
    {
        /// <summary>
        /// Constructor de la clase DI_AliExpress;
        /// </summary>
        public DI_AliExpress()
        {
            For<IObtenedorColorMensaje>().Use<ObtenedorColorMensaje>();
        }
    }
}