using AliExpress.Data.Entities.Enumeradores;
using AliExpress.Interfaces.Business;

namespace AliExpress.Business
{
    /// <summary>
    /// Clase para obtener la variación por velocidad de la estación del año.
    /// </summary>
    public class ObtenedorVariacionVelocidadPorEstacionAnioService : IObtenedorVariacionVelocidadPorEstacionAnioService
    {
        /// <summary>
        /// Método para obtener la variación de velocidad de la estación del año correspondiente.
        /// </summary>
        /// <param name="eEstacionesAnio">Enumerador de la estación del año.</param>
        /// <returns>Retorna el valor de la variación de la velocidad en base a la estación del año que se recibe como parámetro.</returns>
        public int ObtenerVariacionVelocidad(eEstacionesAnio eEstacionesAnio)
        {
            int iVariacion = 0;

            switch (eEstacionesAnio)
            {
                case eEstacionesAnio.Primavera:
                    iVariacion = 0;
                    break;
                case eEstacionesAnio.Invierno:
                    iVariacion = -30;
                    break;
                case eEstacionesAnio.Verano:
                    iVariacion = -10;
                    break;
                case eEstacionesAnio.Otonio:
                    iVariacion = 15;
                    break;
            }

            return iVariacion;
        }
    }
}