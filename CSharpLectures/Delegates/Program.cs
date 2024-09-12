using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void TheDelegate();
     class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.SendMessage();
            customerManager.SendAlert();
            Console.ReadLine();
        }
    }
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("HELLO!");
        }
        public void SendAlert()
        {
            Console.WriteLine("watch your steps");
        }
    }
}
