using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(capitaltoday2.Startup))]
namespace capitaltoday2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
