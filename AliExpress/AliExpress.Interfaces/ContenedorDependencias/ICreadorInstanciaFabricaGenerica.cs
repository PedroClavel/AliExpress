namespace AliExpress.Interfaces.ContenedorDependencias
{
    public interface ICreadorInstanciaFabricaGenerica
    {
        /// <summary>
        /// Método para crear la instancia de una interfaz genérica a usar en el contenedor de dependencia.
        /// </summary>
        /// <typeparam name="T">Tipo de dato de una interfaz de tipo genérica.</typeparam>
        /// <returns>Retorna un tipo de la instancia creada del StructureMap.</returns>
        T CrearInstancia<T>();

        /// <summary>
        /// Método para crear la instancia de una interfaz genérica a usar en el contenedor de dependencia.
        /// </summary>
        /// <typeparam name="T">Tipo de dato de una interfaz de tipo genérica.</typeparam>
        /// <param name="_cIdentificador">Identificador de la instancia a obtener.</param>
        /// <returns>Retorna un tipo de la instancia creada del StructureMap.</returns>
        T CrearInstancia<T>(string _cIdentificador);      
    }
}