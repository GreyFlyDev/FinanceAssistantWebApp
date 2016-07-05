using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinanceAssistantWebApp.Startup))]
namespace FinanceAssistantWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
