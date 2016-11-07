using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(G.Startup))]
namespace G
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
