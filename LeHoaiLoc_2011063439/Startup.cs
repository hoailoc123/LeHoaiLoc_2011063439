using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeHoaiLoc_2011063439.Startup))]
namespace LeHoaiLoc_2011063439
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
