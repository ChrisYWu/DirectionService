using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DirectionService.Startup))]
namespace DirectionService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
