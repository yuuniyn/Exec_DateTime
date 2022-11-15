using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DateTime_Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			Console.WriteLine("日期:" + today.ToString("yyyy/MM/dd"));

			DateTime afterThreeDays = today.AddDays(3);
			Console.WriteLine("三天後DVD應歸還時間" + afterThreeDays.ToString("yyyy/MM/dd"));
		}
	}
}
