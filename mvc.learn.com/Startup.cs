using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc.learn.com.Startup))]
namespace mvc.learn.com
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
