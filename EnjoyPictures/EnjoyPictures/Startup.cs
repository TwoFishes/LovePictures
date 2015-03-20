using Microsoft.Owin;
using Owin;
using System;

[assembly: OwinStartupAttribute(typeof(EnjoyPictures.Startup))]
namespace EnjoyPictures
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            Console.Write("HELLO LITTLE SHIT");
        }
    }
}
