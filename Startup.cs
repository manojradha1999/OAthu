using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OAthu.Startup))]
namespace OAthu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
