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
    /// Klasa reprezentuje repozytorium obiektów Item.
    /// Zapewnie typowe operacje CRUD.
    /// </summary>
    public class ItemRepository
    {
        WalizkaAppContext ctx;

        /// <summary>
        /// Tworzy repozytorium obiektów Item.
        /// </summary>
        /// <param name="context">Obiekt typu DbContext (Entity Framework)</param>
        public ItemRepository(WalizkaAppContext context)
        {
            ctx = context;
        }

        /// <summary>
        /// Pobiera kolekcję wszystkich istniejących w bazie danych obiektów Item.
        /// </summary>
        /// <returns>Kolekcja obiektów Item.</returns>
        public IQueryable<Item> GetAll()
        {
            return ctx.Items;
        }

        /// <summary>
        /// Pobiera (w osobnym wątku) kolekcję wszystkich istniejących w bazie danych obiektów Item.
        /// </summary>
        /// <returns>Lista obiektów Item.</returns>
        public async Task<List<Item>> GetAllAsync()
        {
            List<Item> items = null;
            items = await ctx.Items.ToListAsync();
            return items;
        }

        /// <summary>
        /// Pobiera kolekcję wszystkich istniejących w bazie danych obiektów Item.
        /// Tworzy nowy obiekt typu DbContext.
        /// </summary>
        /// <returns>Kolekcja obiektów Item.</returns>
        public static IQueryable<Item> GetAllStatic()
        {
            using (WalizkaAppContext ctx = new WalizkaAppContext())
            {
                return ctx.Items;
            };
        }

        /// <summary>
        /// Pobiera obiekt Item o zadanym numerze Id.
        /// </summary>
        /// <param name="id">Id szukanego obiektu.</param>
        /// <returns>Obiekt typu Item, lub null jeśli nie znaleziono.</returns>
        public Item GetById(int id)
        {
            return ctx.Items.Find(id);
        }

        /// <summary>
        /// Dodaje obiekt Item do bazy danych.
        /// </summary>
        /// <param name="item">Obiekt Item do umieszczenia w bazie danych.</param>
        public void Add(Item item)
        {
            ctx.Items.Add(item);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Usuwa obiekt Item z bazy danych.
        /// </summary>
        /// <param name="item">Obiekt Item do usunięcia z bazy danych.</param>
        public void Delete(Item item)
        {
            ctx.Items.Remove(item);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Aktualizuje pola obiektu typu Item w bazie danych.
        /// </summary>
        /// <param name="item">Obiekt typu Item do zaktualizowania.</param>
        public void Update(Item item)
        {
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
