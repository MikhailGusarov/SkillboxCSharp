using Example_1942_Logic;
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

namespace Example_1943
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView
    {
        Presenter presenter;
        public MainWindow()
        {
            InitializeComponent();  
         
            presenter = new Presenter(this);
            btnResult.Click += (s, e) => presenter.Result();

        }

        public string ValueA { get => this.txtA.Text; }
        public string ValueB { get => this.txtB.Text; }
        public string Result { set => this.tbResult.Text = value; }
   
       
         
    }
}
