using AcessoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CategoriaDatos : IDatos<Categoria>
    {
        ServiciosEntities contexto;
        public CategoriaDatos()
        {
            contexto = new ServiciosEntities();
        }
        public bool Actualizar(Categoria item)
        {
            Categoria tem = BuscarID(item.id);
            if (tem != null)
            {
                tem.nombre = item.nombre;
                contexto.SaveChanges();
                return true;
            }
            else { return false; }
        }

        public bool Eliminar(Categoria item)
        {
            Categoria t = BuscarID(item.id);
            if (t != null)
            {
                contexto.Categoria.Remove(t);
                contexto.SaveChanges();
                return true;
            }
            else { return false; }
        }

        public List<Categoria> Listar()
        {
            return contexto.Categoria.ToList();
        }
        public Categoria BuscarID(int id)
        {
            return contexto.Categoria.Where(cat => cat.id == id).FirstOrDefault();
        }

        public bool Nuevo(Categoria categoria)
        {
            if (contexto.Categoria.Add(categoria) != null)
            {
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }
}