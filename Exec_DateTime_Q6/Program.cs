using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DateTime_Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			Console.WriteLine("日期:" + today.ToString("yyyy/MM/dd"));

			int day = today.Day;
			if (day <= 10)
				Console.WriteLine("是本月的上旬");
			else if (day <=20)
				Console.WriteLine("是本月的中旬");
			else
				Console.WriteLine("是本月的下旬");
		}
	}
}
