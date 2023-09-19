using AeCTeste.Dtos;
using AeCTeste.Models;

namespace AeCTeste.Interfaces
{
    public interface IClimaCidadeServices
    {
        Task<ClimaCidadeModel> BuscarClimaCidade(string codigo);
       //Task<ResponseGenerico<ClimaCidadeModel>> BuscarClimaCidade(string codigo);

    }
}
