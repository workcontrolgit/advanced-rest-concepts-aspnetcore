using Contracts;
using DataServices.Domain.Context;
using DataServices.Domain.Helpers;
using DataServices.Domain.Models;
using DataServices.LoggerService;
using DataServices.Persistence.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace DataServices.EmployeeProfile.Extensions
{
    /// <summary>
    /// ServiceExtensions
    /// </summary>
    public static class ServiceExtensions
	{
		/// <summary>
		/// ConfigureSwaggerExtension
		/// </summary>
		/// <param name="services"></param>
		public static void ConfigureSwaggerExtension(this IServiceCollection services)
		{
			services.AddSwaggerGen(c =>
			{
				c.IncludeXmlComments(XmlCommentsFilePath);
				c.SwaggerDoc("v1", new OpenApiInfo
				{
					Version = "v1",
					Title = "GTM Data Services - Employee Profile",
					Description = "This Api will be responsible for overall data distribution and authorization.",
					Contact = new OpenApiContact
					{
						Name = "GTMWebAPI Team",
						Email = "hello@gtmmiddlewareteam.com",
						Url = new Uri("https://gtmmiddlewareteam.com/contact"),
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
		}
		/// <summary>
		/// ConfigureCors
		/// </summary>
		/// <param name="services"></param>
		public static void ConfigureCors(this IServiceCollection services)
		{
			services.AddCors(options =>
			{
				options.AddPolicy("CorsPolicy",
					builder => builder.WithOrigins("http://localhost:5000", "https://localhost:5001")
					.AllowAnyMethod()
					.AllowAnyHeader()
					.AllowCredentials());
			});
		}
		/// <summary>
		/// ConfigureIISIntegration
		/// </summary>
		/// <param name="services"></param>
		public static void ConfigureIISIntegration(this IServiceCollection services)
		{
			services.Configure<IISOptions>(options =>
			{

			});
		}
		/// <summary>
		/// ConfigureLoggerService
		/// </summary>
		/// <param name="services"></param>
		public static void ConfigureLoggerService(this IServiceCollection services)
		{
			services.AddSingleton<ILoggerManager, LoggerManager>();
		}
		/// <summary>
		/// ConfigureMsSqlContext
		/// </summary>
		/// <param name="services"></param>
		/// <param name="config"></param>
		public static void ConfigureMsSqlContext(this IServiceCollection services, IConfiguration config)
		{
			services.AddDbContext<ApplicationDbContext>(options =>
		   options.UseSqlServer(
			   config.GetConnectionString("DefaultConnection"),
			   b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
		}
		/// <summary>
		/// ConfigureRepositoryWrapper
		/// </summary>
		/// <param name="services"></param>
		public static void ConfigureRepositoryWrapper(this IServiceCollection services)
		{
			services.AddScoped<ISortHelper<Employee>, SortHelper<Employee>>();
			services.AddScoped<ISortHelper<Assignment>, SortHelper<Assignment>>();

			services.AddScoped<IDataShaper<Employee>, DataShaper<Employee>>();
			services.AddScoped<IDataShaper<Assignment>, DataShaper<Assignment>>();

			services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
		}
		static string XmlCommentsFilePath
		{
			get
			{
				var basePath = PlatformServices.Default.Application.ApplicationBasePath;
				var fileName = typeof(EmployeeProfile.Startup).GetTypeInfo().Assembly.GetName().Name + ".xml";
				return Path.Combine(basePath, fileName);
			}
		}

	}
}
