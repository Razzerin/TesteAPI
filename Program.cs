using AeCTeste.API;
using System;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.Swagger;
using Newtonsoft.Json;

namespace AeCTeste
{
    class Program
    {
        static async Task Main(string[] args)
        {

            int OP;
           
             Console.WriteLine("Deseja Saber o Clima da Cidade ou Aeroporto? ");
             Console.WriteLine("===============================");
             Console.WriteLine("1 - Aeroporto");
             Console.WriteLine("2 - Cidade");
             Console.WriteLine("===============================");
             OP = Convert.ToInt32(Console.ReadLine());
             Console.Clear();

             switch (OP)
             {
                 case 1:
                     OP = 0;
                     Console.WriteLine("Selecione o Aeroporto: ");
                     Console.WriteLine("===============================");
                     Console.WriteLine("1 - Aeroporto Internacional Santos Drummond");
                     Console.WriteLine("2 - Aeroporto Internacional de Confins");
                     Console.WriteLine("3 - Aeroporto Internacional de Viracopos");
                     OP = Convert.ToInt32(Console.ReadLine());
                     break;
                 case 2:
                     OP = 0;
                     Console.WriteLine("Selecione a Cidade: ");
                     Console.WriteLine("===============================");
                     Console.WriteLine("1 - Rio de Janeiro/RJ");
                     Console.WriteLine("2 - Belo Horizonte/MG");
                     Console.WriteLine("3 - São Paulo/SP");
                     OP = Convert.ToInt32(Console.ReadLine());
                     break;
                 default:
                     Console.WriteLine("Opção Inválida. Por favor, escolha uma opção válida.");
                     Console.WriteLine();
                     break;
             }

            var apiService = new ApiService();

            
                // Chame o método GetPrimeiraRota com o código ICAO desejado
                string icaoCode = "SBAR"; // Substitua pelo código ICAO desejado
                ClimaAeroporto resultado = await apiService.GetPrimeiraRota(icaoCode);
         
           

         
           

        }

    }
}



