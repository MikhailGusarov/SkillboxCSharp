﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Car : ICar
    {
        
        public int Id { get; set; }
        public string CarModel { get; set; }
        public string CarMark { get; set; }
        public double CarEngine { get; set; }
    }
}
