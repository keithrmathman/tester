using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = 0, two = 0, three = 0, four = 0, five = 0, six = 0, seven = 0, eight = 0, nine = 0, therest = 0; 
            Random rnd = new Random();
            byte mainbyte = 0;
            int multiple = 7;
            byte[] dataset = new byte[100000000];
            //BigInteger t = BigInteger.Parse("100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
            int distance = 0;
            List<int> DistanceList = new List<int>();
            for (int i = 0; i < dataset.Length; i++)
            {
                dataset[i] = (byte)rnd.Next(0, 2);
            }
            for (int i = 0; i < multiple; i++)
            {
                for (int b = i; b < dataset.Length; b += multiple)
                {

                    if (dataset[b] != mainbyte)
                    {
                        DistanceList.Add(distance);
                        distance = 0;
                        mainbyte = dataset[b];
                    }

                    if (dataset[b] == 1)
                    {

                        distance++;
                    }

                    else if (dataset[b] == 0)
                    {

                        distance++;
                    }


                }
            }
            //    t = t * 100000000;

            //t = t / (t / 10000000000000);
            foreach(int i in DistanceList)
            {
                if (i == 1)
                    one++;
                if (i == 2)
                    two++;
                if (i == 3)
                    three++;
                if (i == 4)
                    four++;
                if (i == 5)
                    five++;
                if (i == 6)
                    six++;
                if (i == 7)
                    seven++;
                if (i == 8)
                    eight++;
                if (i == 9)
                    nine++;
                if (i > 9)
                    therest++;


            }
            

        }
        public void MapPermutations()
        {

        }
        public void Permute()
        {

        }
    }
}
