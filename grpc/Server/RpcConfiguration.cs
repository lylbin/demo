﻿using Autofac;
using Grpc.Core;
using Grpc.HealthCheck;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Server
{
    public static class RpcConfiguration
    {
        private static Grpc.Core.Server _server;
        private static IContainer _container;

        public static void Start(IConfigurationRoot config)
        {
            var builder = new ContainerBuilder();

            builder.RegisterInstance(config).As<IConfigurationRoot>();
            //builder.RegisterInstance(new DataContext(config)).As<IDataContext>();
            //builder.RegisterAssemblyTypes(typeof(IDataContext).GetTypeInfo().Assembly).Where(t => t.Name.EndsWith("Repository")).AsImplementedInterfaces();

            _container = builder.Build();
            var servercert = File.ReadAllText(@"server.crt");
            var serverkey = File.ReadAllText(@"server.key");
            var keypair = new KeyCertificatePair(servercert, serverkey);
            var sslCredentials = new SslServerCredentials(new List<KeyCertificatePair>() { keypair });
            var healthService = new HealthServiceImpl();
            _server = new Grpc.Core.Server
            {
                Services = { MsgService.BindService(new MsgServiceImpl()), Grpc.Health.V1.Health.BindService(healthService) },
                Ports = { new ServerPort("0.0.0.0", 9007, sslCredentials) }
            };
            _server.Start();
            healthService.SetStatus("Demo", Grpc.Health.V1.HealthCheckResponse.Types.ServingStatus.Serving);
            _server.ShutdownTask.Wait();
        }

        public static void Stop()
        {
            _server?.ShutdownAsync().Wait();
        }
    }
}
