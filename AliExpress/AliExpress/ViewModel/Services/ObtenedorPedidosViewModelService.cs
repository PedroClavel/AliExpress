using AliExpress.Data.Entities.DTO;
using AliExpress.Interfaces.AliExpress.ViewModel;
using AliExpress.Interfaces.Business;
using System;
using System.Collections.Generic;

namespace AliExpress.ViewModel.Services
{
    /// <summary>
    /// Clase para obtener los datos del pedido.
    /// </summary>
    public class ObtenedorPedidosViewModelService : IObtenedorPedidosViewModelService
    {
        /// <summary>
        /// Propiedad para asignar la interfaz IObtenedorDatosArchivoService;
        /// </summary>
        private readonly IObtenedorDatosArchivoService srvObtenedorDatosArchivoService;

        /// <summary>
        /// Constructor de la clase ObtenedorPedidosViewModelService.
        /// </summary>
        public ObtenedorPedidosViewModelService(IObtenedorDatosArchivoService srvObtenedorDatosArchivoService)
        {
            this.srvObtenedorDatosArchivoService = srvObtenedorDatosArchivoService ?? throw new ArgumentNullException(nameof(srvObtenedorDatosArchivoService));
        }

        /// <summary>
        /// Método para obtener la lista de pedidos.
        /// </summary>
        /// <param name="cRutaArchivo">Ruta del archivo en donde se obtiene la lista de los pedidos.</param>
        /// <returns>Retorna una lista con los datos de los pedidos.</returns>
        public List<DatosPedidoDTO> ObtenerListaPedidos(string cRutaArchivo)
        {
            var lstPedidos = new List<DatosPedidoDTO>();

            var lstDatosArchivo = this.srvObtenedorDatosArchivoService.ObtenerDatosArchivo(cRutaArchivo);

            int iRows = lstDatosArchivo.GetUpperBound(0) + 1;

            for (int iContador = 0; iContador < iRows; iContador++)
            {
                lstPedidos.Add(ObtenerPedido(iContador, lstDatosArchivo));
            }

            return lstPedidos;
        }

        /// <summary>
        /// Método privado para obtener la lista de los pedidos según la fila en donde se tenga.l
        /// </summary>
        /// <param name="iRow"></param>
        /// <param name="cDatosArchivo"></param>
        /// <returns></returns>
        private DatosPedidoDTO ObtenerPedido(int iRow, string[,] cDatosArchivo)
        {
            var datosPedido = new DatosPedidoDTO();

            datosPedido.dDistancia = Convert.ToDecimal(cDatosArchivo[iRow, 0]);
            datosPedido.cPaisDestino = cDatosArchivo[iRow, 1].ToString();
            datosPedido.cMedioTransporte = cDatosArchivo[iRow, 2].ToString();
            datosPedido.dtFechaHoraPedido = Convert.ToDateTime(cDatosArchivo[iRow, 3]);
            datosPedido.cPaisOrigen = cDatosArchivo[iRow, 4].ToString();
            datosPedido.cCuidadOrigen = cDatosArchivo[iRow, 5].ToString();
            datosPedido.cPaisDestino = cDatosArchivo[iRow, 6].ToString();
            datosPedido.cCuidadDestino = cDatosArchivo[iRow, 7].ToString();

            return datosPedido;
        }
    }
}