using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DateTime_Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime now = DateTime.Now;
			Console.WriteLine("時間:" + now.ToString("yyyy/MM/dd"));

			int time = now.Hour;
			if (time <= 11)
				Console.WriteLine("早安!!!");
			else if (time <= 18)
				Console.WriteLine("午安!!!");
			else
				Console.WriteLine("晚安!!!");
		}
	}
}
