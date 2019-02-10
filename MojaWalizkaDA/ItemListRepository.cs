using MojaWalizkaBL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojaWalizkaDA
{
    public class ItemListRepository
    {
        WalizkaAppContext ctx;

        public ItemListRepository(WalizkaAppContext context)
        {
            ctx = context;
        }

        public IQueryable<ItemList> GetAll()
        {
            return ctx.ItemLists.Include("Items").Where(il => il.IsPredefined == false)
                                                 .OrderByDescending(il => il.CreatedAt);
        }

        public IQueryable<ItemList> GetLimited(int limit)
        {
            return ctx.ItemLists.Include("Items").Where(il => il.IsPredefined == false)
                                                 .OrderByDescending(il => il.CreatedAt)
                                                 .Take(limit);
        }

        public IQueryable<ItemList> GetPredefined()
        {
            return ctx.ItemLists.Include("Items").Where(il => il.IsPredefined == true);
        }

        public ItemList GetById(int id)
        {
            return ctx.ItemLists.Find(id);
        }


        public void Add(ItemList itemList)
        {
            itemList.CreatedAt = DateTime.Now;
            itemList.UpdatedAt = DateTime.Now;
            ctx.ItemLists.Add(itemList);
            ctx.SaveChanges();
        }

        public void Delete(ItemList itemList)
        {
            ctx.ItemLists.Remove(itemList);
            ctx.SaveChanges();
        }

        public void Update(ItemList itemList)
        {
            itemList.UpdatedAt = DateTime.Now;
            ctx.SaveChanges();
        }

        public void Save()
        {
            ctx.SaveChanges();
        }
    }

}
        
