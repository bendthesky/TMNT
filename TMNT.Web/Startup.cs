using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TMNT.Web.Startup))]
namespace TMNT.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
