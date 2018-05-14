using AutoMapper;


namespace ProjetoFortes.Presentation.UI.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<MappingProfiles>();
            });
            Mapper.Configuration.AssertConfigurationIsValid();
        }
    }
}