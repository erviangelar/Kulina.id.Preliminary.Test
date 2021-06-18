using System;

namespace PreliminaryTest.Algorithm4
{
    class Program
    {
        static void Main(string[] args)
        {
			int total = 0;
			int ar = 100;
			int[] lamps = new int[ar];
			for (int i = 1; i <= ar; i++)
			{
				for (int j = i; j <= ar; j++)
				{
					//Console.WriteLine("Cek : " + i +" : "+ j);
					if ((j % i) == 0)
					{
						if (lamps[j - 1] == 0)
						{
							lamps[j - 1] = 1;
						}
						else if (lamps[j - 1] == 1)
						{
							lamps[j - 1] = 0;
						}
					}
					//Console.WriteLine("Lamp : " + j + " : "+ i +" : "+ String.Join(",",lamps));
				}
			}
			foreach (int i in lamps)
			{
				if (i == 1)
				{
					total++;
				}
			}

			Console.WriteLine("Total Lamp On : " + total);

		}
	}
}
