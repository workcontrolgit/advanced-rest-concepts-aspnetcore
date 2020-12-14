﻿using AccountOwnerServer.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace AccountOwnerServer
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			LogManager.LoadConfiguration(String.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.ConfigureCors();

			services.ConfigureIISIntegration();

			services.ConfigureLoggerService();

			//services.ConfigureMySqlContext(Configuration);

			services.ConfigureMsSqlContext(Configuration);


			services.ConfigureRepositoryWrapper();
			services.AddSwaggerGen(c =>
			{
				c.IncludeXmlComments(string.Format(@"{0}\AccountOwnerServer.xml", System.AppDomain.CurrentDomain.BaseDirectory));
				c.SwaggerDoc("v1", new OpenApiInfo
				{
					Version = "v1",
					Title = "Clean Architecture - AccountOwnerServer",
					Description = "This Api will be responsible for overall data distribution and authorization.",
					Contact = new OpenApiContact
					{
						Name = "codewithmukesh",
						Email = "hello@codewithmukesh.com",
						Url = new Uri("https://codewithmukesh.com/contact"),
					}
				});
				c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
				{
					Name = "Authorization",
					In = ParameterLocation.Header,
					Type = SecuritySchemeType.ApiKey,
					Scheme = "Bearer",
					BearerFormat = "JWT",
					Description = "Input your Bearer token in this format - Bearer {your token here} to access this API",
				});
				c.AddSecurityRequirement(new OpenApiSecurityRequirement
				{
					{
						new OpenApiSecurityScheme
						{
							Reference = new OpenApiReference
							{
								Type = ReferenceType.SecurityScheme,
								Id = "Bearer",
							},
							Scheme = "Bearer",
							Name = "Bearer",
							In = ParameterLocation.Header,
						}, new List<string>()
					},
				});
			});
			services.AddControllers();

            //services.AddControllers(config =>
            //{
            //    config.RespectBrowserAcceptHeader = true;
            //    config.ReturnHttpNotAcceptable = true;
            //}).AddXmlDataContractSerializerFormatters()
            //.AddNewtonsoftJson();

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
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseExceptionHandler(appError =>
			{
				appError.Run(async context =>
				{
					context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
					context.Response.ContentType = "application/json";

					var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
					if (contextFeature != null)
					{
						Console.WriteLine($"Something went wrong: {contextFeature.Error}");

						await context.Response.WriteAsync(new
						{
							context.Response.StatusCode,
							Message = "Internal Server Error."
						}.ToString());
					}
				});
			});

			app.UseHttpsRedirection();

			app.UseCors("CorsPolicy");

			app.UseForwardedHeaders(new ForwardedHeadersOptions
			{
				ForwardedHeaders = ForwardedHeaders.All
			});

			//app.UseStaticFiles();

			app.UseRouting();
			app.UseSwagger();
			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "AccountOwnerServer");
			});

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
