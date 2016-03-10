using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testXampp.Startup))]
namespace testXampp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
