// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Anixe.IO.AspNetCore.ResponseCaching;
using Anixe.IO.AspNetCore.ResponseCaching.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Anixe.IO.Extensions.DependencyInjection
{
    /// <summary>
    /// Extension methods for the ResponseCaching middleware.
    /// </summary>
    public static class ResponseCachingServicesExtensions
    {
        /// <summary>
        /// Add response caching services.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> for adding services.</param>
        /// <returns></returns>
        public static IServiceCollection AddAnixeResponseCaching(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.TryAdd(ServiceDescriptor.Singleton<IResponseCachingPolicyProvider, ResponseCachingPolicyProvider>());
            services.TryAdd(ServiceDescriptor.Singleton<IResponseCachingKeyProvider, ResponseCachingKeyProvider>());

            return services;
        }

        /// <summary>
        /// Add response caching services and configure the related options.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> for adding services.</param>
        /// <param name="configureOptions">A delegate to configure the <see cref="ResponseCachingOptions"/>.</param>
        /// <returns></returns>
        public static IServiceCollection AddAnixeResponseCaching(this IServiceCollection services, Action<ResponseCachingOptions> configureOptions)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            if (configureOptions == null)
            {
                throw new ArgumentNullException(nameof(configureOptions));
            }

            services.Configure(configureOptions);
            services.AddAnixeResponseCaching();

            return services;
        }
    }
}
