using AliExpress.Data.Entities.Enumeradores;
using AliExpress.Interfaces.Business;

namespace AliExpress.Business
{
    /// <summary>
    /// Clase para obtener el descanso diario del trabajador con base a la estación del año.
    /// </summary>
    public class ObtenedorDescansoDiarioPorEstacionAnioService : IObtenedorDescansoDiarioPorEstacionAnioService
    {
        /// <summary>
        /// Método para obtener el valor del descanso diario de la estación del año correspondiente.
        /// </summary>
        /// <param name="eEstacionesAnio">Enumerador de la estación del año.</param>
        /// <returns>Retorna el valor del descanso diario en base a la estación del año que se recibe como parámetro.</returns>
        public int ObtenerDescansoDiario(eEstacionesAnio eEstacionesAnio)
        {
            int iDescanso = 0;

            switch (eEstacionesAnio)
            {
                case eEstacionesAnio.Primavera:
                    iDescanso = 4;
                    break;
                case eEstacionesAnio.Invierno:
                    iDescanso = 8;
                    break;
                case eEstacionesAnio.Verano:
                    iDescanso = 6;
                    break;
                case eEstacionesAnio.Otonio:
                    iDescanso = 5;
                    break;
            }

            return iDescanso;
        }
    }
}
