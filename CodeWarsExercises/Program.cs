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
           var  list = Revrot.ExtractChunks("5435555555555754555555255558555", 5);
            foreach (var chunk in list)
            {
                Console.WriteLine(chunk);

                Console.ReadKey();

            }
        }
    }
}
