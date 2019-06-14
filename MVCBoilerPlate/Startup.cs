using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCBoilerPlate.Startup))]
namespace MVCBoilerPlate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
