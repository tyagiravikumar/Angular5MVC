using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ETS.Startup))]
namespace ETS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
