using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var timer = new CountDown();

            var subscriberA = new Subscriber(timer, "Андрей");
            var subscriberB = new Subscriber(timer, "Борис");
            var subscriberC = new Subscriber(timer, "Василий");

            timer.Skip(1000, "Событие 1");
            timer.Skip(1000, "Событие 2");
            subscriberA.Ubsubscribe();
            timer.Skip(2000, "Событие 3");
            subscriberB.Ubsubscribe();
            timer.Skip(1000, "Событие 4");
            subscriberC.Ubsubscribe();
            timer.Skip(1000, "Событие 5");
            Console.ReadKey();
        }
    }
}
