using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomeSite.Startup))]
namespace CustomeSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
