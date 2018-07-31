using Microsoft.Owin;
using Owin;
using Vitly;

[assembly: OwinStartup(typeof(Startup))]
namespace Vitly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
