using MojaWalizkaBL;
using MojaWalizkaDA;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MojaWalizkaApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ItemList currentList;
        public ItemList CurrentList
        {
            get => currentList;
            set {
                currentList = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<ItemList> itemLists;
        public ObservableCollection<ItemList> ItemLists
        {
            get => itemLists;
            set
            {
                itemLists = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<ItemList> itemListsLimited;
        public ObservableCollection<ItemList> ItemListsLimited
        {
            get => itemListsLimited;
            set
            {
                itemListsLimited = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<ItemList> predefinedLists;
        public ObservableCollection<ItemList> PredefinedLists
        {
            get => predefinedLists;
            set
            {
                predefinedLists = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Category> categories;
        public ObservableCollection<Category> Categories
        {
            get => categories;
            set
            {
                categories = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Item> items;
        public ObservableCollection<Item> Items
        {
            get => items;
            set
            {
                items = value;
                OnPropertyChanged();
            }
        }

        private ItemList emptyList;
        public ItemList EmptyList
        {
            get => emptyList;
            set
            {
                emptyList = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel(WalizkaAppContext context)
        {
            itemRepository = new ItemRepository(context);
            categoryRepository = new CategoryRepository(context);
            itemListRepository = new ItemListRepository(context);
    
            ItemLists = new ObservableCollection<ItemList>(itemListRepository.GetAll());
            ItemListsLimited = new ObservableCollection<ItemList>(itemListRepository.GetLimited(3));
            PredefinedLists = new ObservableCollection<ItemList>(itemListRepository.GetLimited(3));
            ItemLists.CollectionChanged += List_CollectionChanged;
            ItemListsLimited.CollectionChanged += List_CollectionChanged;
            PredefinedLists.CollectionChanged += List_CollectionChanged;

            Categories = new ObservableCollection<Category>(categoryRepository.GetAll());
            Items = new ObservableCollection<Item>(itemRepository.GetAll());

            EmptyList = generateEmptyList();
            CurrentList = EmptyList;
            
        }

        public void ItemListsSaveChanges()
        {
            itemListRepository.Save();
        }

        private void List_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            ItemList itemList;

            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    itemList = e.NewItems[0] as ItemList;
                    itemListRepository.Add(itemList);
                    break;

                case NotifyCollectionChangedAction.Move:
                    itemListRepository.Save();
                    break;

                case NotifyCollectionChangedAction.Remove:
                    itemList = e.OldItems[0] as ItemList;
                    itemListRepository.Delete(itemList);
                    break;

                case NotifyCollectionChangedAction.Replace:
                    itemListRepository.Save();
                    break;

                case NotifyCollectionChangedAction.Reset:
                    itemListRepository.Save();
                    break;

                default:
                    itemListRepository.Save();
                    break;
            }
        }

        private ItemRepository itemRepository;
        private CategoryRepository categoryRepository;
        private ItemListRepository itemListRepository;

        //private ObservableCollection<ItemList> generateItemLists(int limit = -1)
        //{

        //    ObservableCollection<ItemList> lists = new ObservableCollection<ItemList>()
        //    {
        //        new ItemList(1, "Madagaskar", "ten niebieski", new ObservableCollection<Item>(){
        //            new Item(1, "Ręcznik", "ten niebieski Madagaskar", "Higiena"),
        //            new Item(2, "Półbuty", "brązowe skórzane Madagaskar", "Obuwie"),
        //            new Item(3, "Sweter", "Różowy w grochy Madagaskar", "Ubranie"),
        //            new Item(4, "Żel pod prysznic", "super energy for menly men", "Higiena"),
        //            new Item(5, "Powerbank", "ten 30000mAh z latarką", "Elektronika")
        //        }),

        //        new ItemList(2, "Nowa Zelandia", "brązowe skórzane", new ObservableCollection<Item>(){
        //            new Item(1, "Ręcznik", "ten niebieski Zelandia", "Higiena"),
        //            new Item(2, "Półbuty", "brązowe skórzane Zelandia", "Obuwie"),
        //            new Item(3, "Sweter", "Różowy w grochy Zelandia", "Ubranie"),
        //            new Item(4, "Żel pod prysznic", "super energy for menly men", "Higiena"),
        //            new Item(5, "Powerbank", "ten 30000mAh z latarką", "Elektronika")
        //        }),

        //        new ItemList(3, "Bździochy Wielkie", "Wczasy pod strzechą u gaździny", new ObservableCollection<Item>(){
        //            new Item(1, "Ręcznik", "ten niebieski Wielkie", "Higiena"),
        //            new Item(2, "Półbuty", "brązowe skórzane Wielkie", "Obuwie"),
        //            new Item(3, "Sweter", "Różowy w grochy Wielkie", "Ubranie"),
        //            new Item(4, "Żel pod prysznic", "super energy for menly men", "Higiena"),
        //            new Item(5, "Powerbank", "ten 30000mAh z latarką", "Elektronika")
        //        }),

        //        new ItemList(4, "Sopot", "Opierdoling na molo Sopot", new ObservableCollection<Item>(){
        //            new Item(1, "Ręcznik", "ten niebieski Sopot", "Higiena"),
        //            new Item(2, "Półbuty", "brązowe skórzane Sopot", "Obuwie"),
        //            new Item(3, "Sweter", "Różowy w grochy", "Ubranie"),
        //            new Item(4, "Żel pod prysznic", "super energy for menly men", "Higiena"),
        //            new Item(5, "Powerbank", "ten 30000mAh z latarką", "Elektronika")
        //        }),

        //        new ItemList(5, "Juesej", "Niagara i wielki kanion - jak wszyscy Juesej", new ObservableCollection<Item>(){
        //            new Item(1, "Ręcznik", "ten niebieski Juesej", "Higiena"),
        //            new Item(2, "Półbuty", "brązowe skórzane Juesej", "Obuwie"),
        //            new Item(3, "Sweter", "Różowy w grochy Juesej", "Ubranie"),
        //            new Item(4, "Żel pod prysznic", "super energy for menly men", "Higiena"),
        //            new Item(5, "Powerbank", "ten 30000mAh z latarką", "Elektronika")
        //        })
        //    };

        //    if (limit == -1) return lists;

        //    for (int i = 0; i < limit; i++)
        //    {
        //        lists.RemoveAt(i);
        //    }

        //    return lists;
        //}
        //private ObservableCollection<ItemList> generatePredefinedLists()
        //{
        //    return new ObservableCollection<ItemList>()
        //    {
        //        new ItemList(1, "Wycieczka górska", "Rzeczy niezbędne na szlaku", new ObservableCollection<Item>(){
        //            new Item(1, "Buty trekkingowe", "Te z Lidla", "Obuwie sportowe"),
        //            new Item(2, "Peleryna", "Szara peleryna marki noname", "Odzież sportowa"),
        //            new Item(3, "Sweter", "Różowy w grochy", "Odzież"),
        //            new Item(4, "Dezodorant", "super energy for menly men", "Higiena"),
        //            new Item(5, "Powerbank", "ten 30000mAh z latarką", "Elektronika")
        //        }),

        //        new ItemList(2, "Wyjazd służbowy", "Rzeczy na wyjazd służbowy", new ObservableCollection<Item>(){
        //            new Item(1, "Ręcznik", "Niebieski w paski", "Higiena"),
        //            new Item(2, "Półbuty", "Brązowe skórzane", "Obuwie"),
        //            new Item(3, "Sweter", "Różowy w grochy", "Ubranie"),
        //            new Item(4, "Żel pod prysznic", "super energy for menly men", "Higiena"),
        //            new Item(5, "Laptop", "SuperMega Pro Edition", "Elektronika")
        //        }),

        //        new ItemList(3, "Wczasy nad morzem", "Rzeczy niezbędne na plażing", new ObservableCollection<Item>(){
        //            new Item(1, "Ręcznik", "Niebieski w paski", "Higiena"),
        //            new Item(7, "Ręcznik", "Żółty w paski", "Higiena"),
        //            new Item(2, "Klapki", "Srebrne błyszczące Kubota", "Obuwie"),
        //            new Item(3, "T-shirt", "", "Ubranie"),
        //            new Item(4, "Żel pod prysznic", "super energy for menly men", "Higiena"),
        //            new Item(5, "Powerbank", "ten 30000mAh z latarką", "Elektronika"),
        //            new Item(8, "Leżak", "Rozkładany z zagłówkiem", "Art. do wypoczynku"),
        //        })
        //    };
        //}
        private ItemList generateEmptyList()
        {
            return new ItemList()
            {
                Name = "Tu wpisz tytuł listy",
                Description = "Podaj krótki opis listy",
                Items = new ObservableCollection<Item>()
            };
        }

    }
}
