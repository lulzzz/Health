﻿// <copyright file="IHealthOutputFormatter.cs" company="Allan Hardy">
// Copyright (c) Allan Hardy. All rights reserved.
// </copyright>

using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace App.Metrics.Health.Formatters
{
    public interface IHealthOutputFormatter
    {
        HealthMediaTypeValue MediaType { get; }

        Task WriteAsync(
            Stream output,
            HealthStatus healthStatus,
            CancellationToken cancellationToken = default);
    }
}