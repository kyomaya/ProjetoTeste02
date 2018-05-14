using SimpleInjector;
using SimpleInjector.Integration.Web;
using ProjetoFortes.Infraestructure.CrossCutting.IoC;
using System.Reflection;
using System.Web.Mvc;
using SimpleInjector.Integration.Web.Mvc;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(ProjetoFortes.Presentation.MVC.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace ProjetoFortes.Presentation.MVC.App_Start
{
    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as Web API Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }

        private static void InitializeContainer(Container container)
        {
            BootStrapper.Register(container);
        }
    }
}