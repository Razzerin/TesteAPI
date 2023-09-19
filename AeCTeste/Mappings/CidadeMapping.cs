using AeCTeste.Dtos;
using AeCTeste.Models;
using AutoMapper;

namespace AeCTeste.Mappings
{
    public class CidadeMapping : Profile
    {
        public CidadeMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<CidadeResponse, ClimaCidadeModel>();
            CreateMap<ClimaCidadeModel, CidadeResponse>();
        }

    }
}
