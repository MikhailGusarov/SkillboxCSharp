using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppClient
{
    public static class Ext
    {
        public static double ToDouble(this string e) => Convert.ToDouble(e);

        public static ObservableCollection<Car> ToObservableCollection(this  IEnumerable<Car> e)
        {
            ObservableCollection<Car> t = new ObservableCollection<Car>();
            foreach (var item in e)
            {
                t.Add(item);
            }
            return t;
        }


    }
}
