namespace AliExpress.Interfaces.Business
{
    public interface ITruncadorDecimales
    {
        /// <summary>
        /// Método para truncar los decimales.
        /// </summary>
        /// <param name="valor">Valor decimal a truncar.</param>
        /// <returns>Retorna el Valor truncado.</returns>
        decimal TruncarNumero(decimal valor);
    }
}
