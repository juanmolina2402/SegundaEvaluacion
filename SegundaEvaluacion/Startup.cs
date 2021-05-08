using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SegundaEvaluacion.Startup))]
namespace SegundaEvaluacion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
