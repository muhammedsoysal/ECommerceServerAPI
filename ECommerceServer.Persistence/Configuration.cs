using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace ECommerceServer.Persistence;

static class Configuration
{
    public static string ConnectionStrings
    {
        get
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../ECommerceServer/ECommerceServer.API"));
            configurationManager.SetBasePath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            configurationManager.AddJsonFile("appsettings.json");
            return configurationManager.GetConnectionString("ECommerceDb");
        }
    }
}