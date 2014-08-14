using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(branch071014.Startup))]
namespace branch071014
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
