using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hoang.Startup))]
namespace hoang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
