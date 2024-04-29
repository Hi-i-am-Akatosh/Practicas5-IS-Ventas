using AcessoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CategoriaNegocio
    {
        CategoriaDatos categoria;
        public CategoriaNegocio()
        {
            categoria = new CategoriaDatos();
        }
        public bool Actualizar(Categoria categoriaActualizado)
        {
            return categoria.Actualizar(categoriaActualizado);
        }

        public List<Categoria> All()
        {
            return categoria.Listar();
        }
        public Categoria ById(int id)
        {
            return categoria.Listar().Where(p => p.id == id).SingleOrDefault();
        }
        public bool Nuevo(Categoria categoriaNuevo)
        {
            return categoria.Nuevo(categoriaNuevo);
        }

        public bool Eliminar(Categoria categoriaEliminar)
        {
            return categoria.Eliminar(categoriaEliminar);
        }
    }
}
