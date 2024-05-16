using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppBuscaCep.Models;
using Newtonsoft.Json;
namespace AppBuscaCep.Services
{
    internal class DataService
    {
        public static async Task<Endereco> GetEnderecoBycep(String cep)
        {
            Endereco end;
            using(HttpClient client = new HttpClient())
            {
                string url = "https://cep.metoda.com.br/endereco/by-cep?=" + cep;

                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    end = JsonConvert.DeserializeObject<Endereco>(json);
                }
                else
                    throw new Exception(response.RequestMessage.Content.ToString());
            }
            return end;
        }
    }
}
