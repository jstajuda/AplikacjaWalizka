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
            get => generateEmptyList();
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
            ItemLists.CollectionChanged += List_CollectionChanged;

            ItemListsLimited = new ObservableCollection<ItemList>(itemListRepository.GetLimited(5));
            ItemListsLimited.CollectionChanged += List_CollectionChanged;

            PredefinedLists = new ObservableCollection<ItemList>(itemListRepository.GetPredefined());
            PredefinedLists.CollectionChanged += List_CollectionChanged;

            Categories = new ObservableCollection<Category>(categoryRepository.GetAll());
            Categories.CollectionChanged += Categories_CollectionChanged;

            Items = new ObservableCollection<Item>(itemRepository.GetAll());
            Items.CollectionChanged += Items_CollectionChanged;

            CurrentList = EmptyList;
        }

        public void ItemListsSaveChanges()
        {
            itemListRepository.Save();
        }

        public void ItemsSaveChanges()
        {
            itemRepository.Save();
        }

        public void CategoriesSaveChanges()
        {
            categoryRepository.Save();
        }

        public void ItemListsRefresh()
        {
            ItemLists = new ObservableCollection<ItemList>(itemListRepository.GetAll());
            ItemListsLimited = new ObservableCollection<ItemList>(itemListRepository.GetLimited(3));
            PredefinedLists = new ObservableCollection<ItemList>(itemListRepository.GetPredefined());
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
        private void Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {

            Item item;

            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    item = e.NewItems[0] as Item;
                    itemRepository.Add(item);
                    break;

                case NotifyCollectionChangedAction.Move:
                    itemRepository.Save();
                    break;

                case NotifyCollectionChangedAction.Remove:
                    item = e.OldItems[0] as Item;
                    itemRepository.Delete(item);
                    break;

                case NotifyCollectionChangedAction.Replace:
                    itemRepository.Save();
                    break;

                case NotifyCollectionChangedAction.Reset:
                    itemRepository.Save();
                    break;

                default:
                    itemRepository.Save();
                    break;
            }
        }
        private void Categories_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {

            Category item;

            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    item = e.NewItems[0] as Category;
                    categoryRepository.Add(item);
                    break;

                case NotifyCollectionChangedAction.Move:
                    categoryRepository.Save();
                    break;

                case NotifyCollectionChangedAction.Remove:
                    item = e.OldItems[0] as Category;
                    categoryRepository.Delete(item);
                    break;

                case NotifyCollectionChangedAction.Replace:
                    categoryRepository.Save();
                    break;

                case NotifyCollectionChangedAction.Reset:
                    categoryRepository.Save();
                    break;

                default:
                    categoryRepository.Save();
                    break;
            }
        }

        private ItemRepository itemRepository;
        private CategoryRepository categoryRepository;
        private ItemListRepository itemListRepository;

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
