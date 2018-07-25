using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositorys
{
    public class EmailRepository : INotificationRepository<EmailRepository>
    {

        public void Send()
        {
            Console.WriteLine("Email Sending.");
        }

    }
}
