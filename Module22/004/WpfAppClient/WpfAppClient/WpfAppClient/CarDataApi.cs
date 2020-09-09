using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppClient
{
    public class CarDataApi
    {
        private HttpClient httpClient { get; set; }

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
            Console.WriteLine(json);
            return  JsonConvert.DeserializeObject<IEnumerable<Car>>(json);

        }
    }
}