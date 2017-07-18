using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sampleAppKenon.Startup))]
namespace sampleAppKenon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
