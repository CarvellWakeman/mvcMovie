using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcMovie.Startup))]
namespace mvcMovie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
