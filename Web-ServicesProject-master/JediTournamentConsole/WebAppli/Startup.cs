using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppli.Startup))]
namespace WebAppli
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
