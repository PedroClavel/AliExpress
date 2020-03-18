using AliExpress.Data.Entities.Enumeradores;
using AliExpress.Interfaces.Business.Factory;
using AliExpress.Interfaces.Business.Strategy;
using AliExpress.Interfaces.ContenedorDependencias;
using System;

namespace AliExpress.Business.Factory
{
    public class ObtenedorInstanciaTiempoTrasladoMedioTransporteFactory : IObtenedorInstanciaTiempoTrasladoMedioTransporteFactory
    {
        private readonly ICreadorInstanciaFabricaGenerica creadorInstanciaFabricaGenerica;

        public ObtenedorInstanciaTiempoTrasladoMedioTransporteFactory(ICreadorInstanciaFabricaGenerica creadorInstanciaFabricaGenerica)
        {
            this.creadorInstanciaFabricaGenerica = creadorInstanciaFabricaGenerica ?? throw new ArgumentNullException(nameof(creadorInstanciaFabricaGenerica));
        }

        /// <summary>
        /// Método para crear la instancia de la clase que calculará el costo de envío con base al medio de transporte que se tenga.
        /// </summary>
        /// <param name="eMedioTransporte">Medio de transporte.</param>
        /// <returns>Retorna la instancia de la clase correspondiente de tipo ICalculadorCostoEnvioMedioTransporte.</returns>
        public ICalculadorTiempoTrasladoMedioTransporte CrearInstancia(eMediosTransporte eMediosTransporte)
        {
            ICalculadorTiempoTrasladoMedioTransporte calculadorTiempoTrasladoMedioTransporte = null;

            switch (eMediosTransporte)
            {
                case eMediosTransporte.Maritimo:
                    calculadorTiempoTrasladoMedioTransporte = creadorInstanciaFabricaGenerica.CrearInstancia<ICalculadorTiempoTrasladoMedioTransporte>("CalculadorTiempoTrasladoAereoStrategy");
                    break;
                case eMediosTransporte.Terrestre:
                    calculadorTiempoTrasladoMedioTransporte = creadorInstanciaFabricaGenerica.CrearInstancia<ICalculadorTiempoTrasladoMedioTransporte>("CalculadorTiempoTrasladoMaritimoStrategy");
                    break;
                case eMediosTransporte.Aereo:
                    calculadorTiempoTrasladoMedioTransporte = creadorInstanciaFabricaGenerica.CrearInstancia<ICalculadorTiempoTrasladoMedioTransporte>("CalculadorTiempoTrasladoTerrestreStrategy");
                    break;
            }

            return calculadorTiempoTrasladoMedioTransporte;
        }
    }
}
