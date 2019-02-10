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
    /// Interaction logic for AddCategoryWindow.xaml
    /// </summary>
    public partial class AddCategoryWindow : Window
    {
        private MainViewModel viewModel;

        public AddCategoryWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            this.viewModel = viewModel;
        }

        private void AddCategoryWindowControl_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void AddCategoryOkButton_Click(object sender, RoutedEventArgs e)
        {
            bool isValid = true;

            string categoryName = NewItemNameTextBox.Text;
            string categoryDescription = NewItemDescriptionTextBox.Text;

            if (String.IsNullOrWhiteSpace(categoryName))
            {
                isValid = false;
                CategoryNameLabel.Content = "Category Name (nazwa nie może być pusta!)";
                CategoryNameLabel.Foreground = Brushes.Red;
            }

            if(isValid)
            {
                this.viewModel.Categories.Add(new Category()
                {
                    Name = categoryName.Trim(),
                    Description = categoryDescription.Trim()
                });
                this.viewModel.CategoriesSaveChanges();
                this.Close();
            }
            
        }

        private void AddCategoryCancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
