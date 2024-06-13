using AutoMapper;
using Harcama.Business.Features.HarcamaBirimleriCqrs.Command.CreateHarcamaBirimleri;
using Harcama.Business.Features.HarcamaBirimleriCqrs.Command.UpdateHarcamaBirimleri;
using Harcama.Business.Features.HarcamaTalepleriCqrs.Command.CreateHarcamaTalepleri;
using Harcama.Business.Features.ProjeTanimlariCqrs.Command.CreateProjeTanimlari;
using Harcama.Business.Features.ProjeTanimlariCqrs.Command.UpdateProjeTanimlari;
using Harcama.Business.Features.Register;
using Harcama.Business.Features.SirketCqrs.Command.CreateSirket;
using Harcama.Business.Features.SirketCqrs.Command.UpdateSirket;
using Harcama.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.Business.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<CreateHarcamaBirimleri, HarcamaBirimleri>();
            CreateMap<UpdateHarcamaBirimleri, HarcamaBirimleri>();

            CreateMap<CreateSirket, Sirket>();
            CreateMap<UpdateSirket, Sirket>();

            CreateMap<CreateProjeTanimlari, ProjeTanimlari>();
            CreateMap<UpdateProjeTanimlari, ProjeTanimlari>();

            CreateMap<RegisterCommand, AppUser>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.KullaniciAdi));

            CreateMap<CreateHarcamaTalepleri,  HarcamaTalepleri>();
        }
    }
;
}
   
