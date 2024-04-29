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
    public class CategoriaController : ApiController
    {
        CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

        //Get - Listar todos
        public IHttpActionResult Get()
        {
            var respuesta = categoriaNegocio.All();
            return Ok(respuesta);
        }
        //Get - Mostrar por ID
        public IHttpActionResult Get(int id)
        {
            Categoria categoria = categoriaNegocio.ById(id);
            if (categoria != null)
            {
                return Ok(categoria);
            }
            return NotFound();
        }
        //Post - Insertar un nuevo Categoria
        public IHttpActionResult Post(Categoria categoria)
        {
            categoriaNegocio.Nuevo(categoria);
            return Ok("Insertado correctamente");
        }
        //Put - Para actualizar Categoria.
        public IHttpActionResult Put(Categoria categoria)
        {
            categoriaNegocio.Actualizar(categoria);
            return Ok("Categoria actualizado");
        }
        //Delete - Para eliminar Categoria.
        public IHttpActionResult Delete(Categoria categoria)
        {
            categoriaNegocio.Eliminar(categoria);
            return Ok("Categoria eliminado");
        }
    }
}