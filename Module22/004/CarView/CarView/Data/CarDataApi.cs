using CarViewApp.Interfaces;
using CarViewApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CarView.Data
{
    public class CarDataApi : ICarData
    {

        private  HttpClient httpClient { get; set; }

        public CarDataApi()
        {
            httpClient = new HttpClient();
        }
        public void AddCar(Car car)
        {
            string url = @"https://localhost:44307/api/values";

            var r = httpClient.PostAsync(
                requestUri: url,
                content: new StringContent(JsonConvert.SerializeObject(car), Encoding.UTF8,
                mediaType: "application/json")
                ).Result;

        }

        public IEnumerable<Car> GetCars()
        {
            string url = @"https://localhost:44307/api/values";

            string json = httpClient.GetStringAsync(url).Result;

            return JsonConvert.DeserializeObject<IEnumerable<Car>>(json);

        }
    }
}
