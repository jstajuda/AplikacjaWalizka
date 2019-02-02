using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojaWalizkaDA
{
    public interface IRepository<T>
    {
        ObservableCollection<T> GetAll();

        //T GetById(int id);

        //void CreateOrUpdate(T item);
        //void Save(T item);
        //void Delete(T item);
    }
}
