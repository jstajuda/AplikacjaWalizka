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
        WalizkaAppContext ctx = new WalizkaAppContext();

        public IQueryable<ItemList> GetAll()
        {
            return ctx.ItemLists.Include("Items");
        }

        public IQueryable<ItemList> GetLimited(int limit)
        {
            return ctx.ItemLists.OrderByDescending(il => il.CreatedAt).Take(limit);
        }

        public static IQueryable<ItemList> GetAllStatic()
        {
            using (WalizkaAppContext ctx = new WalizkaAppContext())
            {
                return ctx.ItemLists;
            };
        }

        public ItemList GetById(int id)
        {
            return ctx.ItemLists.Find(id);
        }


        public void Add(ItemList itemList)
        {
            ctx.ItemLists.Add(itemList);
            ctx.SaveChanges();
        }

        public void Delete(ItemList itemList)
        {
            ctx.ItemLists.Remove(itemList);
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

        //public ObservableCollection<ItemList> GetLatest()
        //{
        //    itemLists = GetTestItemLists();
        //    itemLists.Remove(itemLists[0]);
        //    itemLists.Remove(itemLists[0]);
        //    return itemLists;
        //}
        
