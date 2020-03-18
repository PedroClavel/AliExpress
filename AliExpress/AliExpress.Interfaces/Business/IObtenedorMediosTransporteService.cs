using AliExpress.Data.Entities.Enumeradores;

namespace AliExpress.Interfaces.Business
{
    public interface IObtenedorMediosTransporteService
    {
        eMediosTransporte ObtenerMedioTransporte(string cMedioTransporte);
    }
}
