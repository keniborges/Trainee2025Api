using AutoMapper;
using Senai2025Api.DTos;
using Senai2025Api.Entidades;

namespace Senai2025Api.Mappers
{
    public class EscolaMapper : Profile
    {

        public EscolaMapper()
        {
            CreateMap<EscolaDTo, Escola>().ReverseMap();
                //.ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome));

            CreateMap<EscolaEdicaoDTo, Escola>().ReverseMap();

            CreateMap<EnderecoDTo, Endereco>().ReverseMap();


        }
    }
}