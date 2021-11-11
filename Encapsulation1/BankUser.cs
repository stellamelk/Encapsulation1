using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation1
{
    class BankUser
    {
        static void Main(string[] args)
        {
            Bank VTB = new Bank();
            VTB.setBalance(500);
            Console.WriteLine($"Set money balance is {VTB.getBalance()} USD");
            Console.WriteLine("Press any key to exist");
            Console.ReadLine();
        }
    }
}
