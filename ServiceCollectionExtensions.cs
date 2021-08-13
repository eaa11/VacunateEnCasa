using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea9._0.Services;

namespace Tarea9._0
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBlazoredToast(this IServiceCollection services)
        {
            return services.AddScoped<IToastService, ToastService>();
        }
    }
}
