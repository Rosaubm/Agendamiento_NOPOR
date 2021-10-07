using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AgendamientoIPS.App.Persistencia;

namespace AgendamientoIPS.App.Frontend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddSingleton<IRepositorioPaciente, RepositorioPaciente>();  //Instrucciòn para inyectar dependencia hacia cada modelo de pages
            services.AddSingleton<IRepositorioMedico, RepositorioMedico>();      //Instrucciòn para inyectar dependencia hacia cada modelo de pages
            services.AddSingleton<IRepositorioCita, RepositorioCita>();         //Instrucciòn para inyectar dependencia hacia cada modelo de pages
            services.AddSingleton<IRepositorioFactura, RepositorioFactura>();   //Instrucciòn para inyectar dependencia hacia cada modelo de pages
            services.AddSingleton<IRepositorioSede, RepositorioSede>();         //Instrucciòn para inyectar dependencia hacia cada modelo de pages
            services.AddSingleton<IRepositorioConvenio, RepositorioConvenio>(); //Instrucciòn para inyectar dependencia hacia cada modelo de pages
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
