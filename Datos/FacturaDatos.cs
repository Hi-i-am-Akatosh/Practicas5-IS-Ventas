using AcessoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class FacturaDatos : IDatos<Factura>
    {
        ServiciosEntities contexto;
        public FacturaDatos()
        {
            contexto = new ServiciosEntities();
        }
        public bool Actualizar(Factura item)
        {
            Factura tem = BuscarID(item.numero);
            if (tem != null)
            {
                tem.numero = item.numero;
                tem.fecha = item.fecha;
                contexto.SaveChanges();
                return true;
            }
            else { return false; }
        }

        public bool Eliminar(Factura item)
        {
            Factura t = BuscarID(item.numero);
            if (t != null)
            {
                contexto.Factura.Remove(t);
                contexto.SaveChanges();
                return true;
            }
            else { return false; }
        }

        public List<Factura> Listar()
        {
            return contexto.Factura.ToList();
        }
        public Factura BuscarID(int numero)
        {
            return contexto.Factura.Where(f => f.numero == numero).FirstOrDefault();
        }

        public bool Nuevo(Factura factura)
        {
            if (contexto.Factura.Add(factura) != null)
            {
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }
}