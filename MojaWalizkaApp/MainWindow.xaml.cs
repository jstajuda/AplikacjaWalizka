using MojaWalizkaBL;
using MojaWalizkaDA;
using System;
using System.Collections.Generic;
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

        public List<Item> Items;
        public ItemRepository ItemRepository;

        public MainWindow()
        {
            InitializeComponent();
            ItemRepository = new ItemRepository();
            Items = ItemRepository.GetItems();
            ItemsDataGrid.ItemsSource = Items;
        }
    }
}
