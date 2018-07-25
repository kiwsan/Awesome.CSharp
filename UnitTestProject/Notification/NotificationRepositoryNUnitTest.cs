using Autofac;
using Domain.Interfaces;
using Infrastructure.Repositorys;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject.Startup;

namespace UnitTestProject.Notification
{

    [TestFixture]
    public class NotificationRepositoryNUnitTest : NUnitTestBase
    {

        [Test]
        public void Sending_Test()
        {


            var smsSending = _container.Resolve<INotificationRepository<SmsRepository>>();
            var emailSending = _container.Resolve<INotificationRepository<EmailRepository>>();

            smsSending.Send();
            emailSending.Send();

        }

    }
}
