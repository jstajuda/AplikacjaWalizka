using MojaWalizkaApp.ViewModel;
using MojaWalizkaBL;
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
using System.Windows.Shapes;

namespace MojaWalizkaApp.View
{
    /// <summary>
    /// Interaction logic for ListItemsWindow.xaml
    /// </summary>
    public partial class ListItemsWindow : Window
    {

        private MainViewModel viewModel;

        public ListItemsWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            this.viewModel = viewModel;
        }

        private void ListItemsWindowControl_Loaded(object sender, RoutedEventArgs e)
        {
            ItemsDataGrid.ItemsSource = viewModel.Items;
        }

        private void EditItemButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteItemButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Items.Remove(ItemsDataGrid.SelectedItem as Item);
        }

        private void CreateItemButton_Click(object sender, RoutedEventArgs e)
        {
            AddItemWindow addItemView = new AddItemWindow(viewModel);
            addItemView.ShowDialog();
        }

        private void AddToListButton_Click(object sender, RoutedEventArgs e)
        {
            Item selectedItem = ItemsDataGrid.SelectedItem as Item;
            viewModel.CurrentList.Items.Add(selectedItem);
            this.Close();
        }
    }
}
