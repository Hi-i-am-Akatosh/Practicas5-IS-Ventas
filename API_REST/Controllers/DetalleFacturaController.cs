using AcessoDatos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace API_REST.Controllers
{
    public class DetalleFacturaController : ApiController
    {
        DetalleFacturaNegocio detalleFacturaNegocio = new DetalleFacturaNegocio();

        //Get - Listar todos
        public IHttpActionResult Get()
        {
            var respuesta = detalleFacturaNegocio.All();
            return Ok(respuesta);
        }
        //Get - Mostrar por ID
        public IHttpActionResult Get(int id)
        {
            DetalleFactura detalleFactura= detalleFacturaNegocio.ById(id);
            if (detalleFactura != null)
            {
                return Ok(detalleFactura);
            }
            return NotFound();
        }
        //Post - Insertar un nuevo Cliente
        public IHttpActionResult Post(DetalleFactura detalleFactura)
        {
            detalleFacturaNegocio.Nuevo(detalleFactura);
            return Ok("Insertado correctamente");
        }
        //Put - Para actualizar cliente.
        public IHttpActionResult Put(DetalleFactura detalleFactura)
        {
            detalleFacturaNegocio.Actualizar(detalleFactura);
            return Ok("Detalle factura actualizado");
        }
        //Delete - Para eliminar cliente.
        public IHttpActionResult Delete(DetalleFactura detalleFactura)
        {
            detalleFacturaNegocio.Eliminar(detalleFactura);
            return Ok("Detalle factura eliminado");
        }
    }
}