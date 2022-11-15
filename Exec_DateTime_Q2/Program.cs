using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DateTime_Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			Console.WriteLine("日期:" + today.ToString("yyyy/MM/dd"));

			DateTime nextMonth = today.AddMonths(1);
			Console.WriteLine($"下個月應歸還時間為 {nextMonth:yyyy/MM/dd}");
		}
	}
}
