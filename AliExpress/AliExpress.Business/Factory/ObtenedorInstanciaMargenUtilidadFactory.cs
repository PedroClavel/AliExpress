using AliExpress.Data.Entities.Enumeradores;
using AliExpress.Interfaces.Business.Factory;
using AliExpress.Interfaces.Business.Strategy;
using AliExpress.Interfaces.ContenedorDependencias;
using System;

namespace AliExpress.Business.Factory
{
    public class ObtenedorInstanciaMargenUtilidadFactory : IObtenedorInstanciaMargenUtilidadFactory
    {
        private readonly ICreadorInstanciaFabricaGenerica creadorInstanciaFabricaGenerica;

        public ObtenedorInstanciaMargenUtilidadFactory(ICreadorInstanciaFabricaGenerica creadorInstanciaFabricaGenerica)
        {
            this.creadorInstanciaFabricaGenerica = creadorInstanciaFabricaGenerica ?? throw new ArgumentNullException(nameof(creadorInstanciaFabricaGenerica));
        }

        /// <summary>
        /// Método para obtener el margen de utilidad de la paquetería con base a la fecha en la que se realizó el pedido.
        /// </summary>
        /// <param name="dtFechaPedido">Fecha del pedido.</param>
        /// <returns>Retorna el margen de utilidad con base a la fecha del pedido.</returns>
        public IObtenedorMargenUtilidadPaqueteria CrearInstancia(ePaqueteria ePaqueteria)
        {
            IObtenedorMargenUtilidadPaqueteria obtenedorMargenUtilidadPaqueteria = null;

            switch (ePaqueteria)
            {
                case ePaqueteria.Fedex:
                    obtenedorMargenUtilidadPaqueteria = creadorInstanciaFabricaGenerica.CrearInstancia<IObtenedorMargenUtilidadPaqueteria>("ObtenedorMargenUtilidadFedexStrategy");
                    break;
                case ePaqueteria.DHL:
                    obtenedorMargenUtilidadPaqueteria = creadorInstanciaFabricaGenerica.CrearInstancia<IObtenedorMargenUtilidadPaqueteria>("ObtenedorMargenUtilidadDHLStrategy");
                    break;
                case ePaqueteria.Estafeta:
                    obtenedorMargenUtilidadPaqueteria = creadorInstanciaFabricaGenerica.CrearInstancia<IObtenedorMargenUtilidadPaqueteria>("ObtenedorMargenUtilidadEstafetaStrategy");
                    break;
            }

            return obtenedorMargenUtilidadPaqueteria;
        }
    }
}
