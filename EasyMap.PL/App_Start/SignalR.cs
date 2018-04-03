using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(EasyMap.SignalR))]
namespace EasyMap
{
    public class SignalR
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}