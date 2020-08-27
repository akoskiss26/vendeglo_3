using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vendeglo_3.Startup))]
namespace vendeglo_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
