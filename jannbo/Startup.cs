using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jannbo.Startup))]
namespace jannbo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
