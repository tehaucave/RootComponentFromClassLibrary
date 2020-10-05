using ComponentLibrary;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RootComponentFromClassLibrary.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            // This is a hosted Blazor WebAssembly client project configured for server-side prerendering
            // (see <component> tag in RootComponentFromClassLibrary.Server/Pages/_Host.cshtml).
            // The call to WebAssemblyHostBuilder.CreateDefault(args) below fails unless the
            // preceding line is uncommented. This is because WebAssemblyHostBuilder.CreateDefault(...)
            // only searches loaded assemblies.

            //typeof(AppRoot).ToString();
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            await builder.Build().RunAsync();
        }
    }
}
