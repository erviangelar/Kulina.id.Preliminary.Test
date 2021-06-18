using System;

namespace PreliminaryTest.Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Total Sock :");
			int n = Convert.ToInt32(Console.ReadLine());
			int[] socks = new int[n];
			int x = 0;
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine("Color :");
				socks[i] = Convert.ToInt32(Console.ReadLine());
				if (socks[i] < 1 || socks[i] > 100)
				{
					Console.WriteLine("Color Must Greater than 1 and less than 100 :");
					socks[i] = Convert.ToInt32(Console.ReadLine());
				}
			}
			for (int i = 0; i < n; i++)
			{
				for (int j = (i + 1); j < n; j++)
				{
					//Console.WriteLine(socks[i] + "," +socks[j]);
					if (socks[i] == 0)
					{
						break;
					}
					if (socks[i] == socks[j])
					{
						socks[j] = 0;
						x++;
						break;
					}
				}
			}
			Console.WriteLine("Total Pair: " + x);

		}
	}
}
