using DinetModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DinetApi.Controllers
{
    [RoutePrefix("api/Inventario")]
    public class InventarioController : BaseController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAll()
        {
            return Ok(unitOfWork.Inventario.ObtenerTodos());
        }

        [HttpGet]
        [Route("fechas")]
        public IHttpActionResult ObtenerPorFechas(DateTime fechaInicio, DateTime fechaFin, string tipoMovimiento, string nroDocumento)
        {
            return Ok(unitOfWork.Inventario.ObtenerPorFecha(fechaInicio, fechaFin, tipoMovimiento, nroDocumento));
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Crear(Inventario inventario)
        {
            unitOfWork.Inventario.Crear(inventario);

            return Ok(new { inserted = true });
        }
    }
}