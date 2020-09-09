using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarViewApp.DataContext;
using CarViewApp.Models;

namespace CarViewApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CarDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Cars.Any()) return;

            var sections = new List<Car>()
            {
                new Car(){Id =1, CarMark="Audi", CarModel="Q8", CarEngine=3 },
                new Car(){Id =2, CarMark="Audi", CarModel="Q7", CarEngine=3 },
                new Car(){Id =3, CarMark="Audi", CarModel="A4", CarEngine=2 }
            };
            using (var trans = context.Database.BeginTransaction())
            {
                foreach (var section in sections)
                {
                    context.Cars.Add(section);
                }

                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Cars] ON");
                context.SaveChanges();
                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Cars] OFF");
                trans.Commit();
            }


        }
    }
}