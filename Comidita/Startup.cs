using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Comidita.Startup))]
namespace Comidita
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
