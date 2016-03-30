using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatChat.Startup))]
namespace ChatChat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            app.MapSignalR();
        }
    }
}
