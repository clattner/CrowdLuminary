using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrowdLuminary02.Startup))]
namespace CrowdLuminary02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
