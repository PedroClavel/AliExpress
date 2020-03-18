using AliExpress.Data.Entities.Enumeradores;
using AliExpress.Interfaces.Business.Factory;
using AliExpress.Interfaces.Business.Strategy;
using AliExpress.Interfaces.ContenedorDependencias;
using System;

namespace AliExpress.Business.Factory
{
    public class ObtenedorInstanciaCalculoCostoEnvioFactory : IObtenedorInstanciaCalculoCostoEnvioFactory
    {
        private readonly ICreadorInstanciaFabricaGenerica creadorInstanciaFabricaGenerica;

        public ObtenedorInstanciaCalculoCostoEnvioFactory(ICreadorInstanciaFabricaGenerica creadorInstanciaFabricaGenerica)
        {
            this.creadorInstanciaFabricaGenerica = creadorInstanciaFabricaGenerica ?? throw new ArgumentNullException(nameof(creadorInstanciaFabricaGenerica));
        }

        /// <summary>
        /// Método para crear la instancia de la clase que calculará el costo de envío con base al medio de transporte que se tenga.
        /// </summary>
        /// <param name="eMedioTransporte">Medio de transporte.</param>
        /// <returns>Retorna la instancia de la clase correspondiente de tipo ICalculadorCostoEnvioMedioTransporte.</returns>
        public ICalculadorCostoEnvioMedioTransporte CrearInstancia(eMediosTransporte eMedioTransporte)
        {
            ICalculadorCostoEnvioMedioTransporte calculadorCostoEnvioMedioTransporte = null;

            switch (eMedioTransporte)
            {
                case eMediosTransporte.Aereo:
                    calculadorCostoEnvioMedioTransporte = creadorInstanciaFabricaGenerica.CrearInstancia<ICalculadorCostoEnvioMedioTransporte>("CalculadorCostoEnvioAereoStrategy");
                    break;
                case eMediosTransporte.Maritimo:
                    calculadorCostoEnvioMedioTransporte = creadorInstanciaFabricaGenerica.CrearInstancia<ICalculadorCostoEnvioMedioTransporte>("CalculadorCostoEnvioMaritimoStrategy");
                    break;
                case eMediosTransporte.Terrestre:
                    calculadorCostoEnvioMedioTransporte = creadorInstanciaFabricaGenerica.CrearInstancia<ICalculadorCostoEnvioMedioTransporte>("CalculadorCostoEnvioTerrestreStrategy");
                    break;
            }

            return calculadorCostoEnvioMedioTransporte;
        }
    }
}