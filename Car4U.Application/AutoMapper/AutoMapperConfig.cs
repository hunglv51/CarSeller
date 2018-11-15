using AutoMapper;

namespace Car4U.Application.AutoMapper
{
    public static class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMapping()
        {
            return new MapperConfiguration(config => {
                config.AddProfile(new DomainToViewModelMappingProfile());
                config.AddProfile(new ViewModelToDomainMappingProfile());

            });
        }
    }
}