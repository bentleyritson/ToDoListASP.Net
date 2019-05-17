using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewToDoList.Startup))]
namespace NewToDoList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
