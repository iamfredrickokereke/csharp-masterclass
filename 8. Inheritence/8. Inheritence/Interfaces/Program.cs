using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface INotfications
    {
        //Members
        void showNotifications();
        string getDate();
    }

    public class Notification : INotfications
    {
        private string sender;
        private string message;
        private string date;

        //default constructor
        public Notification()
        {
            sender = "Admin";
            message = "Yo, whats up?";
            date = " ";
        }

        public Notification(string mySender, string myMessage, string myDate)
        {
            this.sender = mySender;
            this.message = myMessage;
            this.date = myDate;
        }

        public void showNotifications()
        {
            Console.WriteLine("Message {0} - was sent by {1} - ad {2}", message, sender, date);
        }

        public string getDate()
        {
            return date;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Notification n1 = new Notification("Mantas", "tsup bro?", "20.01.2019");
            Notification n2 = new Notification("Frank", "All good", "20.01.2019");
            n1.showNotifications();
            n2.showNotifications();
            Console.Read();
        }
    }
}
