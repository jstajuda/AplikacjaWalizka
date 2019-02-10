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
    /// Interaction logic for ListCategoriesWindow.xaml
    /// </summary>
    public partial class ListCategoriesWindow : Window
    {
        private MainViewModel viewModel;

        public ListCategoriesWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            this.viewModel = viewModel;
        }

        private void ListCategoriesWindowControl_Loaded(object sender, RoutedEventArgs e)
        {
            CategoriesDataGrid.ItemsSource = viewModel.Categories;
        }

        private void EditCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            Category selectedItem = CategoriesDataGrid.SelectedItem as Category;
            EditCategoryWindow editCategoryWindow = new EditCategoryWindow(viewModel, selectedItem);
            editCategoryWindow.ShowDialog();
        }

        private void DeleteCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            Category selectedItem = CategoriesDataGrid.SelectedItem as Category;
            if(selectedItem.Items != null && selectedItem.Items.Count > 0)
            {
                MessageBox.Show("Kategoria ma przypisane elementy - nie można usunąć");
            } else
            {
                viewModel.Categories.Remove(selectedItem);
                CategoriesDataGrid.UnselectAll();
            }
        }

        private void CreateCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            AddCategoryWindow addCategoryView = new AddCategoryWindow(viewModel);
            addCategoryView.ShowDialog();
        }
    }
}
