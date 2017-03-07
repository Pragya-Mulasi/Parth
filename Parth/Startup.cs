using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Parth.Startup))]
namespace Parth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
