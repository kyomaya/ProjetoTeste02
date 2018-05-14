using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoFortes.Presentation.UI.MVC.Startup))]
namespace ProjetoFortes.Presentation.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
