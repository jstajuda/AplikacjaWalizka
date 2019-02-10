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
    /// Interaction logic for AddItemWindow.xaml
    /// </summary>
    public partial class AddItemWindow : Window
    {

        private MainViewModel viewModel;

        public AddItemWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            this.viewModel = viewModel;
        }

        private void AddItemWindowControl_Loaded(object sender, RoutedEventArgs e)
        {
            CategoriesComboBox.ItemsSource = viewModel.Categories;
            CategoriesComboBox.DisplayMemberPath = "Name";


            //NewItemNameTextBox.GotFocus += RemoveText;
            //NewItemNameTextBox.LostFocus += AddText;
            //NewItemNameTextBox.Text = "Nowy przedmiot";
            //NewItemDescriptionTextBox.Text = "Opis przedmiotu";
        }

        private void AddItemOkButton_Click(object sender, RoutedEventArgs e)
        {
            //WAŻNE - WALIDACJA DANYCH
            string itemName = NewItemNameTextBox.Text;
            string itemDescription = NewItemDescriptionTextBox.Text;
            Category Category = CategoriesComboBox.SelectedItem as Category;

            this.viewModel.Items.Add(new Item()
            {
                Name = itemName,
                Description = itemDescription,
                CategoryId = Category.Id
            });

            this.Close();
        }

        private void AddItemCancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ListCategoriesButton_Click(object sender, RoutedEventArgs e)
        {
            ListCategoriesWindow listCategoriesView = new ListCategoriesWindow(viewModel);
            listCategoriesView.ShowDialog();
        }





        //public void RemoveText(object sender, EventArgs e)
        //{
        //    NewItemNameTextBox.Text = "";
        //}

        //public void AddText(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(NewItemNameTextBox.Text))
        //        NewItemNameTextBox.Text = "Nowy przedmiot";
        //}
    }
}
