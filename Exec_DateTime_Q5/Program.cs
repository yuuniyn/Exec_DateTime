using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DateTime_Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入年份: ");
			string value = Console.ReadLine();
			int year = Convert.ToInt32(value);

			if (year >= 0)
			{
				DateTime firstDate = new DateTime(year, 1, 1);
				DayOfWeek weekOfFirstDate = firstDate.DayOfWeek;

				DateTime targetDate;
				switch (weekOfFirstDate)
				{
					case DayOfWeek.Monday:
						targetDate = firstDate.AddDays(6);
						break;
					case DayOfWeek.Tuesday:
						targetDate = firstDate.AddDays(5);
						break;
					case DayOfWeek.Wednesday:
						targetDate = firstDate.AddDays(4);
						break;
					case DayOfWeek.Thursday:
						targetDate = firstDate.AddDays(3);
						break;
					case DayOfWeek.Friday:
						targetDate = firstDate.AddDays(2);
						break;
					case DayOfWeek.Saturday:
						targetDate = firstDate.AddDays(1);
						break;
					default:
						targetDate = firstDate;
						break;
				}

				int nextYear = targetDate.AddYears(1).Year;
				while (targetDate.Year < nextYear)
				{
					Console.WriteLine($"{targetDate: yyyy/MM/dd} 是 {targetDate.DayOfWeek}");
					targetDate = targetDate.AddDays(7);
				}
			}
			else
				Console.WriteLine("錯誤!!");

		}
	}
}
