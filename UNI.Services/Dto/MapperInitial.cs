
using AutoMapper;
using UNI.Models;
namespace UNI.Services
{
    public class MapperInitial: Profile
    {
        public MapperInitial()
        {
            CreateMap<Category, CategoryCreateDto>()
                .ForMember(origen => origen.Name, dest => dest.MapFrom(x => x.name))
                .ForMember(origen => origen.IsActive, dest => dest.MapFrom(x => x.is_active))
                .ForMember(origen => origen.CategoryId, dest => dest.MapFrom(x => x.category_id))
                .ReverseMap();

            CreateMap<UnitMeasure, UnitMeasureCreateDto>()
                .ForMember(origen => origen.Name, dest => dest.MapFrom(x => x.name))
                .ForMember(origen => origen.IsActive, dest => dest.MapFrom(x => x.is_active))
                .ForMember(origen => origen.UnitMeasureId, dest => dest.MapFrom(x => x.unit_measure_id))
                .ReverseMap();

            CreateMap<SubCategory, SubCategoryDto>()
               .ForMember(origen => origen.Name, dest => dest.MapFrom(x => x.name))
               .ForMember(origen => origen.IsActive, dest => dest.MapFrom(x => x.is_active))
               .ForMember(origen => origen.SubCategoryId, dest => dest.MapFrom(x => x.subcategory_id))
               .ReverseMap();   
        }
    }
}
