using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EnjoyPictures.Startup))]
namespace EnjoyPictures
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
