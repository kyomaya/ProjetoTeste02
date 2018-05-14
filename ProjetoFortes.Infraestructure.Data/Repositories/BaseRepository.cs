using ProjetoFortes.Domain.Interface.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ProjetoFortes.Infraestrutura.Data.Repositories
{
    public class BaseRepository<TEntity> :  IBaseRepository<TEntity> where TEntity :class
    {
        protected Contexto contexto = new Contexto();

        public void Add(TEntity obj)
        {
            contexto.Set<TEntity>().Add(obj);
            contexto.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return contexto.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> GetAllNoTracking()
        {
            return contexto.Set<TEntity>().AsNoTracking().ToList();
        }

        public TEntity GetById(int id)
        {
            return contexto.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            contexto.Set<TEntity>().Remove(obj);
            contexto.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            contexto.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
    }
}
