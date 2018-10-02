using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hr_management.Startup))]
namespace hr_management
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
