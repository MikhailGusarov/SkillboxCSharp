using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    //https://docs.microsoft.com/ru-ru/aspnet/core/fundamentals/routing?view=aspnetcore-3.0

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<ICar> Get()
        {
            return Repository.GetCars();
        }


        // GET api/values/5
        public ICar GetCarById(int id)
        {
            return Repository.GetCarById(id);
        }


        
        [HttpGet]
        [Route("GetRange/{pos}/count/{count}")]
        public IEnumerable<ICar> Get(int pos, int count, int agrs = 0)
        {
            return Repository.GetCarsRange(pos, count);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Car value)
        {
            Repository.AddCar(value);
        }
 
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
