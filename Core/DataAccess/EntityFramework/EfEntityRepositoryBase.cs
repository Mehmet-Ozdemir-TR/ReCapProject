using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity ,TContext> : IEntityRepository <TEntity>
        where TEntity: class , IEntity , new()
        where TContext: DbContext , new() 
    {
        public void Add(TEntity item)
        {


            using (TContext context = new TContext())
            {
                var addedItem = context.Entry(item); //referansı yakala 
                addedItem.State = EntityState.Added; // bu nesne eklenicek
                context.SaveChanges(); //Nesneyi ekle 
            }


        }

        public void Delete(TEntity item)
        {
            using (TContext context = new TContext())
            {
                var deletedItem = context.Entry(item);
                deletedItem.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity item)
        {
            using (TContext context = new TContext())
            {
                var updatedItem = context.Entry(item);
                updatedItem.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
