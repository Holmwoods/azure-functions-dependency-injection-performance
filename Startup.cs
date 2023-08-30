using FunctionApp1;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Startup))]
namespace FunctionApp1
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddScoped<Service1>();
            builder.Services.AddScoped<Service2>();
            builder.Services.AddScoped<Service3>();
            builder.Services.AddScoped<Service4>();
            builder.Services.AddScoped<Service5>();
            builder.Services.AddScoped<Service6>();
            builder.Services.AddScoped<Service7>();
            builder.Services.AddScoped<Service8>();
            builder.Services.AddScoped<Service9>();
            builder.Services.AddScoped<Service10>();
            builder.Services.AddScoped<Service11>();
            builder.Services.AddScoped<Service12>();
            builder.Services.AddScoped<Service13>();
            builder.Services.AddScoped<Service14>();
            builder.Services.AddScoped<Service15>();
            builder.Services.AddScoped<Service16>();
            builder.Services.AddScoped<Service17>();
            builder.Services.AddScoped<Service18>();
            builder.Services.AddScoped<Service19>();
            builder.Services.AddScoped<Service20>();
            builder.Services.AddScoped<Service21>();
            builder.Services.AddScoped<Service22>();
            builder.Services.AddScoped<Service23>();
            builder.Services.AddScoped<Service24>();
        }
    }
}
