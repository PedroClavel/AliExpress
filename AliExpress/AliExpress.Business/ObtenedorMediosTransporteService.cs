using AliExpress.Data.Entities.Enumeradores;
using AliExpress.Interfaces.Business;

namespace AliExpress.Business
{
    public class ObtenedorMediosTransporteService : IObtenedorMediosTransporteService
    {
        public eMediosTransporte ObtenerMedioTransporte(string cMedioTransporte)
        {
            var eMedioTransporte = new eMediosTransporte();

            if (cMedioTransporte.ToUpper() == "MARÍTIMO" || cMedioTransporte.ToUpper() == "MARiTIMO")
            {
                eMedioTransporte = eMediosTransporte.Maritimo;
            }
            else if (cMedioTransporte.ToUpper() == "TERRESTRE")
            {
                eMedioTransporte = eMediosTransporte.Terrestre;
            }
            else if (cMedioTransporte.ToUpper() == "AÉREO" || cMedioTransporte.ToUpper() == "AEREO")
            {
                eMedioTransporte = eMediosTransporte.Aereo;
            }

            return eMedioTransporte;
        }
    }
}
