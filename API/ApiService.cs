using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using AeCTeste;

namespace AeCTeste.API
{
    public class ApiService
    {
     

        public async Task<ClimaAeroporto> GetPrimeiraRota(string icaoCode)
        {
            using HttpClient client = new HttpClient { BaseAddress = new Uri("https://brasilapi.com.br/api/cptec/v1/clima/aeroporto/") };
            {
                try
                {
                    var response = await client.GetAsync(icaoCode);
                    response.EnsureSuccessStatusCode();
                    var content = await response.Content.ReadAsStringAsync();

                    ImprimirResultadoJson(content);

                    return JsonConvert.DeserializeObject<ClimaAeroporto>(content);
                    
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"Erro na requisição HTTP: {ex.Message}");
                    return default;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                    return default;
                }
            }
        }


        public async Task<ClimaCidade> GetSegundaRota(string cityCode)
        {
            using HttpClient client = new HttpClient { BaseAddress = new Uri("https://brasilapi.com.br/api/cptec/v1/clima/previsao/") };
            {
                try
                {
                    var response = await client.GetAsync(cityCode);
                    response.EnsureSuccessStatusCode();
                    var content = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<ClimaCidade>(content);
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"Erro na requisição HTTP: {ex.Message}");
                    return default;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                    return default;
                }
            }
        }


        private void ImprimirResultadoJson(string json)
        {
            Console.WriteLine(json);
        }

    }
}

