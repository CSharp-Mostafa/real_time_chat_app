using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(SignalRMidExam.Startup))]

namespace SignalRMidExam
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            app.MapSignalR();

        }

    }
}
