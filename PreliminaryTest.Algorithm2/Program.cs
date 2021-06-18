using System;

namespace PreliminaryTest.Algorithm2
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Total Step :");
			int n = Convert.ToInt32(Console.ReadLine());
            while (n < 2)
            {
				Console.WriteLine("Step must greater than 2 :");
				n = Convert.ToInt32(Console.ReadLine());
			}
			string[] path = new string[n];
			int x = 0, y = 0;
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine("Path :");
				path[i] = Console.ReadLine();
				if (path[i] != "U" && path[i] != "D")
				{
					Console.WriteLine("Path must input with U or D :");
					path[i] = Console.ReadLine();
				}
			}
			for (int i = 0; i < n; i++)
			{
				if (path[i] == "U")
				{
					x++;
				}
				if (path[i] == "D")
				{
					x--;
				}
				if (x == 0 && path[i] == "U")
				{
					y++;
				}
			}
			Console.WriteLine("Total Valleys: " + y);

		}
	}
}
