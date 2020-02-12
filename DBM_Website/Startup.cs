using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DBM_Website.Startup))]
namespace DBM_Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
