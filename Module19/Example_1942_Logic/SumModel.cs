using System;

namespace Example_1942_Logic
{
    public class SumModel : IModel
    {
        private string valueA;
        private string valueB;

        public SumModel()
        {
            
        }

        public void GetData(string ValueA, string ValueB)
        {
            this.valueA = ValueA;
            this.valueB = ValueB;
        }

        double a, b;

        public double Result()
        {
            if (!double.TryParse(this.valueA, out a)) throw new FormatException("Ошибка в а");
            if (!double.TryParse(this.valueB, out b)) throw new FormatException("Ошибка в b");
            return a + b;
        }
    }

    public class DivModel : IModel
    {
        private string valueA;
        private string valueB;

        public DivModel() { }

        double a, b;

        public double Result()
        {
            if (!double.TryParse(this.valueA, out a)) throw new FormatException("Ошибка в а");
            if (!double.TryParse(this.valueB, out b)) throw new FormatException("Ошибка в b");
            return a / b;
        }

        public void GetData(string ValueA, string ValueB)
        {
            this.valueA = ValueA;
            this.valueB = ValueB;
        }
    }
}