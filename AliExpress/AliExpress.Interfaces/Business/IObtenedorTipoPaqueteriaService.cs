using AliExpress.Data.Entities.Enumeradores;

namespace AliExpress.Interfaces.Business
{
    public interface IObtenedorTipoPaqueteriaService
    {
        /// <summary>
        /// Método para obtener el tipo  de paquetería con base al pedido realizado.
        /// </summary>
        /// <param name="cPaqueteria">Nombre de la paquetería.</param>
        /// <returns>Retorna un tipo especifico de la paquetería.</returns>
        ePaqueteria ObtenerTipoPaqueteria(string cPaqueteria);
    }
}
