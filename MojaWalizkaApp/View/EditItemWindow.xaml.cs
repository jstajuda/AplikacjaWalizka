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
            //WAŻNE - WALIDACJA DANYCH
            string itemName = ItemNameTextBox.Text;
            string itemDescription = ItemDescriptionTextBox.Text;
            Category itemCategory = CategoriesComboBox.SelectedItem as Category;

            selectedItem.Name = itemName;
            selectedItem.Description = itemDescription;
            selectedItem.CategoryId = itemCategory.Id;

            viewModel.ItemsSaveChanges();

            this.Close();
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
    }
}
