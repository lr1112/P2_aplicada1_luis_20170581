using Microsoft.EntityFrameworkCore;
using segundo_parcial.DAL;
using segundo_parcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace segundo_parcial.BLL
{
    public class TiposTareaBLL
    {
        public static TiposTarea Buscar(int id)
        {
            Contexto context = new Contexto();
            TiposTarea producto;

            try
            {
                producto = context.TiposTarea
                    .Where(t => t.TipoId == id)
                    .SingleOrDefault();
            }
            catch
            {
                throw;
            }
            finally
            {
                context.Dispose();
            }

            return producto;
        }
        public static List<TiposTarea> ObtenerLista(Expression<Func<TiposTarea, bool>> criterio)
        {
            List<TiposTarea> lista = new List<TiposTarea>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.TiposTarea.Where(criterio).AsNoTracking().ToList();
            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }
    }
}
