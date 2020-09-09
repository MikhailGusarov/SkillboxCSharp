using Example_1942_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_1942
{
    public partial class mainForm : Form, IView
    {
        Presenter presenter;
        public mainForm()
        {
            InitializeComponent();
            presenter = new Presenter(this);
            btnSum.Click += (s, e) => presenter.Result();

        }

        public string ValueA { get => this.txtBoxA.Text; }
        public string ValueB { get => this.txtBoxB.Text; }
        public string Result { set => this.lblResValue.Text = value; }

        
    }
}
