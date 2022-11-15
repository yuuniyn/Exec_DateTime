using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DateTime_Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			Console.WriteLine("日期:" + today.ToString("yyyy/MM/dd"));

			DateTime nextMonthDate = today.AddMonths(1);
			int nextMonth = nextMonthDate.Month;
			DateTime firstDayOfNextMonth = new DateTime(today.Year, nextMonth, 1);
			DateTime lastDayOfMonth = firstDayOfNextMonth.AddDays(-1);
			Console.WriteLine($"本月的最後一天為 {lastDayOfMonth: yyyy/MM/dd}");
		}
	}
}
