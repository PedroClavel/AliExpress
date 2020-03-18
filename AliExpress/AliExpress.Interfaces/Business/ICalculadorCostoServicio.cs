using AliExpress.Data.Entities.DTO;

namespace AliExpress.Interfaces.Business
{
    public interface ICalculadorCostoServicio
    {
        decimal CalcularCostoServicio(DatosPedidoDTO datosPedidoDTO);
    }
}
