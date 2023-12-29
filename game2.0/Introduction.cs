
using System;
using System.Threading;

namespace game2._
{

	public class Introduction
		{
		public static int Double_Input { get; set; }
	    public static string Input {get; set;}
		public static string retry {get; set;}
		
		public static void Introduction1()
		{	
			Console.WriteLine("Why does everything feels so familiar");
			Console.WriteLine("Welcome Weary Traveller to the unknown lands");
			Console.WriteLine("May I know your name?");
			Console.Write(">> ");
			UserInput.Name();
		}
		
		public static void Introduction2()
		{
			Console.WriteLine("Is this your name?: " + Data.Name);
			Console.WriteLine("Y or N");
			Console.Write(">> ");
			string player_name = Console.ReadLine();
			Condition.playername(player_name);
		}
		
		public static void Name()
		{
			Data.Name = Console.ReadLine();
			Console.WriteLine("Well is that so, hm well I honestly could have picked a better name");
			Console.WriteLine("Time to allocate points into your stats");
			Console.WriteLine("You get more skill points as you venture on.\n");
			Introduction2();
		}
		
		public static void IntroductionAgain()
		{
			Console.WriteLine("What's your name then?");
			UserInput.Name();
		}
		
		public static void Start()
		{
			Console.WriteLine("The skill points are: ");
			Console.WriteLine("[Strength] for more damage."); //DMG
     		Console.WriteLine("[Endurance] for more health points."); //HP
      		Console.WriteLine("[Magic] for more mana points and magic damage."); //MP
      		Console.WriteLine("[MP] is a stat that you gain depending on your [Magic], the more points you put into magic, the more Mana Points you get");
      		Console.WriteLine("This allows you to cast magic at the cost of MP, without MP you can't cast a magic Ability");
      		Console.WriteLine("[Agility] for a better chance of striking first.\n"); //AGI
      		Console.WriteLine("NOW CHOOSE");
      		Data.Base_Points = 50;
      		Console.WriteLine("Minimum of (1) and Maximum of (50).");
      		Console.WriteLine("TIP: It would be better to distribute the stats fairly depending on what you what");
      		
      		
      		Data.Strength_stat();
      		Data.Endurance_stat();
      		Data.Magic_stat();
      		Data.Agility_stat();
      		
		}
		
		
		
		public static void CurrentStats()
		{
			Condition.basestats();
			Console.WriteLine("\nCURRENT STATS");
			Console.WriteLine("Strength   : " + Data.Strength);
			Console.WriteLine("Endurance  : " + Data.Endurance);
			Console.WriteLine("Magic     : " +  Data.Magic);
			Console.WriteLine("Agility    : " +  Data.Agility);
			
			Console.WriteLine("Are you happy with your stats? " + Data.Name);
			Console.WriteLine("Y or N");
			Console.Write(">> ");
			string finishing = Console.ReadLine();
			Condition.finished(finishing);
			Condition.first_floor_rng();
//			Condition.second_floor_rng();
		}
		
		
		}
	  }
	

