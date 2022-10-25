using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			for (int i = 1; i <= 5; i++)
			{
				int zero = 5 - i;
				int star = i * 2 - 1;
				string row = new string(' ', zero) + new string('*', star);
				Console.WriteLine(row);
			}
		}
	}
}
