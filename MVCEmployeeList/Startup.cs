using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCEmployeeList.Startup))]
namespace MVCEmployeeList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
