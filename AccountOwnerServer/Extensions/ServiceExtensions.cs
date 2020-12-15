using Contracts;
using Entities;
using Entities.Helpers;
using Entities.Models;
using LoggerService;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;

namespace GtmWebAPI.Extensions
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
		/// ConfigureMySqlContext
		/// </summary>
		/// <param name="services"></param>
		/// <param name="config"></param>
		public static void ConfigureMySqlContext(this IServiceCollection services, IConfiguration config)
		{
			var connectionString = config["mysqlconnection:connectionString"];
			services.AddDbContext<RepositoryContext>(o => o.UseMySql(connectionString));
		}
		/// <summary>
		/// ConfigureMsSqlContext
		/// </summary>
		/// <param name="services"></param>
		/// <param name="config"></param>
		public static void ConfigureMsSqlContext(this IServiceCollection services, IConfiguration config)
		{
			services.AddDbContext<RepositoryContext>(options =>
		   options.UseSqlServer(
			   config.GetConnectionString("DefaultConnection"),
			   b => b.MigrationsAssembly(typeof(RepositoryContext).Assembly.FullName)));
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
