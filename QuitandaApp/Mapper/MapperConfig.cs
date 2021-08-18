﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quitanda.API.Mapper
{
    public class MapperConfig
    {
        private static bool _isMapped;

        public static void RegisterMappings()
        {
            if (_isMapped)
                return;

            _isMapped = true;

            AutoMapper.Mapper.Initialize(mapper =>
            {
                mapper.AddProfile<MapperDtoToEntity>();
                mapper.AddProfile<MapperEntityToDto>();
            });
        }
    }
}
