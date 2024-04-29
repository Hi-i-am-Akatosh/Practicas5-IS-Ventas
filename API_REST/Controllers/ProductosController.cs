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
    public class ProductosController : ApiController
    {
        ProductoNegocio productoNegocio = new ProductoNegocio();
        //Get - Listar todos

        public IHttpActionResult Get()
        {
            var respuesta = productoNegocio.All();
            return Ok(respuesta);
        }

        //Get - Mostrar por ID
        public IHttpActionResult Get(int id)
        {
            Producto producto = productoNegocio.ById(id);
            if(producto != null)
            {
                return Ok(producto);
            }
            return NotFound();
        }
        //Post - Insertar un nuevo Producto
        public IHttpActionResult Post(Producto producto)
        {
            productoNegocio.Nuevo(producto);
            return Ok("Insertado correctamente");
        }

        //Put - Para actualizar un producto.
        public IHttpActionResult Put(Producto producto)
        {
            productoNegocio.Actualizar(producto);
            return Ok("Producto actulizado");
        }


        //Delete - Para eliminar un producto.

        public IHttpActionResult Delete(Producto producto)
        {
            productoNegocio.Eliminar(producto);
            return Ok("Producto eliminado");
        }
    }
}