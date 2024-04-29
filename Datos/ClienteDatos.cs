// NOMBRE APELLIDOS: David Fernando Navarro Rodríguez
// PARALELO: Q0106
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 28/04/2024
// PRÁCTICA No. 5
using AcessoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ClienteDatos : IDatos<Cliente>
    {
        ServiciosEntities contexto;
        public ClienteDatos()
        {
            contexto = new ServiciosEntities();
        }
        public bool Actualizar(Cliente item)
        {
            Cliente te = BuscarID(item.id);
            if (te != null)
            {
                te.nombre = item.nombre;
                te.direccion = item.direccion;
                te.telefono = item.telefono;
                te.idCategoria = item.idCategoria;
                contexto.SaveChanges();
                return true;
            }
            else { return false; }
        }

        public bool Eliminar(Cliente item)
        {
            Cliente t = BuscarID(item.id);
            if (t != null)
            {
                contexto.Cliente.Remove(t);
                contexto.SaveChanges();
                return true;
            }
            else { return false; }
        }

        public List<Cliente> Listar()
        {
            return contexto.Cliente.ToList();
        }
        public Cliente BuscarID(int id)
        {
            return contexto.Cliente.Where(cli => cli.id == id).FirstOrDefault();
        }

        public bool Nuevo(Cliente cliente)
        {
            if (contexto.Cliente.Add(cliente) != null)
            {
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }
}