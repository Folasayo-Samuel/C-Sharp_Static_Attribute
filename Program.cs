// See https://aka.ms/new-console-template for more information
using System;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication
{
	class Songs
	{
		static void Main(string[]args)
		{
			Song holiday = new Song("Holiday", "Green Day", 200);
		Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
		
		Console.WriteLine(holiday.title);
		Console.WriteLine(holiday.artist);
		
		Console.ReadLine();
		}
	}
}
