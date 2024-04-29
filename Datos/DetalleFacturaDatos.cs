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
    public class DetalleFacturaDatos : IDatos<DetalleFactura>
    {
        ServiciosEntities contexto;
        public DetalleFacturaDatos()
        {
            contexto = new ServiciosEntities();
        }
        public bool Actualizar(DetalleFactura item)
        {
            DetalleFactura te = BuscarID(item.id);
            if (te != null)
            {
                te.idFactura = item.idFactura;
                te.idProducto = item.idProducto;
                te.cantidad = item.cantidad;
                te.precio = item.precio;
                contexto.SaveChanges();
                return true;
            }
            else { return false; }
        }

        public bool Eliminar(DetalleFactura item)
        {
            DetalleFactura t = BuscarID(item.id);
            if (t != null)
            {
                contexto.DetalleFactura.Remove(t);
                contexto.SaveChanges();
                return true;
            }
            else { return false; }
        }

        public List<DetalleFactura> Listar()
        {
            return contexto.DetalleFactura.ToList();
        }
        public DetalleFactura BuscarID(int id)
        {
            return contexto.DetalleFactura.Where(df => df.id == id).FirstOrDefault();
        }

        public bool Nuevo(DetalleFactura detalleFactura)
        {
            if (contexto.DetalleFactura.Add(detalleFactura) != null)
            {
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }
}