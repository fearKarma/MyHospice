using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyHospice.Startup))]
namespace MyHospice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
