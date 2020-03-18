using AliExpress.Data.Entities.Enumeradores;
using AliExpress.Interfaces.Business.Strategy;

namespace AliExpress.Interfaces.Business.Factory
{
    public interface IObtenedorInstanciaMargenUtilidadFactory
    {
        /// <summary>
        /// Método para obtener la instancia del servicio de paqueterias.
        /// </summary>
        /// <param name="ePaqueteria">Enumerador Paqueterias.</param>
        /// <returns>Retorna una instancia de tipo IObtenedorMargenUtilidadPaqueteria.</returns>
        IObtenedorMargenUtilidadPaqueteria CrearInstancia(ePaqueteria ePaqueteria);
    }
}
