using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LibraryBars.Startup))]
namespace LibraryBars
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
