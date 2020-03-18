using AliExpress.Interfaces.ContenedorDependencias;
using StructureMap;
using System;

namespace ContenedorDependencias
{
    /// <summary>
    /// Clase contenedora de la inyección de dependencias.
    /// </summary>
    public static class ContenedorDIFactory
    {
        /// <summary>
        /// Fabrica de instancias genéricas.
        /// </summary>
        public static ICreadorInstanciaFabricaGenerica CrearMetodoFabrica { get; private set; }

        /// <summary>
        /// Método para inicializar la interface estática que se va a estar usando.
        /// </summary>
        /// <param name="_Fabrica">Instancia de tipo IFabricaStruture.</param>
        public static void UsarFabrica(ICreadorInstanciaFabricaGenerica _Fabrica)
        {
            CrearMetodoFabrica = _Fabrica ?? throw new ArgumentNullException(nameof(_Fabrica));
        }

        /// <summary>
        /// Método para configurar el contenedor de dependencias a instanciar.
        /// </summary>
        /// <param name="_configuracionDependencias">Entidad del contenedor de dependencias a instanciar.</param>
        public static void ConfigurarStructureMap(Registry _configuracionDependencias)
        {
            ValidarParametroRegistry(_configuracionDependencias);

            var contenedorEstructura = new Container(_configuracionDependencias);

            var factoryStructure = new CreadorInstanciaFabricaGenerica(contenedorEstructura);

            UsarFabrica(factoryStructure);
        }

        /// <summary>
        /// Método privado para validar el parámetro de tipo Registry.
        /// </summary>
        /// <param name="_configuracionDependencias">Entidad del contenedor de dependencias a usar.</param>
        private static void ValidarParametroRegistry(Registry _configuracionDependencias)
        {
            if (_configuracionDependencias == null)
            {
                throw new ArgumentNullException(nameof(_configuracionDependencias));
            }
        }
    }
}