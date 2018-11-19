using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EJ2MVCSample.Startup))]
namespace EJ2MVCSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
