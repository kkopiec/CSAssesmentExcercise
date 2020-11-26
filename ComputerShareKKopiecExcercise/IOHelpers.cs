using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShareKKopiecExcercise
{
    public static class IOHelpers
    {
        public static string[] ReadDataFile( string path)
        {
            string lines = File.ReadAllText(path);
            var values = lines.Trim().Split(',');
            return values;
        }
        public static List<Tuple<int, double>> CreateDataset(string[] rawData)
        {
            var parsedData = rawData.Select(v => Double.Parse(v)).ToArray();

            int day = 1;
            var dataset = new List<Tuple<int, double>>();
            foreach(var value in parsedData)
            {
                dataset.Add(new Tuple<int, double>(day++, value));
            }
            return dataset;
        }
    }
}
