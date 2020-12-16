using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SrvClient.ServiceReference1;

namespace SrvClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                CalculatorClient cli = new CalculatorClient();
                var n1 = 500.00D;
                var n2 = 210.00D;
                var add = await cli.AddAsync(n1, n2);
                var subt = await cli.SustractAsync(n1, n2);
                var mult = await cli.MultiplyAsync(n1, n2);
                var div = await cli.DivideAsync(n1, n2);
                Console.WriteLine($"FOR NUMS: {n1} and {n2}\n" +
                    $"ADD: {add}\n" +
                    $"SUBTRACT:{subt}\n" +
                    $"MULT:{mult}\n" +
                    $"DIV:{div}");
                Console.WriteLine("Press Enter to Finish!");
                Console.ReadLine();
                cli.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
