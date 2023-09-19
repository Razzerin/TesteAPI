using AeCTeste.Dtos;
using AeCTeste.Models;

namespace AeCTeste.Interfaces
{
    public interface IBrasilAPI
    {
        Task<ClimaCidadeModel> BuscarClimaPorCodigoCidade(string codigo);
        //Task BuscarClimaPorCodigoCidade(int codigo);
        Task<ResponseGenerico<ClimaAeroModel>> BuscarClimaPorIcao(string icaocode);
    }
}
