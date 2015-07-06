using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MedOfficeWebApplication.Startup))]
namespace MedOfficeWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
