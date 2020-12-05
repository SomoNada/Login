using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AbelBonilla.Startup))]
namespace AbelBonilla
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
