using AliExpress.Data.Entities.Enumeradores;

namespace AliExpress.Interfaces.Business
{
    /// <summary>
    /// Interfaz de la clase ObtenedorVariacionVelocidadPorEstacionAnioService.
    /// </summary>
    public interface IObtenedorVariacionVelocidadPorEstacionAnioService
    {
        /// <summary>
        /// Método para obtener la variación de velocidad de la estación del año correspondiente.
        /// </summary>
        /// <param name="eEstacionesAnio">Enumerador de la estación del año.</param>
        /// <returns>Retorna el valor de la variación de la velocidad en base a la estación del año que se recibe como parámetro.</returns>
        int ObtenerVariacionVelocidad(eEstacionesAnio eEstacionesAnio);
    }
}
