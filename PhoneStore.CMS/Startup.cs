using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhoneStore.CMS.Startup))]
namespace PhoneStore.CMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
