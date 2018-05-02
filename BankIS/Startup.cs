using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BankIS.Startup))]
namespace BankIS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
