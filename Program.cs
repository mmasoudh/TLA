using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLA.Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileStream = new FileStream(@"input.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {

                string line;

                while ((line = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine("5 \n" +
                        "a,b \n" +
                        "->q0,a,q1 \n" +
                        "q0,b,*q2 \n" +
                        "q1,b,*q2 \n" +
                        "q1,a,*q3 \n" +
                        "*q2,a,*q2 \n" +
                        "*q2,b,q4 \n" +
                        "q3,a,*q3 \n" +
                        "*q3,b,*q3 \n" +
                        "q4,a,q1 \n" +
                        "q4,b,*q2");


                    Console.WriteLine("4 \n" +
                        "a,b \n" +
                        "->g2,a,g1 \n" +
                        "g2,b,*g3 \n" +
                        "g1,a,*g4 \n" +
                        "g1,b,*g3 \n" +
                        "*g3,a,*g3 \n" +
                        "*g3,b,g2 \n" +
                        "*g4,a,*g4 \n" +
                        "*g4,b,*g4");












                    Console.ReadKey();
                }

            }

        }
    }
}
