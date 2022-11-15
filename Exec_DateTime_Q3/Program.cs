using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DateTime_Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			Console.WriteLine("日期:" + today.ToString("yyyy/MM/dd"));

			DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
			Console.WriteLine($"本月的第一日為 {firstDayOfMonth: yyyy/MM/dd}");
		}
	}
}
