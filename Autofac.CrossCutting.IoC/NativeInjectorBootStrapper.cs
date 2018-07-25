using Domain.Interfaces;
using Infrastructure.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofac.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {

        public static IContainer Registers()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<SmsRepository>().As<INotificationRepository<SmsRepository>>().InstancePerDependency();
            builder.RegisterType<EmailRepository>().As<INotificationRepository<EmailRepository>>().InstancePerDependency();

            return builder.Build();
        }

    }
}
