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
    public class FacturaController : ApiController
    {
        FacturaNegocio facturaNegocio = new FacturaNegocio();

        //Get - Listar todos
        public IHttpActionResult Get()
        {
            var respuesta = facturaNegocio.All();
            return Ok(respuesta);
        }
        //Get - Mostrar por ID
        public IHttpActionResult Get(int id)
        {
            Factura factura = facturaNegocio.ById(id);
            if (factura!= null)
            {
                return Ok(factura);
            }
            return NotFound();
        }
        //Post - Insertar un nueva Factura
        public IHttpActionResult Post(Factura factura)
        {
            facturaNegocio.Nuevo(factura);
            return Ok("Insertado correctamente");
        }
        //Put - Para actualizar factura.
        public IHttpActionResult Put(Factura factura)
        {
            facturaNegocio.Actualizar(factura);
            return Ok("Factura actualizada");
        }
        //Delete - Para eliminar cliente.
        public IHttpActionResult Delete(Factura factura)
        {
            facturaNegocio.Eliminar(factura);
            return Ok("Factura eliminada");
        }
    }
}