using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mentor_DevChallenge.Startup))]
namespace Mentor_DevChallenge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
