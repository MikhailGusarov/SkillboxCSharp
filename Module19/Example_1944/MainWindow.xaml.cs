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

namespace Example_1944
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView
    {
        Presenter p;

        public MainWindow()
        {
            InitializeComponent();

            p = new Presenter(this);

            btnNContact.Click += (s, e) => p.NextContact();
            btnRContact.Click += (s, e) => p.RemoveContact();
            btnAContact.Click +=  (s, e) => p.AddContact();
            btnPContact.Click += (s, e) => p.PrevContact(); 

            this.Closing +=  (s, e) => p.SaveContactBase(); 
            this.Loaded +=  (s, e) => p.LoadContacts(); 
        }

        public string ContactTelephoneNumber
        {
            get => txtTelephoneNumber.Text;
            set => txtTelephoneNumber.Text = value;
        }

        public string ContactName
        {
            get => txtContactName.Text;
            set => txtContactName.Text = value;
        }
         
    }
}