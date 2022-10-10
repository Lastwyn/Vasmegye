using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vasmegye
{
    class Program
    {
        static public bool CdvEll(int n, int k, int t) {

            return true;
        }
        static void Main(string[] args)
        {

            string[] adat = File.ReadAllLines(@"vas.txt");
            int[,] hasznaladat = new int[adat.Length, 3];
            for (int i = 0; i < adat.Length; i++)
            {
                string[] kell = adat[i].Split('-');
                for (int k = 0; k < kell.Length; k++)
                {
                    hasznaladat[i, k] = Convert.ToInt32(kell[k]);
                    Console.WriteLine(hasznaladat[i,k]);
                }
            }
            Console.WriteLine("2. feladat: Adatok beolvasása, tárolása");
            bool az = CdvEll(hasznaladat[1,0], hasznaladat[1, 1], hasznaladat[1, 2]);

        }
    }
}
