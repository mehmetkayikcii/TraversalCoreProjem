using AutoMapper;
using DTOLayer.DTOs.AnnoncementDTOs;
using DTOLayer.DTOs.AppUserDTOs;
using EntityLayer.Concrete;

namespace TraversalCoreProje.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile() 
        {
            CreateMap<AnnoncementAddDto, Annoncement>();
            CreateMap<Annoncement, AnnoncementAddDto>();

            CreateMap<AppUserRegisterDTOs, AppUser>();
            CreateMap<AppUser, AppUserRegisterDTOs > ();

            CreateMap<AppUserLoginDTOs, AppUser>();
            CreateMap<AppUser, AppUserLoginDTOs>();

            CreateMap<AnnoncementListDto, Annoncement>();
            CreateMap<Annoncement,AnnoncementListDto> ();

            CreateMap<AnnoncementUpdateDto, Annoncement>();
            CreateMap<Annoncement, AnnoncementUpdateDto>();

        }
    }
}
