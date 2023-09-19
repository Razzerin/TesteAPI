using AeCTeste.Dtos;
using AeCTeste.Interfaces;
using AeCTeste.Models;
using AutoMapper;

namespace AeCTeste.Services
{
    public class CidadeService : IClimaCidadeServices
    {
        private readonly IMapper _mapper;
        private readonly IBrasilAPI _brasilAPI;

        public CidadeService(IMapper mapper, IBrasilAPI brasilAPI)
        {
            _mapper = mapper;
            _brasilAPI = brasilAPI;
        }

        public async Task<ClimaCidadeModel> BuscarClimaCidade(string codigo)
        {

            return await _brasilAPI.BuscarClimaPorCodigoCidade(codigo);

            //_mapper.Map<CidadeResponse>(cidade);
        }
        //var cidade = await _brasilAPI.BuscarClimaPorCodigoCidade(codigo);
            
    }
}
