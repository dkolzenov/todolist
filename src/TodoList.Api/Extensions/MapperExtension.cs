namespace TodoList.Api.Extensions
{
    using AutoMapper;

    using TodoList.Mappers.ApiProfile;

    public static class MapperExtension
    {
        public static void AddCustomAutoMapper(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ApiMappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
