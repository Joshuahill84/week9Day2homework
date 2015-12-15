using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(week9Day2homework.Startup))]
namespace week9Day2homework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
