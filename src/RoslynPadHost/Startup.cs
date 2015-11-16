using System.Net.Http.Formatting;
using System.Web.Http;
using Microsoft.Owin.Extensions;
using Owin;

namespace RoslynPadHost
{
    public class Startup
    {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder)
        {
            // Configure Web API for self-host. 
            HttpConfiguration config = new HttpConfiguration();
            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}",
                defaults: new { id = RouteParameter.Optional }
                );

            appBuilder.UseWebApi(config);
            appBuilder.UseNancy();
        }
    }
}