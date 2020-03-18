using AliExpress.Data.Entities.Enumeradores;

namespace AliExpress.Interfaces.Business
{
    /// <summary>
    /// Interfaz de la clase ObtenedorDescansoDiarioPorEstacionAnioService.
    /// </summary>
    public interface IObtenedorDescansoDiarioPorEstacionAnioService
    {
        /// <summary>
        /// Método para obtener el valor del descanso diario de la estación del año correspondiente.
        /// </summary>
        /// <param name="eEstacionesAnio">Enumerador de la estación del año.</param>
        /// <returns>Retorna el valor del descanso diario en base a la estación del año que se recibe como parámetro.</returns>
        int ObtenerDescansoDiario(eEstacionesAnio eEstacionesAnio);
    }
}
