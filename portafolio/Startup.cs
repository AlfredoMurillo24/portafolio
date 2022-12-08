using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(portafolio.Startup))]
namespace portafolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
