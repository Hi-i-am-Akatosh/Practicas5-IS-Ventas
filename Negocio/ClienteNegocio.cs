using AcessoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteNegocio
    {
        ClienteDatos clientes;
        public ClienteNegocio()
        {
            clientes = new ClienteDatos();
        }
        public bool Actualizar(Cliente clienteActualizado)
        {
            return clientes.Actualizar(clienteActualizado);
        }

        public List<Cliente> All()
        {
            return clientes.Listar();
        }
        public Cliente ById(int id)
        {
            return clientes.Listar().Where(cli => cli.id == id).SingleOrDefault();
        }
        public bool Nuevo(Cliente clienteNuevo)
        {
            return clientes.Nuevo(clienteNuevo);
        }

        public bool Eliminar(Cliente clienteEliminar)
        {
            return clientes.Eliminar(clienteEliminar);
        }
    }
}
