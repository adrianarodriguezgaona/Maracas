﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaracasMusic.API.Data;
using MaracasMusic.API.Repositories;
using MaracasMusic.API.Services.AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace MaracasMusic.API
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<MaracasContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Maracas")));
            services.AddScoped<ArtistRepository>();
            services.AddScoped<ProductRepository>();
            services.AddScoped<GenreRepository>();
            services.AddScoped<OrderRepository>();
            services.AddScoped<OrderDetailRepository>();
            services.AddScoped<InstrumentTypeRepository>();
            services.AddScoped<ProductTypeRepository>();
            services.AddScoped<ClientRepository>();


            services.AddMvc().AddJsonOptions(ConfigureJson);

            var config = new AutoMapper.MapperConfiguration(
               cfg => {
                   cfg.AddProfile(new AutoMapperProfileConfiguration());
               });

            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            services.AddCors();


        }

        private void ConfigureJson(MvcJsonOptions obj)
        {
            obj.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseCors(builder =>
            builder.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod());

            app.UseMvc();
        }
    }
}
