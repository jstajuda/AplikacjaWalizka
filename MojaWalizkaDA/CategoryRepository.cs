using MojaWalizkaBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojaWalizkaDA
{
    public class CategoryRepository
    {
        WalizkaAppContext ctx;

        public CategoryRepository(WalizkaAppContext context)
        {
            ctx = context;
        }

        public IQueryable<Category> GetAll()
        {
            return ctx.Categories.Include("Items");
        }

        public static IQueryable<Category> GetAllStatic()
        {
            using (WalizkaAppContext ctx = new WalizkaAppContext())
            {
                return ctx.Categories;
            };
        }

        public Category GetById(int id)
        {
            return ctx.Categories.Find(id);
        }

        public void Add(Category category)
        {
            ctx.Categories.Add(category);
            ctx.SaveChanges();
        }

        public void Delete(Category category)
        {
            ctx.Categories.Remove(category);
            ctx.SaveChanges();
        }

        public void Update(Category category)
        {
            ctx.SaveChanges();
        }

        public void Save()
        {
            ctx.SaveChanges();
        }

    }
}
