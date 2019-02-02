using MojaWalizkaBL;
using MojaWalizkaDA;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MojaWalizkaApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<Item> Items;
        public ObservableCollection<ItemList> ItemLists;
        public List<PredefinedList> PredefinedLists;


        public ItemRepository ItemRepository;
        public ItemListRepository ItemListRepository;
        public PredefinedListRepository PredefinedListRepository;

        public MainWindow()
        {
            InitializeComponent();

            ItemRepository = new ItemRepository();
            ItemListRepository = new ItemListRepository();
            PredefinedListRepository = new PredefinedListRepository();

            Items = new ObservableCollection<Item>();
            ItemLists = ItemListRepository.GetLatest();

            ItemsDataGrid.ItemsSource = Items;
            LatestTripsListView.ItemsSource = ItemLists;
        }

        private void SideListShowAllButton_Click(object sender, RoutedEventArgs e)
        {
            ItemLists = new ObservableCollection<ItemList>();
            ItemLists = ItemListRepository.GetAll();
            LatestTripsListView.ItemsSource = ItemLists;
        }

        private void SideGenerateListButton_Click(object sender, RoutedEventArgs e)
        {
            List<PredefinedList> listToAppend = PredefinedListRepository.GetAll();
            foreach (var item in listToAppend[0].Items)
            {
                Items.Add(item);
            }
            //Items.Add(new Item(1, "Ręcznik", "ten niebieski", "Higiena"));
        }

        private void LatestTripsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var list = e.AddedItems;
            var list2 = new List();
        }
    }
}
