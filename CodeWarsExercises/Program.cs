using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsExercises
{
    public class Program
    {
        static void Main(string[] args)
        {
           var  list = Revrot.ExtractChunks("00000111112222233333444445555566666777778888899999123452", 5);
            foreach (var chunk in list)
            {
                Console.WriteLine(chunk);

                Console.ReadKey();

            }
        }
    }
}
