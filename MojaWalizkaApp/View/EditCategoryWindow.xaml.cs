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
    /// Interaction logic for EditCategoryWindow.xaml
    /// </summary>
    public partial class EditCategoryWindow : Window, INotifyPropertyChanged
    {

        private MainViewModel viewModel;
        private Category selectedItem;

        public EditCategoryWindow(MainViewModel viewModel, Category selectedItem)
        {
            InitializeComponent();
            this.viewModel = viewModel;
            this.selectedItem = selectedItem;
        }

        private void EditCategoryWindowControl_Loaded(object sender, RoutedEventArgs e)
        {
            CategoryNameTextBox.Text = selectedItem.Name;
            CategoryDescriptionTextBox.Text = selectedItem.Description;
        }

        private void EditCategoryOkButton_Click(object sender, RoutedEventArgs e)
        {
            bool isValid = true;

            string categoryName = CategoryNameTextBox.Text;
            string categoryDescription = CategoryDescriptionTextBox.Text;

            if (String.IsNullOrWhiteSpace(categoryName))
            {
                isValid = false;
                CategoryNameLabel.Content = "Category Name (nazwa nie może być pusta!)";
                CategoryNameLabel.Foreground = Brushes.Red;
            }
            
            if(isValid)
            {
                selectedItem.Name = categoryName.Trim();
                selectedItem.Description = categoryDescription.Trim();
                viewModel.ItemsSaveChanges();
                this.Close();
            }
        }

        private void EditCategoryCancelButton_Click(object sender, RoutedEventArgs e)
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
