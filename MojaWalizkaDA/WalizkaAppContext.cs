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
    public class WalizkaAppContext : DbContext
    {
        public WalizkaAppContext() : base("SQLServerCompact")
        {
            Database.SetInitializer<WalizkaAppContext>(new WalizkaAppDBInitializerProd());
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ItemList> ItemLists { get; set; }
    }


    //public class WalizkaAppDBInitializerProd : DropCreateDatabaseAlways<WalizkaAppContext>
    public class WalizkaAppDBInitializerProd : CreateDatabaseIfNotExists<WalizkaAppContext>
    {
        protected override void Seed(WalizkaAppContext context)
        {

            #region Categories Seed
            IList<Category> defaultCategories = new List<Category>();
            defaultCategories.Add(new Category() { Name = "Odzież", Description = "Ubrania" });
            defaultCategories.Add(new Category() { Name = "Obuwie", Description = "Buty - te opisy sa chyba zbedne ;)" });
            defaultCategories.Add(new Category() { Name = "Higiena", Description = "Waciki etc" });
            defaultCategories.Add(new Category() { Name = "Elektronika", Description = "Akcesoria" });
            defaultCategories.Add(new Category() { Name = "Inne", Description = "Tu pasuje wszystko" });

            context.Categories.AddRange(defaultCategories);
            context.SaveChanges();
            #endregion

            #region Items Seed
            IList<Item> defaultItems = new List<Item>();
            var cat = defaultCategories[0]; //Odzież
            defaultItems.Add(new Item() { Name = "Sweter", Description = "Różowy w niebieskie grochy", CategoryId = cat.Id, Category = cat });
            defaultItems.Add(new Item() { Name = "Bluza", Description = "Ziomalska z kapturem", CategoryId = cat.Id, Category = cat });
            defaultItems.Add(new Item() { Name = "Jeansy", Description = "Poszarpane na wygląd bezdomnego", CategoryId = cat.Id, Category = cat });
            defaultItems.Add(new Item() { Name = "Spodnie", Description = "Czarne wyjściowe", CategoryId = cat.Id, Category = cat });
            defaultItems.Add(new Item() { Name = "Rękawiczki", Description = "Wełniane od babci", CategoryId = cat.Id, Category = cat });

            cat = defaultCategories[1]; //Obuwie
            defaultItems.Add(new Item() { Name = "Trampki", Description = "Zielone świecące w ciemności", CategoryId = cat.Id, Category = cat });
            defaultItems.Add(new Item() { Name = "Półbuty", Description = "Brązowe skórzane z wyprzedaży w Stonce", CategoryId = cat.Id, Category = cat });
            defaultItems.Add(new Item() { Name = "Trekkingi", Description = "Nieprzemakalne samochodzące z gpsem", CategoryId = cat.Id, Category = cat });
            defaultItems.Add(new Item() { Name = "Sandały", Description = "Jesus style", CategoryId = cat.Id, Category = cat });

            cat = defaultCategories[2]; //Higiena
            defaultItems.Add(new Item() { Name = "Waciki", Description = "Te za 300 dolarów", CategoryId = cat.Id, Category = cat });
            defaultItems.Add(new Item() { Name = "Ręcznik", Description = "Biały mięciutki jak kaczuszka", CategoryId = cat.Id, Category = cat });
            defaultItems.Add(new Item() { Name = "Żel pod prysznic", Description = "Extra strong only for manly men", CategoryId = cat.Id, Category = cat });
            defaultItems.Add(new Item() { Name = "Szampon", Description = "Z ekstraktem z konopii", CategoryId = cat.Id, Category = cat });
            defaultItems.Add(new Item() { Name = "Dezodorant", Description = "666H super protection", CategoryId = cat.Id, Category = cat });


            cat = defaultCategories[3]; //Elektronika
            defaultItems.Add(new Item() { Name = "Ładowarka USB", Description = "Uniwersalna do wszystkiego", CategoryId = cat.Id, Category = cat });
            defaultItems.Add(new Item() { Name = "Powerbank", Description = "30000 MAh z latarką", CategoryId = cat.Id, Category = cat });
            defaultItems.Add(new Item() { Name = "Myszka", Description = "Ta mała energooszczędna", CategoryId = cat.Id, Category = cat });
            defaultItems.Add(new Item() { Name = "Głośniki", Description = "Bluetooth z extra basem", CategoryId = cat.Id, Category = cat });

            cat = defaultCategories[4]; //Inne
            defaultItems.Add(new Item() { Name = "Miska na wodę", Description = "Psia miska podróżna", CategoryId = cat.Id, Category = cat });
            defaultItems.Add(new Item() { Name = "Książka", Description = "Jakakolwiek na wszelki wypadek", CategoryId = cat.Id, Category = cat });
            defaultItems.Add(new Item() { Name = "Bulbulator", Description = "Niezbędny w podróży", CategoryId = cat.Id, Category = cat });
            defaultItems.Add(new Item() { Name = "Otwieracz do wina", Description = "Must have", CategoryId = cat.Id, Category = cat });

            context.Items.AddRange(defaultItems);
            context.SaveChanges();
            #endregion

            #region ItemLists Seed
            //Wycieczka górska
            var items = context.Items.Where(i => i.CategoryId == 1).ToList<Item>();
            var itemList = context.ItemLists.Add(new ItemList()
            {
                Name = "Wycieczka górska",
                Description = "Rzeczy niezbędne na szlaku",
                Items = new ObservableCollection<Item>(items),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                IsPredefined = true
            });
            context.ItemLists.Add(itemList);
            context.SaveChanges();

            //Wyjazd służbowy
            items = context.Items.Where(i => i.CategoryId == 2).ToList<Item>();
            itemList = context.ItemLists.Add(new ItemList()
            {
                Name = "Wyjazd służbowy",
                Description = "Rzeczy na wyjazd służbowy",
                Items = new ObservableCollection<Item>(items),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                IsPredefined = true
            });

            context.ItemLists.Add(itemList);
            context.SaveChanges();

            //Wyjazd służbowy
            items = context.Items.Where(i => i.CategoryId == 3).ToList<Item>();
            itemList = context.ItemLists.Add(new ItemList()
            {
                Name = "Wczasy nad morzem",
                Description = "Rzeczy niezbędne na plażing",
                Items = new ObservableCollection<Item>(items),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                IsPredefined = true
            });
            context.ItemLists.Add(itemList);
            context.SaveChanges();
            #endregion

            //Praga
            items = context.Items.Where(i => i.Id % 3 == 0).ToList<Item>();
            itemList = context.ItemLists.Add(new ItemList()
            {
                Name = "Weekend w Pradze",
                Description = "Spontaniczny wypad ze znajomymi",
                Items = new ObservableCollection<Item>(items),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                IsPredefined = false
            });
            context.ItemLists.Add(itemList);
            context.SaveChanges();

            //Bieszczady
            items = context.Items.Where(i => i.Id % 3 == 1).ToList<Item>();
            itemList = context.ItemLists.Add(new ItemList()
            {
                Name = "Bieszczady - jesień 2018",
                Description = "Pobyt w schronisku na Rawce",
                Items = new ObservableCollection<Item>(items),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                IsPredefined = false
            });
            context.ItemLists.Add(itemList);
            context.SaveChanges();

            //Warszawa
            items = context.Items.Where(i => i.Id % 3 == 2).ToList<Item>();
            itemList = context.ItemLists.Add(new ItemList()
            {
                Name = "GetNet Poznań 2017",
                Description = "Konferencja",
                Items = new ObservableCollection<Item>(items),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                IsPredefined = false
            });
            context.ItemLists.Add(itemList);
            context.SaveChanges();

            base.Seed(context);
        }
    }

}   


