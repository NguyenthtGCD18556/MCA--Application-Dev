using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GCD0705.AppDev.Startup))]
namespace GCD0705.AppDev
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
