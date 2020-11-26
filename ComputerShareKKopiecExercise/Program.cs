using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShareKKopiecExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 0)
            {
                Console.WriteLine("Usage:");
                Console.WriteLine("ComputerShareKKopiecExercise DataFilePath");
                Console.WriteLine("Press any key to finish");
                Console.ReadKey();
                return;
            }
            string[] rawData;
            try
            {
                rawData = IOHelpers.ReadDataFile(args[0]);
            } catch (FileNotFoundException e) {
                Console.WriteLine(e.Message);
                Console.WriteLine("Press any key to finish");
                Console.ReadKey();
                return;
            }
            List<Tuple<int, double>> data = new List<Tuple<int, double>>();
            try
            {
                data = IOHelpers.CreateDataset(rawData);
            } catch (FormatException e)
            {
                Console.WriteLine("Incorrect or misformated data in " + args[0]);
                Console.WriteLine(e.Message);
                Console.WriteLine("Press any key to finish");
                Console.ReadKey();
                return;
            }

            var result = Calculator.BestPurchaseSale(data);
            var purchase = result.Item1;
            var sell = result.Item2;
            string output = purchase.Item1 +
                "(" +
                purchase.Item2.ToString("F", CultureInfo.InvariantCulture) +
                ")," +
                sell.Item1 +
                "(" +
                sell.Item2.ToString("F", CultureInfo.InvariantCulture) +
                ")";
            Console.WriteLine(output);
            Console.WriteLine("Press any key to finish");
            Console.ReadKey();
        }
    }
}
