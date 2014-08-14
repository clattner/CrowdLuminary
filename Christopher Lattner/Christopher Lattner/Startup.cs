using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Christopher_Lattner.Startup))]
namespace Christopher_Lattner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
