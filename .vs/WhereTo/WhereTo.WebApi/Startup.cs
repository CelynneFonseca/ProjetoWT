using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using WhereTo.Dados.Repositorio;
using WhereTo.Dominio.Entidades;
using WhereTo.Servico.Servicos;

namespace WhereTo.WebApi
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
            services.AddTransient<UsuarioServico>();
            services.AddTransient<UsuarioRepositorio>();

            services.AddTransient<AvatarServico>();
            services.AddTransient<AvatarRepositorio>();

            services.AddTransient<AdmEstabelecimentoServico>();
            services.AddTransient<AdmEstabelecimentoRepositorio>();

            services.AddTransient<CodigoServico>();
            services.AddTransient<CodigoRepositorio>();

            services.AddTransient<EstabelecimentoServico>();
            services.AddTransient<EstabelecimentoRepositorio>();

            services.AddTransient<LocalServico>();
            services.AddTransient<LocalRepositorio>();

            services.AddTransient<LocalEstabelecimentoServico>();
            services.AddTransient<LocalEstabelecimentoRepositorio>();

            services.AddTransient<ItemDetalhesServico>();
            services.AddTransient<ItemDetalhesRepositorio>();
            
            //services.AddScoped(typeof(RepositorioBase<>));
            
            services.AddCors();
            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "My Place Games",
                        Version = "v1",
                        Description = "Projeto My Place Games WebApi - angular + bootstrap + typescript",
                        Contact = new OpenApiContact
                        {
                            Name = "MPG",
                            Url = new Uri("https://myplacegames.com.br")
                        }
                    });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(x =>
                x.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
            );

            //app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
               c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyPlaceGames - v1");
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
