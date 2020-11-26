using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShareKKopiecExcercise
{
    public static class Calculator
    {
        public static Tuple<Tuple<int, double>, Tuple<int, double>> BestPurchaseSale(List<Tuple<int, double>> data)
            {
                var (head, tail) = data;
                if (tail.Count == 0)
                {
                    return new Tuple<Tuple<int, double>, Tuple<int, double>>(head, head);
                }
                var maxThis = tail.OrderByDescending(t => t.Item2).FirstOrDefault();
                var maxThisProfitValue = maxThis.Item2 - head.Item2;
                var maxRest = BestPurchaseSale(tail);
                var maxRestProfitValue = maxRest.Item2.Item2 - maxRest.Item1.Item2;
                var best = maxThisProfitValue >= maxRestProfitValue ? new Tuple<Tuple<int, double>, Tuple<int, double>>(head, maxThis) : maxRest;
                return best;
            }
    }
}
