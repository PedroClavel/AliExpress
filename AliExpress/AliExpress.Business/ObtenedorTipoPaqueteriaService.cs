using AliExpress.Data.Entities.Enumeradores;
using AliExpress.Interfaces.Business;
using System;

namespace AliExpress.Business
{
    public class ObtenedorTipoPaqueteriaService : IObtenedorTipoPaqueteriaService
    {
        /// <summary>
        /// Método para obtener el tipo  de paquetería con base al pedido realizado.
        /// </summary>
        /// <param name="cPaqueteria">Nombre de la paquetería.</param>
        /// <returns>Retorna un tipo especifico de la paquetería.</returns>
        public ePaqueteria ObtenerTipoPaqueteria(string cPaqueteria)
        {
            var ePaqueteria = new ePaqueteria();

            if (cPaqueteria.ToUpper() == "FEDEX")
            {
                ePaqueteria = ePaqueteria.Fedex;
            }
            else if (cPaqueteria.ToUpper() == "DHL")
            {
                ePaqueteria = ePaqueteria.DHL;
            }
            else if (cPaqueteria.ToUpper() == "ESTAFETA")
            {
                ePaqueteria = ePaqueteria.Estafeta;
            }

            return ePaqueteria;
        }
    }
}
