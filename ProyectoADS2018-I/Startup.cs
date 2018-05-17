using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoADS2018_I.Startup))]
namespace ProyectoADS2018_I
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
