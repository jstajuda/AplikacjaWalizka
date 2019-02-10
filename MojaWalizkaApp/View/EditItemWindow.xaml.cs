using MojaWalizkaApp.ViewModel;
using MojaWalizkaBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for EditItemWindow.xaml
    /// </summary>
    public partial class EditItemWindow : Window, INotifyPropertyChanged
    {
        private MainViewModel viewModel;
        private Item selectedItem;

        public EditItemWindow(MainViewModel viewModel, Item selectedItem)
        {
            InitializeComponent();
            this.viewModel = viewModel;
            this.selectedItem = selectedItem;
        }

        private void EditItemWindowControl_Loaded(object sender, RoutedEventArgs e)
        {
            ItemNameTextBox.Text = selectedItem.Name;
            ItemDescriptionTextBox.Text = selectedItem.Description;

            CategoriesComboBox.ItemsSource = viewModel.Categories;
            CategoriesComboBox.DisplayMemberPath = "Name";
            CategoriesComboBox.Text = selectedItem.Category.Name;
        }

        private void EditItemOkButton_Click(object sender, RoutedEventArgs e)
        {
            bool isValid = true;

            string itemName = ItemNameTextBox.Text;
            string itemDescription = ItemDescriptionTextBox.Text;
            Category itemCategory = CategoriesComboBox.SelectedItem as Category;

            if (String.IsNullOrWhiteSpace(itemName))
            {
                isValid = false;
                ItemNameLabel.Content = "Nazwa przedmiotu (nazwa nie może być pusta)";
                ItemNameLabel.Foreground = Brushes.Red;
            }

            if (itemCategory == null)
            {
                isValid = false;
                ItemCategoryLabel.Content = "Kategoria (należy wybrać kategorię)";
                ItemCategoryLabel.Foreground = Brushes.Red;
            }

            if (isValid)
            {
                selectedItem.Name = itemName.Trim();
                selectedItem.Description = itemDescription.Trim();
                selectedItem.CategoryId = itemCategory.Id;
                viewModel.ItemsSaveChanges();
                this.Close();
            }
        }

        private void EditItemCancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ListCategoriesButton_Click(object sender, RoutedEventArgs e)
        {
            ListCategoriesWindow listCategoriesView = new ListCategoriesWindow(viewModel);
            listCategoriesView.ShowDialog();
        }
    }
}
