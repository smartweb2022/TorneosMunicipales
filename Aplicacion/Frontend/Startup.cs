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
<<<<<<< HEAD
            services.AddScoped<IRepositorioEquipo,RepositorioEquipo>();
            services.AddScoped<IRepositorioPatrocinador,RepositorioPatrocinador>();
=======
            services.AddScoped<IRepositorioEscuelaArbitro,RepositorioEscuelaArbitro>();
>>>>>>> 48e8ca12956641008b493fbc4a8ce8509091362a
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
