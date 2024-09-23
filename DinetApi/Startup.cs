using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using System.Web.Http;

[assembly: OwinStartup(typeof(DinetApi.Startup))]

namespace DinetApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var configuration = new HttpConfiguration();

            WebApiConfig.Register(configuration);

            app.UseWebApi(configuration);
        }
    }
}
