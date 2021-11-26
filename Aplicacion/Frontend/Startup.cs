<<<<<<< HEAD
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
using Dominio;
using Persistencia;

namespace Frontend
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
            //Inyecion de indepandencia
            services.AddScoped<IRepositorioMunicipio,RepositorioMunicipio>();
            services.AddScoped<IRepositorioDeportista,RepositorioDeportista>();
            services.AddScoped<IRepositorioEntrenador,RepositorioEntrenador>();
            services.AddScoped<IRepositorioArbitro,RepositorioArbitro>();
            services.AddScoped<IRepositorioEscuelaArbitro,RepositorioEscuelaArbitro>();
            services.AddScoped<IRepositorioPatrocinador,RepositorioPatrocinador>();
            //Registrar el contexto de datos
            services.AddDbContext<Persistencia.AppContext>();
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
=======
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
using Dominio;
using Persistencia;

namespace Frontend
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
            //Inyecion de indepandencia
            services.AddScoped<IRepositorioArbitro,RepositorioArbitro>();
            services.AddScoped<IRepositorioCancha,RepositorioCancha>();
            services.AddScoped<IRepositorioDeportista,RepositorioDeportista>();
            services.AddScoped<IRepositorioEntrenador,RepositorioEntrenador>();
            services.AddScoped<IRepositorioEquipo,RepositorioEquipo>();
            services.AddScoped<IRepositorioEscenario,RepositorioEscenario>();
            services.AddScoped<IRepositorioEscuelaArbitro,RepositorioEscuelaArbitro>();
            services.AddScoped<IRepositorioMunicipio,RepositorioMunicipio>();
            services.AddScoped<IRepositorioPatrocinador,RepositorioPatrocinador>();
            services.AddScoped<IRepositorioTorneo,RepositorioTorneo>();
            services.AddScoped<IRepositorioEquipo,RepositorioEquipo>();



            //Registrar el contexto de datos
            services.AddDbContext<Persistencia.AppContext>();
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
>>>>>>> 4b16e537cec700cdc435a1ba8473f60cf4c36360
