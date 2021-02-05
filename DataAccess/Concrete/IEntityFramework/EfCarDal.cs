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
    public class EfCarDal : ICarDal
    {
        public void Add(Car item)
        {
            
            
                using (ReCapProjectContext context = new ReCapProjectContext())
                {
                    var addedItem = context.Entry(item); //referansı yakala 
                    addedItem.State = EntityState.Added; // bu nesne eklenicek
                    context.SaveChanges(); //Nesneyi ekle 
                }
            
        
        }

        public void Delete(Car item)
        {
            using (ReCapProjectContext context = new ReCapProjectContext() )
            {
                var deletedItem = context.Entry(item);
                deletedItem.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                return filter == null ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car item)
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
