using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureDemoWebApp.Startup))]
namespace AzureDemoWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
