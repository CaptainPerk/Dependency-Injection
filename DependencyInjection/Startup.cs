using DependencyInjection.Models;
using DependencyInjection.Models.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection
{
    public class Startup
    {
        private IHostingEnvironment _hostingEnvironment;

        public Startup(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IRepository>(sp =>
            {
                if (_hostingEnvironment.IsDevelopment())
                {
                    return sp.GetService<MemoryRepository>();
                }

                return new AlternateRepository();
            });
            services.AddTransient<MemoryRepository>();
            services.AddTransient<IModelStorage, DictionaryStorage>();
            services.AddTransient<ProductTotalizer>();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStatusCodePages();
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
