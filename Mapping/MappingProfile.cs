using System.Linq;
using AutoMapper;
using Vega.Controllers.Resources;
using Vega.Models;

namespace Vega.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make,MakeResource>();
            CreateMap<Model,ModelResource>();
            CreateMap<Feature,FeatureResource>();


            //API resource to domain
            CreateMap<VehicleResource,Vehicle>()
            .ForMember(v=>v.ContactName, opt => opt.MapFrom(vr=>vr.Contact.Name))
            .ForMember(v=>v.ContactEmail, opt => opt.MapFrom(vr=>vr.Contact.Email))
            .ForMember(v=>v.Contactphone, opt => opt.MapFrom(vr=>vr.Contact.Phone))
            .ForMember(v=>v.Features, opt => opt.MapFrom(vr=>vr.Features
            .Select(id =>new VehicleFeature{FeatureId =id})));
            
            ;
        
        }
    }
}