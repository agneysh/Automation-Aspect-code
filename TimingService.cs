﻿using System.Threading;
using System.Threading.Tasks;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

using PostSharp.Patterns.Model;
using PostSharp.Patterns.Threading;

using Serilog;

using ILogger = Serilog.ILogger;


namespace Automation
{
    [Actor]
    public class TimingService : IHostedService
    {
        [Reference] private GenericPlatform _platform;
        [Reference] private readonly ILogger _log = Log.ForContext<TimingService>();
        [Child] private INativeClass _nativeTimers { get; set; }

        public TimingService(IOptions<AppConfig> options)
        {
            _platform = options.Value.Platform;
        }

        [Reentrant]
        public async Task StartAsync(CancellationToken cancellationToken)
        {
            _log.Information("[Timing Service]: Calling out to the platform for native timers.");
            _nativeTimers = (INativeClass)_platform.GetNativeClass("Automation", "NativeTimers");
            await _nativeTimers.Initialize(this);
        }

        [Reentrant]
        public async Task StopAsync(CancellationToken cancellationToken)
        {
            _log.Warning("[Timing Service]: Terminating this service.");
            await _nativeTimers.Terminate("The timing service is being shut down by the host.");
        }
    }
}