﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;

namespace Client
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
            //jwt here
            services.AddAuthorization();
            //this will make JSON as statement case
            services.AddMvc()
                           .AddJsonOptions(o =>
                           {
                               if (o.SerializerSettings.ContractResolver != null)
                               {
                                   var castedResolver = o.SerializerSettings.ContractResolver
                                    as DefaultContractResolver;
                                   castedResolver.NamingStrategy = null;
                               }
                           });

            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseAuthentication();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }

            app.UseDefaultFiles();

            app.UseSession();

            app.UseStaticFiles();

            app.UseMvc();
        }
    }
}
