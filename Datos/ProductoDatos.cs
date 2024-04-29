using AcessoDatos;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ProductoDatos : IDatos<Producto>
    {
        ServiciosEntities contexto;

        public ProductoDatos()
        {
            contexto = new ServiciosEntities();
        }
        
        //public ObjectResult listarClientesCategoria() 
        //{
        //    return contexto.SP_Clientes();
        //}

        public List<Producto> Listar()
        {
            return contexto.Producto.ToList();
        }

        public bool Nuevo(Producto producto)
        {
            if (contexto.Producto.Add(producto) != null)
            {
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public Producto BuscarID(int id)
        {
            return contexto.Producto.Where(p=>p.idProducto == id).FirstOrDefault();
        }

        public bool Actualizar(Producto item)
        {
            Producto te = BuscarID(item.idProducto);
            if (te != null)
            {
                //tem.nombre = item.nombre;
                te.nombre = item.nombre;
                te.precio_unitario = item.precio_unitario;
                te.iva = item.iva;
                contexto.SaveChanges();
                return true;
            }
            else { return false; }
        }

        public bool Eliminar(Producto item)
        {
            Producto temporal = BuscarID(item.idProducto);
            if (temporal != null) 
            {
                contexto.Producto.Remove(temporal);
                contexto.SaveChanges();
                return true;
            }
            else {return false;}
        }
    }
}
