﻿using AliExpress.Data.Entities.Enumeradores;
using AliExpress.Interfaces.Business.Strategy;

namespace AliExpress.Interfaces.Business.Factory
{
    public interface IObtenedorInstanciaTiempoTrasladoMedioTransporteFactory
    {
        /// <summary>
        /// Método para crear la instancia de la clase que calculará el tiempo de traslado con base al medio de transporte que se tenga.
        /// </summary>
        /// <param name="eMedioTransporte">Medio de transporte.</param>
        /// <returns>Retorna la instancia de la clase correspondiente de tipo ICalculadorTiempoTrasladoMedioTransporte.</returns>
        ICalculadorTiempoTrasladoMedioTransporte CrearInstancia(eMediosTransporte eMediosTransporte);
    }
}
