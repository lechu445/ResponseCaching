// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Anixe.IO.AspNetCore.ResponseCaching;
using Microsoft.AspNetCore.Builder;

namespace Anixe.IO.AspNetCore.Builder
{
    public static class ResponseCachingExtensions
    {
        public static IApplicationBuilder UseAnixeResponseCaching(this IApplicationBuilder app)
        {
            ArgumentNullException.ThrowIfNull(app);

            return app.UseMiddleware<ResponseCachingMiddleware>();
        }
    }
}
