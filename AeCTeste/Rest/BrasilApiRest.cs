using AeCTeste.Dtos;
using AeCTeste.Interfaces;
using AeCTeste.Models;
using System.Dynamic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AeCTeste.Rest
{
    public class BrasilApiRest : IBrasilAPI

    {
        public async Task<ClimaCidadeModel> BuscarClimaPorCodigoCidade(string cityCode)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cptec/v1/clima/previsao/{cityCode}");

            var response = new ClimaCidadeModel();
            using ( var client = new HttpClient() ) { 
            
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                response = JsonSerializer.Deserialize<ClimaCidadeModel>(contentResp);

                /*if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.DadosRetorno = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>( contentResp );
                }*/

            }
            return response;
        }

        public Task<ResponseGenerico<ClimaAeroModel>> BuscarClimaPorIcao(string icaocode)
        {
            throw new NotImplementedException();
        }
    }
}
