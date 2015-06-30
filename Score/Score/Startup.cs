using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Score.Startup))]
namespace Score
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
