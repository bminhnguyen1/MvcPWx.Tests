using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcPWx.Tests.Startup))]
namespace MvcPWx.Tests
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
