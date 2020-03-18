using System;

namespace AliExpress.Data.Entities.DTO
{
    /// <summary>
    /// Clase de tipo DTO con los datos del pedido.
    /// </summary>
    public class DatosPedidoDTO
    {
        /// <summary>
        /// Propiedad para obtener la distancia.
        /// </summary>
        public decimal dDistancia { get; set; }

        /// <summary>
        /// Propiedad para obtener el nombre de la paquetera que emite el paquete.
        /// </summary>
        public string cPaqueteria { get; set; }

        /// <summary>
        /// Propiedad para el medio de transporte en el que se trae el paquete.
        /// </summary>
        public string cMedioTransporte { get; set; }

        /// <summary>
        /// Propiedad para obtener la Fecha y la hora en la que emitió el pedido.
        /// </summary>
        public DateTime dtFechaHoraPedido { get; set; }

        /// <summary>
        /// Propiedad para obtener el país de origen en donde se realizó el pedido.
        /// </summary>
        public string cPaisOrigen { get; set; }

        /// <summary>
        /// Propiedad para obtener la cuidad de origen en donde se realizó el pedido.
        /// </summary>
        public string cCuidadOrigen { get; set; }

        /// <summary>
        /// Propiedad para obtener el país de destino en donde se enviará el pedido.
        /// </summary>
        public string cPaisDestino { get; set; }

        /// <summary>
        /// Propiedad para obtener la cuidad de destino en donde se enviará el pedido.
        /// </summary>
        public string cCuidadDestino { get; set; }
    }
}