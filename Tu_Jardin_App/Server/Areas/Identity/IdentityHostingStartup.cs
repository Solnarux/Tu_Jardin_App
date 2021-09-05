using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tu_Jardin_App.Server.Data;
using Tu_Jardin_App.Server.Models;

[assembly: HostingStartup(typeof(Tu_Jardin_App.Server.Areas.Identity.IdentityHostingStartup))]
namespace Tu_Jardin_App.Server.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}