using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SophiyaGitDevOpsApp11Feb020.Startup))]
namespace SophiyaGitDevOpsApp11Feb020
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
