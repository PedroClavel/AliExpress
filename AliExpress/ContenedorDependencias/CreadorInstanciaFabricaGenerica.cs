using AliExpress.Interfaces.ContenedorDependencias;
using StructureMap;

namespace ContenedorDependencias
{
    /// <summary>
    /// Clase para generar la fabrica genérica del contenedor de dependencias.
    /// </summary>
    public class CreadorInstanciaFabricaGenerica : ICreadorInstanciaFabricaGenerica
    {
        /// <summary>
        /// Propiedad para asignar el valor del contenedor del StructureMap.
        /// </summary>
        private readonly IContainer ContenedorDI;

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="_ContenedorDI"></param>
        public CreadorInstanciaFabricaGenerica(IContainer _ContenedorDI)
        {
            ContenedorDI = _ContenedorDI;
            ContenedorDI.Configure((DI) => DI.For<ICreadorInstanciaFabricaGenerica>().Use(this));
        }

        /// <summary>
        /// Método para crear la instancia de una interfaz genérica a usar en el contenedor de dependencia.
        /// </summary>
        /// <typeparam name="T">Tipo de dato de una interfaz de tipo genérica.</typeparam>
        /// <returns>Retorna un tipo de la instancia creada del StructureMap.</returns>
        public T CrearInstancia<T>()
        {
            return ContenedorDI.GetInstance<T>();
        }

        /// <summary>
        /// Método para crear la instancia de una interfaz genérica a usar en el contenedor de dependencia.
        /// </summary>
        /// <typeparam name="T">Tipo de dato de una interfaz de tipo genérica.</typeparam>
        /// <param name="_cIdentificador">Identificador de la instancia a obtener.</param>
        /// <returns>Retorna un tipo de la instancia creada del StructureMap.</returns>
        public T CrearInstancia<T>(string _cIdentificador)
        {
            return ContenedorDI.GetInstance<T>(_cIdentificador);
        }  
    }
}