﻿using MojaWalizkaApp.View;
using MojaWalizkaApp.ViewModel;
using MojaWalizkaBL;
using MojaWalizkaDA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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

        MainViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();

            WalizkaAppContext context = new WalizkaAppContext();

            viewModel = new MainViewModel(context);
            DataContext = viewModel;

            var navigationView = new MainNavigationView(viewModel);
            MainNavigation.Content = navigationView;
        }

        private void AddNewItemButton_Click(object sender, RoutedEventArgs e)
        {
            ListItemsWindow listItemsView = new ListItemsWindow(viewModel);
            listItemsView.ShowDialog();
        }

        private void DeleteItemButton_Click(object sender, RoutedEventArgs e)
        {
            Item selectedItem = ItemsDataGrid.SelectedItem as Item;
            viewModel.CurrentList.Items.Remove(selectedItem);
        }

        private void SaveListButton_Click(object sender, RoutedEventArgs e)
        {
            bool isValid = true;

            if(String.IsNullOrWhiteSpace(CurrentListNameTextBox.Text))
            {
                isValid = false;
                CurrentListNameLabel.Content = "Nazwa nie może być pusta!";
            }

            if(isValid)
            {
                CurrentListNameLabel.Content = "";
                viewModel.CurrentList.Name = CurrentListNameTextBox.Text.Trim();
                if (viewModel.CurrentList.Id == 0)
                {
                    viewModel.ItemLists.Add(viewModel.CurrentList);
                }
                viewModel.ItemListsSaveChanges();
                viewModel.ItemListsRefresh();

                var navigationView = new MainNavigationView(viewModel);
                MainNavigation.Content = navigationView;
            }
        }

        private void ListUpdatedAtTextBlock_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            ListUpdatedAtTextBlock.Text = String.IsNullOrWhiteSpace(ListUpdatedAtTextBlock.Text) ?
                                          "Niezapisane" : viewModel.CurrentList.UpdatedAt.ToString();
        }

        private void ListCategoriesButton_Click(object sender, RoutedEventArgs e)
        {
            ListCategoriesWindow listCategoriesView = new ListCategoriesWindow(viewModel);
            listCategoriesView.ShowDialog();
        }

        private void ExportToPdfButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sorry, not implemented yet.");
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sorry, not implemented yet.");
        }
    }
}
