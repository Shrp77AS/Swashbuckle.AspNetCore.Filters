﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Converters;
using Swashbuckle.AspNetCore.Filters;
using Swashbuckle.AspNetCore.Filters.Extensions;
using Swashbuckle.AspNetCore.Swagger;
using WebApi.Models.Examples;

namespace WebApi2._0_Swashbuckle4
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
            services
            .AddMvc(options => {
                options.InputFormatters.Add(new XmlSerializerInputFormatter());
                options.OutputFormatters.Add(new XmlSerializerOutputFormatter());
            })
            .AddJsonOptions(opt => opt.SerializerSettings.Converters.Add(new StringEnumConverter()));

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v2" });

                options.ExampleFilters();

                options.OperationFilter<AddHeaderOperationFilter>("correlationId", "Correlation Id for the request");

                options.OperationFilter<AddResponseHeadersFilter>();

                options.DescribeAllEnumsAsStrings();

                var filePath = Path.Combine(AppContext.BaseDirectory, "WebApi.xml");
                options.IncludeXmlComments(filePath);

                options.OperationFilter<AppendAuthorizeToSummaryOperationFilter>();

                options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Description = "Standard Authorization header using the Bearer scheme. Example: \"bearer {token}\"",
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });

                options.OperationFilter<SecurityRequirementsOperationFilter>();

                options.IgnoreObsoleteProperties();
            });
            
            services.AddSwaggerExamplesFromAssemblyOf<PersonResponseExample>();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("Administrator", authBuilder =>
                {
                    authBuilder.AddAuthenticationSchemes("bearer");
                    authBuilder.RequireRole("Administrator");
                });
                options.AddPolicy("Customer", authBuilder =>
                {
                    authBuilder.AddAuthenticationSchemes("Bearer");
                    authBuilder.RequireRole("Customer");
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.UseSwagger(c => c.SerializeAsV2 = false);

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
        }
    }
}
