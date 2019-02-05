using MojaWalizkaApp.View;
using MojaWalizkaApp.ViewModel;
using MojaWalizkaBL;
using MojaWalizkaDA;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        MainViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();

            viewModel = new MainViewModel();
            DataContext = viewModel;

            var navigationView = new MainNavigationView(viewModel);
            MainNavigation.Content = navigationView;

        }
        private void AddNewItemButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.CurrentList.Items.Add(new Item("Nowy przedmiot", "Opis przedmiotu", "Kategoria"));
            /*using (var db = new WalizkaContext())
                {
                    var cat = new CategoryRepository { Name = "różneff", Description = "rzeczffgy" };
                    db.Categories.Add(cat);
                    db.SaveChanges();
                }*/
        }

    }
}
