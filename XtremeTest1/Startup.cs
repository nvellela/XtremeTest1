using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XtremeTest1.Startup))]
namespace XtremeTest1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
