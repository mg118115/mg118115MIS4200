using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mg118115MIS4200.Startup))]
namespace mg118115MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
