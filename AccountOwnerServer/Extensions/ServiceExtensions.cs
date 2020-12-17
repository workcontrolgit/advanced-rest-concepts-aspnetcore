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

namespace DataServices.EmployeeProfile.Extensions
{
    /// <summary>
    /// ServiceExtensions
    /// </summary>
    public static class ServiceExtensions
	{
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
	}
}
