using AliExpress.Data.Entities.DTO;
using AliExpress.Interfaces.Business;
using AliExpress.Interfaces.Business.Factory;
using System;

namespace AliExpress.Business
{
    public class CalculadorCostoServicio : ICalculadorCostoServicio
    {
        private readonly IObtenedorMediosTransporteService obtenedorMediosTransporteService;
        private readonly IObtenedorTipoPaqueteriaService obtenedorTipoPaqueteriaService;
        private readonly IObtenedorInstanciaCalculoCostoEnvioFactory obtenedorInstanciaCalculoCostoEnvioFactory;
        private readonly IObtenedorInstanciaMargenUtilidadFactory obtenedorInstanciaMargenUtilidadFactory;

        public CalculadorCostoServicio(IObtenedorMediosTransporteService obtenedorMediosTransporteService, IObtenedorTipoPaqueteriaService obtenedorTipoPaqueteriaService, IObtenedorInstanciaCalculoCostoEnvioFactory obtenedorInstanciaCalculoCostoEnvioFactory, IObtenedorInstanciaMargenUtilidadFactory obtenedorInstanciaMargenUtilidadFactory)
        {
            this.obtenedorMediosTransporteService = obtenedorMediosTransporteService ?? throw new ArgumentNullException(nameof(obtenedorMediosTransporteService));
            this.obtenedorTipoPaqueteriaService = obtenedorTipoPaqueteriaService ?? throw new ArgumentNullException(nameof(obtenedorTipoPaqueteriaService));
            this.obtenedorInstanciaCalculoCostoEnvioFactory = obtenedorInstanciaCalculoCostoEnvioFactory ?? throw new ArgumentNullException(nameof(obtenedorInstanciaCalculoCostoEnvioFactory));
            this.obtenedorInstanciaMargenUtilidadFactory = obtenedorInstanciaMargenUtilidadFactory ?? throw new ArgumentNullException(nameof(obtenedorInstanciaMargenUtilidadFactory));
        }

        public decimal CalcularCostoServicio(DatosPedidoDTO datosPedidoDTO)
        {
            var dCostoServicio = 0M;
            var eMedioTransporte = obtenedorMediosTransporteService.ObtenerMedioTransporte(datosPedidoDTO.cMedioTransporte);
            var ePaqueteria = obtenedorTipoPaqueteriaService.ObtenerTipoPaqueteria(datosPedidoDTO.cPaqueteria);

            var srvCalculadorCosto = obtenedorInstanciaCalculoCostoEnvioFactory.CrearInstancia(eMedioTransporte);
            var obtenedorMargenUtilidadPaqueteria = obtenedorInstanciaMargenUtilidadFactory.CrearInstancia(ePaqueteria);

            var dCostoTransporte = srvCalculadorCosto.CalcularCostoEnvio(datosPedidoDTO);
            var dMargenUtilidad = obtenedorMargenUtilidadPaqueteria.ObtenerMargenUtilidad(datosPedidoDTO.dtFechaHoraPedido);

            dCostoServicio = dCostoTransporte * (1 + dMargenUtilidad); 

            return dCostoServicio;
        }
    }
}
