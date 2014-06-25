using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JackieCircus.Startup))]
namespace JackieCircus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
