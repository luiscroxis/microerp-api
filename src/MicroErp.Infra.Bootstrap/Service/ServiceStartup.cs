using System.Diagnostics.CodeAnalysis;
using MicroErp.Domain.Service.Abstract.Interfaces.Email;
using MicroErp.Domain.Service.Abstract.Interfaces.Empresas;
using MicroErp.Domain.Service.Abstract.Interfaces.Users;
using MicroErp.Domain.Service.Concretes.Email;
using MicroErp.Domain.Service.Concretes.Empresas;
using MicroErp.Domain.Service.Concretes.Users;
using Microsoft.Extensions.DependencyInjection;

namespace MicroErp.Infra.Bootstrap.Service;

[ExcludeFromCodeCoverage]
public static class ServiceStartup
{
	public static IServiceCollection AddServices(this IServiceCollection services)
	{
		//Usuarios
		services.AddTransient<IUserService, UserService>();
		services.AddScoped<IAcessManager, AccessManager>();
		services.AddScoped<IEmailService, EmailService>();
		//Empresas
		services.AddScoped<IEmpresaService, EmpresaService>();

		return services;
	}
}