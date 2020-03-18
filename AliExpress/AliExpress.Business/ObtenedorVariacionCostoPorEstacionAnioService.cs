using AliExpress.Data.Entities.Enumeradores;
using AliExpress.Interfaces.Business;

namespace AliExpress.Business
{
    /// <summary>
    /// Clase para obtener la variación del costo por la estación del año.
    /// </summary>
    public class ObtenedorVariacionCostoPorEstacionAnioService : IObtenedorVariacionCostoPorEstacionAnioService
    {
        /// <summary>
        /// Método para obtener la variación del costo de la estación del año correspondiente.
        /// </summary>
        /// <param name="eEstacionesAnio">Enumerador de la estación del año.</param>
        /// <returns>Retorna el valor de la variación del costo en base a la estación del año que se recibe como parámetro.</returns>
        public int ObtenerVariacionCosto(eEstacionesAnio eEstacionesAnio)
        {
            int iVariacion = 0;

            switch (eEstacionesAnio)
            {
                case eEstacionesAnio.Primavera:
                    iVariacion = 0;
                    break;
                case eEstacionesAnio.Invierno:
                    iVariacion = 23;
                    break;
                case eEstacionesAnio.Verano:
                    iVariacion = 10;
                    break;
                case eEstacionesAnio.Otonio:
                    iVariacion = 15;
                    break;
            }

            return iVariacion;
        }
    }
}