using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectricKettle electricKettle = ElectricKettle.GetElectricKettle();

            electricKettle.Fill();
            electricKettle.Boil();
            electricKettle.Drain();

            Console.ReadLine();
        }
    }
}
