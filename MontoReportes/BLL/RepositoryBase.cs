using MontoReportes.DAL;
using MontoReportes.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MontoReportes.BLL
{
    class RepositoryBase<T>: IDisposable,IRepository<T>where T: class
    {
        internal Contexto _contexto;

        public RepositoryBase()
        {
            _contexto = new Contexto();

        }

        public virtual bool Guardar(T entity)
        {
            bool paso = false;
            try
            {
                if (_contexto.Set<T>().Add(entity) != null)
                    paso = _contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public virtual bool Modificar(T entity)
        {
            Monto monto = new Monto();
            var anterior = this.Buscar(monto.MontoId);
            bool paso = false;
            try
            {
                foreach (var item in monto.Cuentas)
                {

                    if (monto.Cuentas.Exists(d => d.ID == item.ID))
                        _contexto.Entry(item).State = EntityState.Deleted;
                    // paso = _contexto.SaveChanges() > 0;
                }
                foreach(var item in monto.Cuentas)
                {
                    var estado = (item.ID == 0) ? EntityState.Added : EntityState.Modified;
                    _contexto.Entry(item).State = estado;
                }
                _contexto.Entry(monto).State = EntityState.Modified;

             if( _contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                

               
            }
            
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _contexto.Dispose();
            }
            return paso;
        }
        public virtual bool Eliminar(int id)
        {
            bool paso = false;
            try
            {
                T entity = _contexto.Set<T>().Find(id);
                _contexto.Set<T>().Remove(entity);

                paso = _contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public virtual T Buscar(int id)
        {
            T entity;
            try
            {
                entity = _contexto.Set<T>().Find(id);

            }
            catch (Exception)
            {
                throw;
            }
            return entity;
        }

        public List<T> GetList(Expression<Func<T, bool>> expression)
        {
            List<T> Lista = new List<T>();
            try
            {
                Lista = _contexto.Set<T>().Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return Lista;
        }

        public void Dispose()
        {
            _contexto.Dispose();
            throw new NotImplementedException();
        }
    }
}
