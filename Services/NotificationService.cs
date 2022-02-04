using System;
using Module2HW5.Interfaces;

namespace Module2HW5.Services
{
    public class NotificationService : INotificationService
    {
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
