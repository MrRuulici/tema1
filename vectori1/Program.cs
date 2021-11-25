using System;

namespace vectori1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[100];
            int n, s = 0, nrp = 0;
            int mn = int.MaxValue;
            int mx = int.MinValue;
            double med;

            n = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                v[i] = Int32.Parse(Console.ReadLine());
                s = s + v[i];
                if (v[i] % 2 == 0) nrp++;
                if (v[i] < mn) mn = v[i];
                if (v[i] > mx) mx = v[i];
            }
            double sum = Convert.ToDouble(s);
            double nr = Convert.ToDouble(n);
            med = sum / nr;

            Console.WriteLine("Suma= " + s);
            Console.WriteLine("Media= " + med);
            Console.WriteLine("Nr pare= " + nrp);
            Console.WriteLine("Minim= " + mn);
            Console.WriteLine("Maxim= " + mx);

        }
    }
}