using MojaWalizkaBL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojaWalizkaDA
{
    /// <summary>
    /// Klasa reprezentuje repozytorium obiektów Category.
    /// Zapewnie typowe operacje CRUD.
    /// </summary>
    public class CategoryRepository
    {
        private WalizkaAppContext ctx;

        /// <summary>
        /// Tworzy repozytorium obiektów Category.
        /// </summary>
        /// <param name="context">Obiekt typu DbContext (Entity Framework)</param>
        public CategoryRepository(WalizkaAppContext context)
        {
            ctx = context;
        }

        /// <summary>
        /// Pobiera kolekcję wszystkich istniejących w bazie danych obiektów Category.
        /// (wraz z powiązanymi listami obiektów typu Item)
        /// </summary>
        /// <returns>Kolekcja obiektów Category.</returns>
        public IQueryable<Category> GetAll()
        {
            return ctx.Categories.Include("Items");
        }

        /// <summary>
        /// Pobiera (w osobnym wątku) kolekcję wszystkich istniejących w bazie danych obiektów Category.
        /// /// (wraz z powiązanymi listami obiektów typu Item)
        /// </summary>
        /// <returns>Kolekcja obiektów Category.</returns>
        public async Task<List<Category>> GetAllAsync()
        {
            List<Category> categories = null;
            categories = await ctx.Categories.ToListAsync();
            return categories;
        }

        /// <summary>
        /// Pobiera kolekcję wszystkich istniejących w bazie danych obiektów Category.
        /// (wraz z powiązanymi listami obiektów typu Item)
        /// Tworzy nowy obiekt typu DbContext.
        /// </summary>
        /// <returns>Kolekcja obiektów Category.</returns>
        public static IQueryable<Category> GetAllStatic()
        {
            using (WalizkaAppContext ctx = new WalizkaAppContext())
            {
                return ctx.Categories;
            };
        }

        /// <summary>
        /// Pobiera obiekt Category o zadanym numerze Id.
        /// </summary>
        /// <param name="id">Id szukanego obiektu.</param>
        /// <returns>Obiekt typu Category, lub null jeśli nie znaleziono.</returns>
        public Category GetById(int id)
        {
            return ctx.Categories.Find(id);
        }

        /// <summary>
        /// Dodaje obiekt Category do bazy danych.
        /// </summary>
        /// <param name="category">Obiekt Category do umieszczenia w bazie danych.</param>
        public void Add(Category category)
        {
            ctx.Categories.Add(category);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Usuwa obiekt Category z bazy danych.
        /// </summary>
        /// <param name="category">Obiekt Category do usunięcia z bazy danych.</param>
        public void Delete(Category category)
        {
            ctx.Categories.Remove(category);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Aktualizuje pola obiektu typu Category w bazie danych.
        /// </summary>
        /// <param name="category">Obiekt typu Category do zaktualizowania.</param>
        public void Update(Category category)
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
