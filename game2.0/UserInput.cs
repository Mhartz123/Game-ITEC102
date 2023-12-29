
using System;

namespace game2._
{
	/// <summary>
	/// Description of UserInput.
	/// </summary>
	public class UserInput
	{
		public static int Double_Input { get; set; }
		public static string retry {get; set;}
		
		public static void Name()
		{
			Data.Name = Console.ReadLine();
			Console.WriteLine("Well is that so, hm well I honestly could have picked a better name");
			Console.WriteLine("Time to allocate points into your stats");
			Console.WriteLine("You get more skill points as you venture on.\n");
			Introduction.Introduction2();
		}
		
		public static void Retry()
		{
		   retry = Console.ReadLine();
		}
	}
}
