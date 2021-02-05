using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.IEntityFramework
{
    public class EfColorsDal : IColorsDal
    {
        public void Add(Colors item)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var addedItem = context.Entry(item); //referansı yakala 
                addedItem.State = EntityState.Added; // bu nesne eklenicek
                context.SaveChanges(); //Nesneyi ekle 
            }
        }

        public void Delete(Colors item)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var deletedItem = context.Entry(item);
                deletedItem.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Colors Get(Expression<Func<Colors, bool>> filter)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                return context.Set<Colors>().SingleOrDefault(filter);
            }
        }

        public List<Colors> GetAll(Expression<Func<Colors, bool>> filter = null)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                return filter == null ? context.Set<Colors>().ToList()
                    : context.Set<Colors>().Where(filter).ToList();
            }
        }

        public void Update(Colors item)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var updatedItem = context.Entry(item);
                updatedItem.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
