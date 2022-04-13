using Client.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.BanqueServiceClient stub = 
                new ServiceReference1.BanqueServiceClient();
            Console.WriteLine(stub.conversionEuroToDH(80));
            ServiceReference1.compte cp = stub.getCompte(5);
            Console.WriteLine(cp.code);
            Console.WriteLine(cp.solde);
            ServiceReference1.compte[] cptes = stub.listComptes();
            foreach (var c in cptes)
            {
                Console.WriteLine("------------------");
                Console.WriteLine(c.code);
                Console.WriteLine(c.solde);
            }
            Console.ReadLine();
        }

      
    }
    
}
