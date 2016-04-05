using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PracticalAspPage.Ohio.Chardon.Startup))]
namespace PracticalAspPage.Ohio.Chardon
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
