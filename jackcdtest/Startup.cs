using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jackcdtest.Startup))]
namespace jackcdtest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
