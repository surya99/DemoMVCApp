using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoMVCApp.Startup))]
namespace DemoMVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
