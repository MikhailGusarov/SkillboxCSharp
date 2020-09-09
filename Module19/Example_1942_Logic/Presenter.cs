using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1942_Logic
{
    public class Presenter
    {
        IView view;
        IModel model;
        public Presenter(IView View)
        {
            this.view = View;

            model = new DivModel();
        }

        public void Result()
        {
            model.GetData(view.ValueA, view.ValueB);
            string result = model.Result().ToString();
            view.Result = result;
        }
    }
}
