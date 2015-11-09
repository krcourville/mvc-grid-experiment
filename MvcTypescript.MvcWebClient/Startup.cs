using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcTypescript.MvcWebClient.Startup))]
namespace MvcTypescript.MvcWebClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
