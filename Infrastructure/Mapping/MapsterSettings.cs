﻿using Application.MenuMaster;
using Domain.MenuMaster;
using Mapster;

namespace Infrastructure.Mapping;

public class MapsterSettings
{
    public static void Configure()
    {
        // here we will define the type conversion / Custom-mapping
        // More details at https://github.com/MapsterMapper/Mapster/wiki/Custom-mapping

        // This one is actually not necessary as it's mapped by convention
         TypeAdapterConfig<MenuMasterModel, RoleByMenuMasterDto>.NewConfig().Map(dest => dest.MenuText, src => src.MenuText);
         TypeAdapterConfig<MenuMasterModel, AllMenuMasterDto>.NewConfig().Map(dest => dest.MenuText, src => src.MenuText);
    }
}