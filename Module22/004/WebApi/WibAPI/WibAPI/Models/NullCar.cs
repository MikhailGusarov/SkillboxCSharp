using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class NullCar : ICar
    {
        private NullCar()
        {
            this.Id = 0;
            this.CarModel = "nil";
            this.CarMark = "nil";
            this.CarModel = "nil";
            this.CarEngine = 0;
        }

        static public NullCar Create()
        {
            return new NullCar();
        }

        public int Id { get; set; }
        public string CarModel { get; set; }
        public string CarMark { get; set; }
        public double CarEngine { get; set; }
    }
}
