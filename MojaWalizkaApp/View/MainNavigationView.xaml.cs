﻿using MojaWalizkaApp.ViewModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MojaWalizkaApp.View
{
    /// <summary>
    /// Interaction logic for MainNavigation.xaml
    /// </summary>
    public partial class MainNavigationView : UserControl
    {
        private MainViewModel main;
        
        public MainNavigationView(MainViewModel mainViewModel)
        {
            InitializeComponent();

            main = mainViewModel;
            LatestTripsListView.ItemsSource = main.ItemLists.Take(5);
            PredefinedListView.ItemsSource = main.PredefinedLists;
        }

        private void SideListShowAllButton_Click(object sender, RoutedEventArgs e)
        {
            LatestTripsListView.ItemsSource = main.ItemLists;
            SideListShowAllButton.IsEnabled = false;
        }

        private void LatestTripsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            main.CurrentList = LatestTripsListView.SelectedItem as ItemList; 
        }

        private void PredefinedListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            main.CurrentList = PredefinedListView.SelectedItem as ItemList;
        }

        private void CreateEmptyListButton_Click(object sender, RoutedEventArgs e)
        {
            main.CurrentList = main.EmptyList;
        }

        private void SidePredefinedListDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            ItemList list = button.DataContext as ItemList;
            main.PredefinedLists.Remove(list);
            main.CurrentList = main.EmptyList;
        }

        public void SideLatestListDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            ItemList list = button.DataContext as ItemList;
            main.ItemLists.Remove(list);
            main.CurrentList = main.EmptyList;
        }
    }
}
