using AutoMapper;
using Quitanda.CrossCutting.DTO.Fruta;
using Quitanda.CrossCutting.DTO.Usuario;
using Quitanda.CrossCutting.Helper;
using Quitanda.Domain.Entidades;

namespace Quitanda.API.Mapper
{
    public class MapperDtoToEntity : Profile
    {
        public MapperDtoToEntity()
        {
            CreateMap<FrutaInsertDTO, Fruta>();
            CreateMap<FrutaUpdateDTO, Fruta>();
            CreateMap<FrutaDTO, Fruta>();

            CreateMap<UsuarioDTO, Usuario>();
            CreateMap<UsuarioUpdateDTO, Usuario>();
            CreateMap<UsuarioInsertDTO, Usuario>()
                .ForMember(to => to.Senha, map => map.MapFrom(from => EncryptHelper.EncryptPassword(from.Senha)));
        }
    }
}