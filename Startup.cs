using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WarehouseManagementSystem.Startup))]
namespace WarehouseManagementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            
        }
    }
}
