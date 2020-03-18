using AliExpress.Interfaces.Business;
using System;

namespace AliExpress.Business
{
    public class TruncadorDecimales : ITruncadorDecimales
    {
        /// <summary>
        /// Método para truncar los decimales.
        /// </summary>
        /// <param name="valor">Valor decimal a truncar.</param>
        /// <returns>Retorna el Valor truncado.</returns>
        public decimal TruncarNumero(decimal valor)
        {
            decimal result = 0.0M;
            decimal dMultiplo = (long)Math.Pow(10, 1);
            decimal dAjuste = valor * dMultiplo;

            decimal other = dAjuste < 0 ? (long)Math.Ceiling(dAjuste) : (long)Math.Floor(dAjuste);

            result = other / dMultiplo;

            return result;
        }
    }
}
