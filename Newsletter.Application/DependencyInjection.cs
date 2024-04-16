﻿using Microsoft.Extensions.DependencyInjection;
using Newsletter.Application.Services;
using Newsletter.Domain.Entities;

namespace Newsletter.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {

        services.AddFluentEmail("info@admin.com")
            .AddSmtpSender("localhost", 2525);

        services.AddHostedService<BlogBackgroundService>();

        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssemblies(typeof(DependencyInjection).Assembly, typeof(Blog).Assembly);     
            //AppDomain de typeof yerine yazmak için
        });

        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        return services;
    }
}
