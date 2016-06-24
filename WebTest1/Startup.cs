using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebTest1.Startup))]
namespace WebTest1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
