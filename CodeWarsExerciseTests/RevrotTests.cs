using System;
using System.Collections.Generic;
using System.Text;
using CodeWarsExercises;
using NUnit.Framework;

namespace CodeWarsExerciseTests
{
   public class RevrotTests
    {
        private static void testing(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void TestingOEmptyString()
        {  
            testing(Revrot.RevRot("", 5), "");    
        }

        [Test]
        public static void TestingForNullString()
        {
            Assert.AreEqual("", Revrot.RevRot(null,5));
           
        }

        [Test]
        public static void TestingForInvalidChunkSize()
        {
            Assert.AreEqual("", Revrot.RevRot("4309583355",-2));
        }
    }
}
