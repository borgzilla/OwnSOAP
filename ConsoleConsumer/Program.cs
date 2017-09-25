using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleConsumer.Calculator;

namespace ConsoleConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Service1Client client = new Service1Client())
            {
                int adding = client.Add(5, 5);
                Console.WriteLine(adding);
            }
            using (Service1Client client = new Service1Client())
            {
                int substract = client.Sub(5, 5);
                Console.WriteLine(substract);
            }
            using (Service1Client client = new Service1Client())
            {
                int divid = client.Div(5, 5);
                Console.WriteLine(divid);
            }
            using (Service1Client client = new Service1Client())
            {
                int multi = client.Mul(5, 5);
                Console.WriteLine(multi);
            }

        }
    }
}
