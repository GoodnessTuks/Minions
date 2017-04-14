using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Minion.Startup))]
namespace Minion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
