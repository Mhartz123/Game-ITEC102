/*
 * Created by SharpDevelop.
 * User: tolen
 * Date: 11/30/2023
 * Time: 7:16 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading;

namespace game2._
{
	/// <summary>
	/// Description of Data.
	/// </summary>
	public class Data
	{
		public static string Name {get; set;}
		public static double Strength {get; set;}
		public static double Endurance {get; set;}
		public static double Base_HP {get; set;}
		public static double Magic {get; set;}
		public static double MP {get; set;}
		public static double Agility {get; set;}
		public static int Experience_Points {get; set;}
		public static int Experience_cap {get; set;}
		public static int Base_Points {get; set;}
		public static int potions {get; set;}
		
		public static void Statement()
		{			
			Console.WriteLine("You have " + Base_Points + " left");
			Console.Write("How many points will you allocate for ");
		}
		
		public static void Strength_stat()
		{   
			Statement(); Console.Write("[Strength]  : ");
			Strength = 3; //base (pagpalagay lang na ito yung base)
			
			UserInput.Double_Input = Convert.ToInt32(Console.ReadLine());
			if(UserInput.Double_Input > Base_Points){
				Console.WriteLine("You don't have any points allocate please try again");
				Thread.Sleep(2000);
				Console.Clear();
				Introduction.Start();
			}
			Strength *= UserInput.Double_Input;
			Base_Points -= UserInput.Double_Input;
			while(!(UserInput.Double_Input >= 0 && UserInput.Double_Input <= 50))
			{
				Strength_stat();
			}
		}
		
		public static void Endurance_stat()
		{
			Statement(); Console.Write("[Endurance] : ");
			Endurance = 10; //base (pagpalagay lang na ito yung base)
			UserInput.Double_Input = Convert.ToInt32(Console.ReadLine());
			if(UserInput.Double_Input > Base_Points){
				Console.WriteLine("You don't have any points allocate please try again");
				Thread.Sleep(2000);
				Console.Clear();
				Introduction.Start();
			}
			Endurance *= UserInput.Double_Input;
			Base_HP = Endurance;
			Base_Points -= UserInput.Double_Input;
			while(!(UserInput.Double_Input >= 0 && UserInput.Double_Input <= 50))
			{
				Endurance_stat();
			}
		}
		
		public static void Magic_stat()
		{
			Statement(); Console.Write("[Magic]     : ");
			Magic = 2; //base (pagpalagay lang na ito yung base)
			MP = 5;
		
			
			UserInput.Double_Input = int.Parse((Console.ReadLine()));
			if(UserInput.Double_Input > Base_Points){
				Console.WriteLine("You don't have any points allocate please try again");
				Thread.Sleep(2000);
				Console.Clear();
				Introduction.Start();
			}
			Magic *= UserInput.Double_Input;
			MP  *= Magic;
			Base_Points -= UserInput.Double_Input;
			while(!(UserInput.Double_Input >= 0 && UserInput.Double_Input <= 50))
			{
				Magic_stat();
			}
		}
		
		public static void Agility_stat()
		{
		    Statement(); Console.Write("[Agility]   : ");
			Agility = 5; //base (pagpalagay lang na ito yung base)
			UserInput.Double_Input = Convert.ToInt32(Console.ReadLine());
			if(UserInput.Double_Input > Base_Points){
				Console.WriteLine("You don't have any points allocate please try again");
				Thread.Sleep(2000);
				Console.Clear();
				Introduction.Start();
			}
			Agility *= UserInput.Double_Input;
			Base_Points -= UserInput.Double_Input;
			while(!(UserInput.Double_Input >= 0 && UserInput.Double_Input <= 50))
			{
				Agility_stat();
			}
			Introduction.CurrentStats();
		}
	}
}
