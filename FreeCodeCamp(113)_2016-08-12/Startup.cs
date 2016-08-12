using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FreeCodeCamp_113__2016_08_12.Startup))]
namespace FreeCodeCamp_113__2016_08_12
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
