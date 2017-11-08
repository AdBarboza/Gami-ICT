using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gami_ICT.Startup))]
namespace Gami_ICT
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
