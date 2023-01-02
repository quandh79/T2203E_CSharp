using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2203E_CSharp.session6;
using WeatherN;

namespace T2203E_CSharp.BtCallApi
{
    internal class CallApi
    {
        public async Task<Main> FetchData()
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q=Hanoi,vietnam&appid=09a71427c59d38d6a34f89b47d75975c&units=metric";
            HttpClient client = new HttpClient();
            var rs = await client.GetAsync(url);
            if (rs.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string responseText = await rs.Content.ReadAsStringAsync();
                Main p = JsonConvert.DeserializeObject<Main>(responseText);
                return p;
            }
            return null;
        }

       
    }

}
