using Owin;
using Vitly.Security;

namespace Vitly
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            var startUp = new StartUp();
            startUp.ConfigureAuth(app);
        }
    }
}