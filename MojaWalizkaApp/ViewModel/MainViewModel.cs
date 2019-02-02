using MojaWalizkaBL;
using MojaWalizkaDA;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojaWalizkaApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {

        public ObservableCollection<Item> Items;
        public ItemRepository ItemRepository;

        public MainViewModel()
        {
            ItemRepository = new ItemRepository();
            Items = ItemRepository.GetAll();
        }

    }
}
