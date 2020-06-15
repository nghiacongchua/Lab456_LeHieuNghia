using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lap456.Startup))]
namespace lap456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
