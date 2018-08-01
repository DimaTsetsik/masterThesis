using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FFilms.Startup))]
namespace FFilms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
