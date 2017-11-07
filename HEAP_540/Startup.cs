using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HEAP_540.Startup))]
namespace HEAP_540
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
