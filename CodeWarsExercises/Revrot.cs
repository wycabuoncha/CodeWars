using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.String;

namespace CodeWarsExercises
{
    public class Revrot
    {
        public static string RevRot(string mystrng, int chunkSize)
        {
            if (!IsNullOrEmpty(mystrng) && chunkSize >= 1)
            {
                for (var i = 0; i < mystrng.Length; i+=chunkSize)
                {
                    if (chunkSize + i > mystrng.Length)
                    {
                        return "There is edge here";
                    }

                    return mystrng.Substring(i, chunkSize);
                }
                return "PASS";
            }

              
            return "";

        }


        public static IEnumerable<string> ExtractChunks(string mystrng, int chunkSize)
        {
            var chunks = new List<string>();
            var remString = "";
            for (var i = 0; i < mystrng.Length; i+=chunkSize)
            {
                var strngRemove = mystrng.Substring(i, chunkSize);
                mystrng.Remove(i, chunkSize);
                
                chunks.Add(myNewString);
                var myS = mystrng;
                var ch = chunks.Count;

            }

            return chunks;

        }
    }
}

/*
 * public static class EnumerableEx
{    
    public static IEnumerable<string> SplitBy(this string str, int chunkLength)
    {
        if (String.IsNullOrEmpty(str)) throw new ArgumentException();
        if (chunkLength < 1) throw new ArgumentException();

        for (int i = 0; i < str.Length; i += chunkLength)
        {
            if (chunkLength + i > str.Length)
                chunkLength = str.Length - i;

            yield return str.Substring(i, chunkLength);
        }
    }
}
 */
