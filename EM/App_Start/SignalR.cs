using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(EM.SignalR))]
namespace EM
{
    public class SignalR
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}