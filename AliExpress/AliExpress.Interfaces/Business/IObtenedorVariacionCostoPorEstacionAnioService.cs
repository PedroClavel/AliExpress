using AliExpress.Data.Entities.Enumeradores;

namespace AliExpress.Interfaces.Business
{
    /// <summary>
    /// Interfaz de la clase ObtenedorVariacionCostoPorEstacionAnioService.
    /// </summary>
    public interface IObtenedorVariacionCostoPorEstacionAnioService
    {
        /// <summary>
        /// Método para obtener la variación del costo de la estación del año correspondiente.
        /// </summary>
        /// <param name="eEstacionesAnio">Enumerador de la estación del año.</param>
        /// <returns>Retorna el valor de la variación del costo en base a la estación del año que se recibe como parámetro.</returns>
        int ObtenerVariacionCosto(eEstacionesAnio eEstacionesAnio);
    }
}
