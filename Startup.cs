using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Skills_A.Startup))]
namespace MVC_Skills_A
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
