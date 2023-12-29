
using System;
using System.Threading;

namespace game2._
{
	/// <summary>
	/// Description of Condition.
	/// </summary>
	public class Condition
	{
		public static void playername(string a)
		{
			if(a == "y" || a == "Y"){
				Console.Clear();
				Introduction.Start();
			}else{
				Console.Clear();
				Introduction.IntroductionAgain();
			}
		}
		
		public static void basestats(){
			if(Data.Base_Points > 0){
				Console.WriteLine("Need to allocate all stat points");
				Thread.Sleep(2000);
				Console.Clear();
				Introduction.Start();
			}
		}
		
		public static void finished(string a)
		{	
			if(a == "y" || a == "Y"){
				Console.WriteLine("Take this potions with you, I hope they serve you nicely in your journey");
				Data.potions += 5;
				Thread.Sleep(2000);
				Console.Clear();
			}else{
				Console.Clear();
				Introduction.Introduction2();
			}
			
		}
		
		
		private static void first_floor_enemies(){

			Random rnd = new Random();
			int RNG = rnd.Next(1,5);
			
			if(RNG == 1){
				Enemy.goblin();
				Encounter.agility_check();
			}else if(RNG == 2){
				Enemy.Kobold();
				Encounter.agility_check();
			}else if(RNG == 3){
				Enemy.Shaman();
				Encounter.agility_check();
			}else if(RNG == 4){
				Enemy.Orc();
				Encounter.agility_check();
			}
		}
		
		private static void second_floor_enemies(){

			Random rnd = new Random();
			int RNG = rnd.Next(1,5);
			
			if(RNG == 1){
				Enemy.Swarm_of_Rats();
				Encounter.agility_check();
			}else if(RNG == 2){
				Enemy.Pack_of_Wolves();
				Encounter.agility_check();
			}else if(RNG == 3){
				Enemy.Rabid_Wolf();
				Encounter.agility_check();
			}else if(RNG == 4){
				Enemy.Werewolf();
				Encounter.agility_check();
			}
		}
		
		
		
		
		public static void retrying(){
		if(UserInput.retry == "Y" || UserInput.retry == "y"){
		Introduction.Introduction1();
		}else{
			Console.WriteLine("You died");
			Console.WriteLine("Press any key to exit the console");
			Console.ReadKey();
			
			}
		}
			
		public static void first_floor_rng(){
			for(int i = 0; i < 5; i++)
			{
				if(i < 5) {
					first_floor_enemies();
					
				} else {
					Enemy.Treant();
					Encounter.agility_check();
				}
			}
		}
		
		public static void second_floor_rng() {
			for(int i = 0; i < 5; i++)
			{
				if(i < 5) {
					second_floor_enemies();
					for(int j = 0; j < 3; j++){
						
					}
				} else {
					Enemy.Wyvern();
					Encounter.agility_check();
				}
			}
		}
		
		}
	}
