using AutoMapper;
using Quitanda.CrossCutting.DTO.Fruta;
using Quitanda.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quitanda.API.Mapper
{
    public class MapperEntityToDto :Profile
    {
        public MapperEntityToDto()
        {
            CreateMap<Fruta,FrutaInsertDTO>();
            CreateMap<Fruta,FrutaUpdateDTO>();
            CreateMap<Fruta, FrutaDTO>();

            //CreateMap<UserInsertDTO, User>()
            //    .ForMember(to => to.Password, map => map.MapFrom(from => EncryptHelper.EncryptPassword(from.Password)));

            //CreateMap<UserUpdateDTO, User>();
        }
    }
}

