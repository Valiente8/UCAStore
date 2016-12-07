using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UCAStore.Startup))]
namespace UCAStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
