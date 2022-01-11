using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitMVC2.Startup))]
namespace GitMVC2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
