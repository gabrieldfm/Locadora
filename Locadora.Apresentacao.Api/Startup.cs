using FluentValidation.AspNetCore;
using Locadora.Aplicacao;
using Locadora.Aplicacao.Dto;
using Locadora.Aplicacao.Dto.Filme;
using Locadora.Aplicacao.Dto.Genero;
using Locadora.Infra.Data.Contexto;
using Locadora.Infra.IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Apresentacao.Api
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

            services.AddMvc()
            .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<GeneroDtoValidator>())
            .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<FilmeDtoValidator>())
            .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<LocacaoDtoValidator>());

            services.AddDbContext<Contexto>(o => o.UseSqlServer(Configuration.GetConnectionString("Locadora")));
            InjecaoDependencia.Registrar(services);
            services.AddAutoMapper(x => x.AddProfile(new Mapeamentos()));

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Locadora.Apresentacao.Api", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Locadora.Apresentacao.Api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
