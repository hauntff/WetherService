using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;


    namespace WeatherService
    {
        public class GetWeather
        {

            private string apiConnectionString = "https://api.openweathermap.org/data/2.5/weather";
            private string apiKey = "835ed7bc25623c9d153de2150026fdb1";
            public Root GetWeathers(string city)
            {
                var client = new RestClient(apiConnectionString);
                var reuqest = new RestRequest(Method.GET);

                reuqest.AddParameter("q", city);
                reuqest.AddParameter("apiKey", apiKey);

                var root = client.Execute<Root>(reuqest);
                if (root.IsSuccessful)
                {
                    return root.Data;
                }
                return null;
            }

        }
    }


