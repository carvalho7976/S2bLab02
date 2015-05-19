using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab19.Startup))]
namespace Lab19
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
