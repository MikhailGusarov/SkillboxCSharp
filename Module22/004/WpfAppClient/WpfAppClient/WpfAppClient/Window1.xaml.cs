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
using System.Windows.Shapes;

namespace WpfAppClient
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            CarDataApi context = new CarDataApi();

            btnRef.Click += delegate { listView.ItemsSource = context.GetCars().ToObservableCollection(); };
            btnAdd.Click += delegate
            {
                context.AddCar(new Car()
                {
                    CarModel = txtModel.Text,
                    CarMark = txtMark.Text,
                    CarEngine = txtEngine.Text.ToDouble(),
                });
            };

        }
    }
}