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

namespace Negocio
{
    public class ProductoNegocio
    {

        ProductoDatos productos;
        public ProductoNegocio()
        {
            productos = new ProductoDatos();
        }

        public bool Actualizar(Producto productoActualizado)
        {
            return productos.Actualizar(productoActualizado);
        }

        public List<Producto> All()
        {
            return productos.Listar();
        }
        public Producto ById(int id)
        {
            return productos.Listar().Where(p => p.idProducto == id).SingleOrDefault();
        }
        public bool Nuevo(Producto productoNuevo)
        {
            return productos.Nuevo(productoNuevo);
        }
        
        public bool Eliminar(Producto productoEliminar)
        {
            return productos.Eliminar(productoEliminar);
        }
    }
}
