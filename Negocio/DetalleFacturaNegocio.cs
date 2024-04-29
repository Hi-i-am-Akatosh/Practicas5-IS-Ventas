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
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class DetalleFacturaNegocio
    {
        DetalleFacturaDatos detalleFactura;
        public DetalleFacturaNegocio()
        {
            detalleFactura = new DetalleFacturaDatos();
        }
        public bool Actualizar(DetalleFactura detalleFacturaActualizado)
        {
            return detalleFactura.Actualizar(detalleFacturaActualizado);
        }

        public List<DetalleFactura> All()
        {
            return detalleFactura.Listar();
        }
        public DetalleFactura ById(int id)
        {
            return detalleFactura.Listar().Where(df => df.id == id).SingleOrDefault();
        }
        public bool Nuevo(DetalleFactura detalleFacturaNuevo)
        {
            return detalleFactura.Nuevo(detalleFacturaNuevo);
        }

        public bool Eliminar(DetalleFactura detalleFacturaEliminar)
        {
            return detalleFactura.Eliminar(detalleFacturaEliminar);
        }
    }
}
