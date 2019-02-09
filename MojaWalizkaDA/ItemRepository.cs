using MojaWalizkaBL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojaWalizkaDA
{
    public class ItemRepository
    {
        WalizkaAppContext ctx;

        public ItemRepository(WalizkaAppContext context)
        {
            ctx = context;
        }

        public IQueryable<Item> GetAll()
        {
            return ctx.Items;
        }

        public static IQueryable<Item> GetAllStatic()
        {
            using (WalizkaAppContext ctx = new WalizkaAppContext())
            {
                return ctx.Items;
            };
        }

        public Item GetById(int id)
        {
            return ctx.Items.Find(id);
        }

        public void Add(Item item)
        {
            ctx.Items.Add(item);
            ctx.SaveChanges();
        }

        public void Delete(Item item)
        {
            ctx.Items.Remove(item);
            ctx.SaveChanges();
        }

        public void Update(Item item)
        {
            ctx.SaveChanges();
        }

        public void Save()
        {
            ctx.SaveChanges();
        }
    }
}
