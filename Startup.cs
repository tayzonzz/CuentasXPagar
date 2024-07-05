using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CuentasXPagar.Startup))]
namespace CuentasXPagar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
