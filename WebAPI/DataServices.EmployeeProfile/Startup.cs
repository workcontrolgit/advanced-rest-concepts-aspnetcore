using DataServices.WebAPI.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NLog;
using System;
using System.IO;
using System.Net;
using System.Text.Json;

namespace DataServices.WebAPI
{
    /// <summary>
    /// Startup
    /// </summary>
    public class Startup
	{
		/// <summary>
		/// Startup
		/// </summary>
		/// <param name="configuration"></param>
		public Startup(IConfiguration configuration)
		{
			LogManager.LoadConfiguration(String.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
			Configuration = configuration;
		}
		/// <summary>
		/// Configuration
		/// </summary>
		public IConfiguration Configuration { get; }

		/// <summary>
		/// This method gets called by the runtime. Use this method to add services to the container.
		/// </summary>
		/// <param name="services"></param>
		public void ConfigureServices(IServiceCollection services)
		{
			//services.AddCors();

			services.AddApiVersioningExtension();
			services.AddVersionedApiExplorerExtension();

			services.AddLoggerService();

			services.AddMsSqlContext(Configuration);

			services.AddRepositoryWrapper();
			services.AddSwaggerExtension();


            services.AddControllers().AddJsonOptions(options => {
				options.JsonSerializerOptions.DictionaryKeyPolicy = JsonNamingPolicy.CamelCase;
				options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
			});

		}

		/// <summary>
		/// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		/// </summary>
		/// <param name="app"></param>
		/// <param name="env"></param>
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

			//app.UseExceptionHandler(appError =>
			//{
			//	appError.Run(async context =>
			//	{
			//		context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
			//		context.Response.ContentType = "application/json";

			//		var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
			//		if (contextFeature != null)
			//		{
			//			Console.WriteLine($"Something went wrong: {contextFeature.Error}");

			//			await context.Response.WriteAsync(new
			//			{
			//				context.Response.StatusCode,
			//				Message = "Internal Server Error."
			//			}.ToString());
			//		}
			//	});
			//});

			app.UseHttpsRedirection();

			app.UseCors("CorsPolicy");

			app.UseForwardedHeaders(new ForwardedHeadersOptions
			{
				ForwardedHeaders = ForwardedHeaders.All
			});

			app.UseRouting();
			app.UseAuthentication();
			app.UseAuthorization();
			app.UseSwagger();
			app.UseSwaggerExtension();
			app.UseErrorHandlingMiddleware();
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
