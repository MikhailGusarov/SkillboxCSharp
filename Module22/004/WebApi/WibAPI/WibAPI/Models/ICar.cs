using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public interface ICar
    {
        int Id { get; set; }
        string CarModel { get; set; }
        string CarMark { get; set; }
        double CarEngine { get; set; }
    }
}
