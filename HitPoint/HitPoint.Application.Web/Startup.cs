using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HitPoint.Application.Web.Startup))]
namespace HitPoint.Application.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
