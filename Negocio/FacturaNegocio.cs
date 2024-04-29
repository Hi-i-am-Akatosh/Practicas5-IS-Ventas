using AcessoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class FacturaNegocio
    {
        FacturaDatos factura;
        public FacturaNegocio()
        {
            factura = new FacturaDatos();
        }
        public bool Actualizar(Factura facturaActualizado)
        {
            return factura.Actualizar(facturaActualizado);
        }

        public List<Factura> All()
        {
            return factura.Listar();
        }
        public Factura ById(int id) //REVISAR POSIBLE ERROR
        {
            return factura.Listar().Where(f => f.numero == id).SingleOrDefault();
        }
        public bool Nuevo(Factura facturaNuevo)
        {
            return factura.Nuevo(facturaNuevo);
        }

        public bool Eliminar(Factura facturaEliminar)
        {
            return factura.Eliminar(facturaEliminar);
        }
    }
}
