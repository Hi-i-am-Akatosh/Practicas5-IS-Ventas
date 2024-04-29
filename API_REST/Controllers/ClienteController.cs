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
    public class ClienteController : ApiController
    {
        ClienteNegocio clienteNegocio = new ClienteNegocio();

        //Get - Listar todos
        public IHttpActionResult Get()
        {
            var respuesta = clienteNegocio.All();
            return Ok(respuesta);
        }
        //Get - Mostrar por ID
        public IHttpActionResult Get(int id)
        {
            Cliente cliente = clienteNegocio.ById(id);
            if(cliente != null)
            {
                return Ok(cliente);
            }
            return NotFound();
        }
        //Post - Insertar un nuevo Cliente
        public IHttpActionResult Post(Cliente cliente) 
        { 
            clienteNegocio.Nuevo(cliente);
            return Ok("Insertado correctamente");
        }
        //Put - Para actualizar cliente.
        public IHttpActionResult Put(Cliente cliente)
        {
            clienteNegocio.Actualizar(cliente);
            return Ok("Cliente actualizado");
        }
        //Delete - Para eliminar cliente.
        public IHttpActionResult Delete(Cliente cliente) 
        { 
            clienteNegocio.Eliminar(cliente);
            return Ok("Cliente eliminado");
        }
    }
}