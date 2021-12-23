using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartRestaurant.UI.WebApp.Startup))]
namespace SmartRestaurant.UI.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
