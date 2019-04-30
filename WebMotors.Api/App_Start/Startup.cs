using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using WebMotors.CrossCutting.IoC;
using Microsoft.Owin.Cors;

[assembly: OwinStartup(typeof(WebMotors.Api.App_Start.Startup))]

namespace WebMotors.Api.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            WebApiConfig.Register(config);
            //Ninject Configuration
            app.UseCors(CorsOptions.AllowAll);
            app.UseNinjectMiddleware(IoC.Configure);
            app.UseNinjectWebApi(config);
        }
    }
}
