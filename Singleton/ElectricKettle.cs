using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Singleton
{
    public class ElectricKettle
    {
        private static readonly ElectricKettle _electricKettle = new ElectricKettle();
        public string Status { get; set; } = "Empty";

        public static ElectricKettle GetElectricKettle()
        {
            Console.WriteLine($"Starting : {_electricKettle.Status}");
            return _electricKettle;
        }

        public void Fill()
        {
            Console.WriteLine("Filling...");
            Thread.Sleep(3000);
            SetStatus("In Progress");
            Console.WriteLine($"electric kettle : {_electricKettle.Status}");
            Thread.Sleep(1000);
        }

        public void Boil()
        {
            Console.WriteLine("Boiling...");
            Thread.Sleep(3000);
            SetStatus("Boiled");
            Console.WriteLine($"electric kettle : {_electricKettle.Status}");
        }

        public void Drain()
        {
            Console.WriteLine("Draining...");
            Thread.Sleep(3000);
            SetStatus("Empty");
            Console.WriteLine($"electric kettle : {_electricKettle.Status}");
            Thread.Sleep(1000);
        }

        public void SetStatus(string status)
        {
            _electricKettle.Status = status;
        }
    }
}
