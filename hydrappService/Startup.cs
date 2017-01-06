using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(hydrappService.Startup))]

namespace hydrappService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}