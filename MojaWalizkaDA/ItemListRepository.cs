using MojaWalizkaBL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojaWalizkaDA
{
    /// <summary>
    /// Klasa reprezentuje repozytorium obiektów ItemList.
    /// Zapewnie typowe operacje CRUD.
    /// </summary>
    public class ItemListRepository
    {
        WalizkaAppContext ctx;

        /// <summary>
        /// Tworzy repozytorium obiektów ItemList.
        /// </summary>
        /// <param name="context">Obiekt typu DbContext (Entity Framework)</param>
        public ItemListRepository(WalizkaAppContext context)
        {
            ctx = context;
        }

        /// <summary>
        /// Pobiera kolekcję wszystkich istniejących w bazie danych obiektów ItemList,
        /// której nie są listami predefiniowanymi.
        /// </summary>
        /// <returns>Kolekcja obiektów ItemList</returns>
        public IQueryable<ItemList> GetAll()
        {
            return ctx.ItemLists.Include("Items").Where(il => il.IsPredefined == false)
                                                 .OrderByDescending(il => il.CreatedAt);
        }

        /// <summary>
        /// Pobiera kolekcję wszystkich istniejących w bazie danych obiektów ItemList,
        /// której są listami predefiniowanymi.
        /// </summary>
        /// <returns>Kolekcja obiektów ItemList</returns>
        public IQueryable<ItemList> GetPredefined()
        {
            return ctx.ItemLists.Include("Items").Where(il => il.IsPredefined == true);
        }

        /// <summary>
        /// Pobiera (w osobnym wątku) kolekcję wszystkich istniejących w bazie danych obiektów ItemLists.
        /// </summary>
        /// <returns>Lista obiektów ItemList.</returns>
        public async Task<List<ItemList>> GetAllAsync()
        {
            List<ItemList> itemLists = null;
            itemLists = await ctx.ItemLists.ToListAsync();
            return itemLists;
        }

        /// <summary>
        /// Pobiera obiekt ItemList o zadanym numerze Id.
        /// </summary>
        /// <param name="id">Id szukanego obiektu.</param>
        /// <returns>Obiekt typu ItemList, lub null jeśli nie znaleziono.</returns>
        public ItemList GetById(int id)
        {
            return ctx.ItemLists.Find(id);
        }

        /// <summary>
        /// Dodaje obiekt ItemList do bazy danych.
        /// </summary>
        /// <param name="itemList">Obiekt ItemList do umieszczenia w bazie danych.</param>
        public void Add(ItemList itemList)
        {
            itemList.CreatedAt = DateTime.Now;
            itemList.UpdatedAt = DateTime.Now;
            ctx.ItemLists.Add(itemList);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Usuwa obiekt ItemList z bazy danych.
        /// </summary>
        /// <param name="itemList">Obiekt ItemList do usunięcia z bazy danych.</param>
        public void Delete(ItemList itemList)
        {
            ctx.ItemLists.Remove(itemList);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Aktualizuje pola obiektu typu ItemList w bazie danych.
        /// </summary>
        /// <param name="itemList">Obiekt typu ItemList do zaktualizowania.</param>
        public void Update(ItemList itemList)
        {
            itemList.UpdatedAt = DateTime.Now;
            ctx.SaveChanges();
        }

        /// <summary>
        /// Zapisuje zmiany w kolekcjach powiązanych z aktualnym obiektem DbContext
        /// </summary>
        public void Save()
        {
            ctx.SaveChanges();
        }
    }

}
        
