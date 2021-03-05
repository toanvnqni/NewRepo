using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HopDongCSHT.Startup))]
namespace HopDongCSHT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
