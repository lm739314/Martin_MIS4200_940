using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Martin_MIS4200_940.Startup))]
namespace Martin_MIS4200_940
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
