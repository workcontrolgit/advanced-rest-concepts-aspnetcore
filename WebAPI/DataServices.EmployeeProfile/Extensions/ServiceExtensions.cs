using DataServices.Core.Application.Interfaces;
using DataServices.Core.Domain.Context;
using DataServices.Core.Domain.Interfaces;
using DataServices.Core.Domain.Entities;
using DataServices.Infrastructure.LoggerService;
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
using DataServices.Core.Domain.Common;
using Microsoft.AspNetCore.Mvc;

namespace DataServices.WebAPI.Extensions
{
    /// <summary>
    /// ServiceExtensions
    /// </summary>
    public static class ServiceExtensions
	{
		/// <summary>
		/// AddSwaggerExtension
		/// </summary>
		/// <param name="services"></param>
		public static void AddSwaggerExtension(this IServiceCollection services)
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
		/// AddCors
		/// </summary>
		/// <param name="services"></param>
		public static void AddCors(this IServiceCollection services)
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
		public static void AddApiVersioningExtension(this IServiceCollection services)
		{
			services.AddApiVersioning(config =>
			{
				// Specify the default API Version as 1.0
				config.DefaultApiVersion = new ApiVersion(1, 0);
				// If the client hasn't specified the API version in the request, use the default API version number 
				config.AssumeDefaultVersionWhenUnspecified = true;
				// Advertise the API versions supported for the particular endpoint
				config.ReportApiVersions = true;
			});
		}
		public static void AddVersionedApiExplorerExtension(this IServiceCollection services)
		{
			services.AddVersionedApiExplorer(config =>
			{
				// add the versioned api explorer, which also adds IApiVersionDescriptionProvider service
				// note: the specified format code will format the version as "'v'major[.minor][-status]"
				config.GroupNameFormat = "'v'VVV";
				// note: this option is only necessary when versioning by url segment. the SubstitutionFormat
				// can also be used to control the format of the API version in route templates                
				config.SubstituteApiVersionInUrl = true;
			});
		}
		/// <summary>
		/// AddLoggerService
		/// </summary>
		/// <param name="services"></param>
		public static void AddLoggerService(this IServiceCollection services)
		{
			services.AddSingleton<ILoggerManager, LoggerManager>();
		}
		/// <summary>
		/// AddMsSqlContext
		/// </summary>
		/// <param name="services"></param>
		/// <param name="config"></param>
		public static void AddMsSqlContext(this IServiceCollection services, IConfiguration config)
		{
			services.AddDbContext<ApplicationDbContext>(options =>
		   options.UseSqlServer(
			   config.GetConnectionString("DefaultConnection"),
			   b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
		}
		/// <summary>
		/// AddRepositoryWrapper
		/// </summary>
		/// <param name="services"></param>
		public static void AddRepositoryWrapper(this IServiceCollection services)
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
				var fileName = typeof(Startup).GetTypeInfo().Assembly.GetName().Name + ".xml";
				return Path.Combine(basePath, fileName);
			}
		}

	}
}
