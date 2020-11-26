using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShareKKopiecExercise
{
    static class ListExtensions
    {
         public static void Deconstruct<T> (this List<T> data, out T head, out List<T> tail)
        {
            head = data.FirstOrDefault();
            tail = new List<T>(data.Skip(1));
        }
    }
}
