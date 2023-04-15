using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyNet48.Presentation.Startup))]
namespace VidlyNet48.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
