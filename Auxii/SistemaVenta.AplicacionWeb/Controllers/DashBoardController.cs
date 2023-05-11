﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaVenta.AplicacionWeb.Models.DTOs;
using SistemaVenta.AplicacionWeb.Utilidades.Response;
using SistemaVenta.BLL.Interfaces;

namespace SistemaVenta.AplicacionWeb.Controllers
{
    [Authorize]
    public class DashBoardController : Controller
    {
        private readonly IDashBoardService _dashBoardService;

        public DashBoardController(IDashBoardService dashBoardService)
        {
            _dashBoardService = dashBoardService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerResumen()
        {
            GenericResponse<DashBoardDTO> response = new GenericResponse<DashBoardDTO>();
            try
            {
                DashBoardDTO dashBoard = new DashBoardDTO();
                List<MovimientosSemanaDTO> listaMovimientosSemana = new List<MovimientosSemanaDTO>();
                List<ProductoSemanaDTO> listProductoSemana = new List<ProductoSemanaDTO>();

                foreach(KeyValuePair<string,int> item in await _dashBoardService.MovimientosUltimaSemana())
                {
                    listaMovimientosSemana.Add(new MovimientosSemanaDTO()
                    {
                        Fecha = item.Key,
                        Total = item.Value
                    });
                }
                foreach (KeyValuePair<string, int> item in await _dashBoardService.ProductosTopUltimaSemana())
                {
                    listProductoSemana.Add(new ProductoSemanaDTO()
                    {
                        Producto = item.Key,
                        Cantidad = item.Value
                    });
                }

                dashBoard.TotalMovimientos = await _dashBoardService.TotalMovimientoUltimaSemana();
                dashBoard.TotalIngresos = await _dashBoardService.TotalIngresoUltimaSemana();
                dashBoard.TotalProductos = await _dashBoardService.TotalProductos();
                dashBoard.TotalCategorias = await _dashBoardService.TotalCategorias();
                dashBoard.MovimientosUltimaSemana = listaMovimientosSemana;
                dashBoard.ProductosTopUltimaSemana = listProductoSemana;

                response.Estado = true;
                response.Objeto = dashBoard;

            }
            catch (Exception ex)
            {

                response.Estado = false;
                response.Mensaje = ex.Message;
            }
            return StatusCode(StatusCodes.Status200OK,response);
        }
    }
}
