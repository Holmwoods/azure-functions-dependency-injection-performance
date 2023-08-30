using System;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace FunctionApp1
{
    public class SendEmail
    {
        private IServiceProvider _serviceProvider;
        private TelemetryClient _telemetry;

        public SendEmail(IServiceProvider provider)
        {
            _serviceProvider = provider;
            _telemetry = provider.GetService<TelemetryClient>();
        }

        [FunctionName("SendEmail")]
        public void Run([TimerTrigger("*/30 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            using (var operation = _telemetry.StartOperation<DependencyTelemetry>("Get Service1"))
            {
                _serviceProvider.GetService<Service1>();
            }
            using (var operation = _telemetry.StartOperation<DependencyTelemetry>("Get Service2"))
            {
                _serviceProvider.GetService<Service2>();
            }
        }
    }

    internal class Service1
    {
        public Service1(Service2 service2, Service3 service3, Service4 service4) { }
    }

    internal class Service2
    {
        public Service2(Service3 service3, Service4 service4) { }
    }
    internal class Service3
    {
        public Service3(Service4 service4) { }
    }
    internal class Service4
    {
        public Service4(Service5 service5, Service6 service6, Service7 service7) { }
    }
    internal class Service5
    {
        public Service5(Service8 service8, Service9 service9, Service10 service10, Service11 service11, Service12 service12, Service13 service13, Service14 service14) { }
    }
    internal class Service6
    {
        public Service6(Service15 service15, Service16 service16, Service17 service17, Service18 service18, Service19 service19, Service20 service20, Service21 service21, Service22 service22, Service23 service23, Service24 service24) { }
    }
    internal class Service7
    {
    }
    internal class Service8
    {
    }
    internal class Service9
    {
    }
    internal class Service10
    {
    }
    internal class Service11
    {
    }
    internal class Service12
    {
    }
    internal class Service13
    {
    }
    internal class Service14
    {
    }
    internal class Service15
    {
    }
    internal class Service16
    {
    }
    internal class Service17
    {
    }
    internal class Service18
    {
    }
    internal class Service19
    {
    }
    internal class Service20
    {
    }
    internal class Service21
    {
    }
    internal class Service22
    {
    }
    internal class Service23
    {
    }
    internal class Service24
    {
    }
}
