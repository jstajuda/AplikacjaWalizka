using MojaWalizkaBL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojaWalizkaApp.ViewModel
{
    public class MainNavigationViewModel : ViewModelBase
    {
        public MainViewModel MainViewModel;
        public ObservableCollection<ItemList> ItemLists { get; set; }

        public MainNavigationViewModel(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
            ItemLists = MainViewModel.ItemLists;
        }   
    }
}
