using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhoneStore.Web.Startup))]
namespace PhoneStore.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
