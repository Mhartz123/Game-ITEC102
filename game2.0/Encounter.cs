
using System;
using System.Threading;

namespace game2._
{
	/// <summary>
	/// Description of Encounter.
	/// </summary>
	public class Encounter
	{
		public static int protection {get; set;}
		
		
//		public static void enemy() {
//			Console.WriteLine(Enemy.Enemy_Name + " : " + Enemy.Enemy_HP);
//			Console.Write("HP: " + Data.Base_HP);
//			Console.Write("       MP: " + Data.MP);
//			Console.Write("              Potions: " + Data.potions);
//			Console.Write("                     Strength: " + Data.Strength);
//			Console.Write("                            Magic: " + Data.Magic);
//			Console.WriteLine("\nWhat will you do");
//			string prompt = "choose";
//			buttons(prompt);
//		}
//
//		
//	    public static void buttons(string text)
//		{
//	    	
//			string[] options = {"1: Attack", "2: Magic","3: Heal","4: Defend"};
//			Menu mainMenu = new Menu(text, options);
//			
//			int selectedIndex = mainMenu.Run();
//			
//			switch(selectedIndex)
//			{
//				case 0:
//					swing();
//					break;
//				case 1:
//					magic();
//					break;
//				case 2:
//					healing();
//					break;
//				case 3:
//					defend();
//					break;
//		   }
//	    }
		
//			
//		
		// dito yung extra encounters 
		public void extra_encounters(){
			Console.Clear();
			Console.WriteLine("================================================================");
			Console.WriteLine("|                                                              |");
		  	Console.WriteLine("================================================================");
			Console.Write("HP: " + Data.Base_HP);
			Console.Write("       MP: " + Data.MP);
			Console.Write("              Potions: " + Data.potions);
			Console.Write("                     Strength: " + Data.Strength);
			Console.Write("                            Magic: " + Data.Magic);
			Console.WriteLine("\nWhat will you do");
			Console.WriteLine("1: Walk");
			Console.WriteLine("2: Rest"); 
			int player_choice = Convert.ToInt32(Console.ReadLine());
			
			switch(player_choice){
				case 1:
					Walk();
					break;
				case 2: 
					Rest();
					break;
			}
		}
		
		// choice 
		public void Walk()
		{
			Random rnd = new Random();
			int num = rnd.Next(0, 3); // 33.3% walk in peace or encounter
			
			if(num == 0) {
				Console.Clear();
				Console.WriteLine("================================================================");
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|                      You walked in peace.                    |");
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|                                                              |");
		  		Console.WriteLine("================================================================");
				Console.Write("HP: " + Data.Base_HP);
				Console.Write("       MP: " + Data.MP);
				Console.Write("              Potions: " + Data.potions);
				Console.Write("                     Strength: " + Data.Strength);
				Console.Write("                            Magic: " + Data.Magic);
				// dunno
			} else {
				Console.Clear();
				Different_Options();
//				Program.Next();
			}
		}
		
		public void Rest()
		{
			Random rnd = new Random();
			int num = rnd.Next(0, 2); // 50|50 rest in peace or encounter
			
			if(num == 0) {
				Console.Clear();
				Console.WriteLine("================================================================");
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|                      You walked in peace.                    |");
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|                                                              |");
		  		Console.WriteLine("================================================================");
				Console.Write("HP: " + Data.Base_HP);
				Console.Write("       MP: " + Data.MP);
				Console.Write("              Potions: " + Data.potions);
				Console.Write("                     Strength: " + Data.Strength);
				Console.Write("                            Magic: " + Data.Magic);
				//dunno
			} else {
				Console.Clear();
				Different_Options();
				Program.Next();
			}
		}
		
		// different encounters
		public void Different_Options()
		{
			Random rnd = new Random();
			int num = rnd.Next(0, 5);
			// 20% for a certain event to occur 
			if(num == 0) {
				Pitfall();
			} else if(num == 1) {
				Chest_Mimic();
			} else if(num == 2) {
				Arrow_Trap();
			} else if(num == 3) {
				Fire_Trap();
			} else if(num == 4) {
				Unkown_Fruit();
			}
		}
		
		public void Pitfall()
		{
			Loading();
			Console.Clear();
			Console.WriteLine("<<PITFALL>>");
			
			Thread.Sleep(2000);
			string a = "You're quick and didn't fell into the abyss.";
			string b = "You fell bro.";
			
			Random rnd = new Random();
			int num = rnd.Next(0, 3); // 33.3% chance to survive
			
			if(num == 0) {
				Console.WriteLine(a);
			} else {
				Console.WriteLine(b);
			}
		}
		
		public void Chest_Mimic()
		{
			Loading();
			Console.Clear();
			Console.WriteLine("<<CHEST>>");
			Thread.Sleep(2000);
			string a = "the chest is full of riches";
			string b = "the chest is a mimic, prepare for a fight";
			
			Random rnd = new Random();
			int num = rnd.Next(0, 2); // 50|50 chest or mimic
			
			if(num == 0) {
				Console.Clear();
				Console.WriteLine("================================================================");
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|                  The chest is full of riches.                |");
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|                                                              |");
		  		Console.WriteLine("================================================================");
				Console.Write("HP: " + Data.Base_HP);
				Console.Write("       MP: " + Data.MP);
				Console.Write("              Potions: " + Data.potions);
				Console.Write("                     Strength: " + Data.Strength);
				Console.Write("                            Magic: " + Data.Magic);
				//dunno
			} else {
				Console.Clear();
				Console.WriteLine("================================================================");
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|      The chest is a mimic and you suffered some injury.      |");
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|                                                              |");
		  		Console.WriteLine("================================================================");
				Console.Write("HP: " + Data.Base_HP);
				Console.Write("       MP: " + Data.MP);
				Console.Write("              Potions: " + Data.potions);
				Console.Write("                     Strength: " + Data.Strength);
				Console.Write("                            Magic: " + Data.Magic);
				//dunno
			}
		}
		
		public void Arrow_Trap()
		{
			Loading();
			Console.Clear();
			Console.WriteLine("<<ARROW TRAP>>");
			Thread.Sleep(2000);
			string a = "you dodged the arrow";
			string b = "you got hit by the arrow";
			
			Random rnd = new Random();
			int num = rnd.Next(0, 3); // 33.3% chance to dodge 
			
			if(num == 0) {
				Console.Clear();
				Console.WriteLine("================================================================");
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|                     You dodged the arrow.                    |");
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|                                                              |");
		  		Console.WriteLine("================================================================");
				Console.Write("HP: " + Data.Base_HP);
				Console.Write("       MP: " + Data.MP);
				Console.Write("              Potions: " + Data.potions);
				Console.Write("                     Strength: " + Data.Strength);
				Console.Write("                            Magic: " + Data.Magic);
				//dunno
			} else {
				Console.Clear();
				Console.WriteLine("================================================================");
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|                   You got hit by the arrow.                  |");
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|                                                              |");
		  		Console.WriteLine("================================================================");
				Console.Write("HP: " + Data.Base_HP);
				Console.Write("       MP: " + Data.MP);
				Console.Write("              Potions: " + Data.potions);
				Console.Write("                     Strength: " + Data.Strength);
				Console.Write("                            Magic: " + Data.Magic);
				//dunno
			} 
		}
		
		public void Fire_Trap()
		{
			Loading();
			Console.Clear();
			Console.WriteLine("<<FIRE TRAP>>");
			Thread.Sleep(2000);
			string a = "you rolled away quickly from the fire trap";
			string b = "you're so slow you got burns from the fire trap";
			
			Random rnd = new Random();
			int num = rnd.Next(0, 3); // 33.3% chance to dodge 
			
			if(num == 0) {
				Console.Clear();
				Console.WriteLine("================================================================");
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|          You rolled away quickly from the fire trap.         |");
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|                                                              |");
		  		Console.WriteLine("================================================================");
				Console.Write("HP: " + Data.Base_HP);
				Console.Write("       MP: " + Data.MP);
				Console.Write("              Potions: " + Data.potions);
				Console.Write("                     Strength: " + Data.Strength);
				Console.Write("                            Magic: " + Data.Magic);
				//dunno
			} else {
				Console.Clear();
				Console.WriteLine("================================================================");
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|       You're so slow you got burns from the fire trap.       |");
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|                                                              |");
		  		Console.WriteLine("================================================================");
				Console.Write("HP: " + Data.Base_HP);
				Console.Write("       MP: " + Data.MP);
				Console.Write("              Potions: " + Data.potions);
				Console.Write("                     Strength: " + Data.Strength);
				Console.Write("                            Magic: " + Data.Magic);
				//dunno
			} 
		}
		
		public void Unkown_Fruit()
		{
			Loading();
			Console.Clear();
			Console.WriteLine("<<UNKOWN FRUIT>>");
			Thread.Sleep(2000);
			string a = "lucky bastard, you got an extra potion";
			string b = "the unkown fruit is a poison";
			
			Random rnd = new Random();
			int num = rnd.Next(0, 2); // 50|50 extra potion or damage
			
			if(num == 0) {
				Console.Clear();
				Console.WriteLine("================================================================");
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|             Lucky bastard, you got an extra potion.          |");
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|                                                              |");
		  		Console.WriteLine("================================================================");
				Console.Write("HP: " + Data.Base_HP);
				Console.Write("       MP: " + Data.MP);
				Console.Write("              Potions: " + Data.potions);
				Console.Write("                     Strength: " + Data.Strength);
				Console.Write("                            Magic: " + Data.Magic);
				//dunno
			} else {
				Console.Clear();
				Console.WriteLine("================================================================");
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|      The chest is a mimic and you suffered some injury.      |");
				Console.WriteLine("|                                                              |");                  
				Console.WriteLine("|                                                              |");
		  		Console.WriteLine("================================================================");
				Console.Write("HP: " + Data.Base_HP);
				Console.Write("       MP: " + Data.MP);
				Console.Write("              Potions: " + Data.potions);
				Console.Write("                     Strength: " + Data.Strength);
				Console.Write("                            Magic: " + Data.Magic);
				//dunno
			} 
		}		
		
		
		// fight with enemy 
		public static void agility_check(){
			if(Data.Agility > Enemy.Enemy_Agility){
			choice();
			}else{
			battle_phase();
			}
		}
		
		
			public static void battle_phase() {
			Console.WriteLine(Enemy.Enemy_Name + " attacks");
			Thread.Sleep(1000);
			
			if(Enemy.Enemy_Name == "Goblin") {
				Animation.goblin_atk();
			} else if(Enemy.Enemy_Name == "Kobold") {
				Animation.kobold_atk();
			} else if(Enemy.Enemy_Name == "Goblin Shaman") {
				Animation.goblin_shaman_atk();
			} else if(Enemy.Enemy_Name == "Orc") {
				Animation.orc_atk();
			}
			
			Console.WriteLine("It dealt: " + Enemy.Enemy_atk);
			Data.Base_HP -= Enemy.Enemy_atk;
			player_stat_checker();
			Console.Clear();
			Thread.Sleep(1000);
			choice();
			}
			
		
		
			public static void choice() {
			Console.WriteLine(Enemy.Enemy_Name + " : " + Enemy.Enemy_HP);
			Console.WriteLine("================================================================");
		  	Console.Write(Enemy.Enemy_Art);
		  	Console.WriteLine("\n================================================================");
			Console.Write("HP: " + Data.Base_HP);
			Console.Write("       MP: " + Data.MP);
			Console.Write("              Potions: " + Data.potions);
			Console.Write("                     Strength: " + Data.Strength);
			Console.Write("                            Magic: " + Data.Magic);
			Console.WriteLine("\nWhat will you do");
			Console.WriteLine("1: Attack");
			Console.WriteLine("2: Magic");  
			Console.WriteLine("3: Heal");
			Console.WriteLine("4: Defend");
			Console.WriteLine("\nYour action");
			Console.Write(">> ");
			int choice_battle = Convert.ToInt32(Console.ReadLine());
			
			switch(choice_battle){
				case 1:
					swing();
					break;
				case 2:
					magic();
					break;
				case 3:
					healing();
					break;
				case 4:
					defend();
					break;
			}
		}
		
		
		public static void swing(){
			Enemy.Enemy_HP -= Data.Strength;
			enemy_stat_checker();
			Console.WriteLine("You have dealt " + Data.Strength);
			Console.WriteLine(Enemy.Enemy_Name + " : " + Enemy.Enemy_HP);
			Thread.Sleep(2000);
			Console.Clear();
			check();
			
		}
		
		public static void magic(){
			Console.WriteLine("What Magic: ");
			Console.WriteLine("1. Fireball 10 MP");
			Console.WriteLine("2. Ice Barrier 15 MP");
			Console.WriteLine("3. Heal 20 MP");
			Console.WriteLine("\nYour action");
			Console.Write(">> ");
			string magic_choice = Console.ReadLine();
			if(magic_choice == "1" && Data.MP >= 10){
				Enemy.Enemy_HP -= Data.Magic;
				enemy_stat_checker();
				Console.WriteLine("You have dealt: " + Data.Magic);
				Data.MP -= 10;
				Thread.Sleep(2000);
				Console.Clear();
				check();
			}else if (magic_choice == "1" && Data.MP <= 10){
				Console.WriteLine("You don't have any enough mana");
				Thread.Sleep(2000);
				Console.Clear();
				choice();
			}else if(magic_choice == "2" && Data.MP >= 15){
				Console.WriteLine("You have gained protection");
				protection += 1;
				Console.WriteLine("Enemy " + Enemy.Enemy_Name + " Attacks");
				Console.WriteLine("Barrier blocked your damage");
				Data.MP -= 15;
				protection--;
				Thread.Sleep(2000);
				Console.Clear();
				choice();
			}else if (magic_choice == "2" && Data.MP <= 15){
				Console.WriteLine("You don't have any enough mana");
				Thread.Sleep(2000);
				Console.Clear();
				choice();
			}else if(magic_choice == "3" && Data.MP >= 20){
				Console.WriteLine("You healed yourself");
				if(Data.Base_HP > Data.Endurance){
					Data.Base_HP = Data.Endurance;
					Console.WriteLine("Player: " + Data.Base_HP);
					choice();
				}else if(Data.Base_HP == Data.Endurance){
					Console.WriteLine("You are at max HP");
					Console.Clear();
					choice();
				}else{
					Data.Base_HP += 40;
					Console.WriteLine("Player: " + Data.Base_HP);
					Data.MP -= 20;
					Thread.Sleep(2000);
					Console.Clear();
					choice();
				}
			}else if (magic_choice == "3" && Data.MP <= 20){
					Console.WriteLine("You don't have any enough mana");
					Thread.Sleep(2000);
					Console.Clear();
					choice();	
			}
		}
		
		public static void healing(){
			if(Data.potions <= 0){
				Console.WriteLine("You don't have any potions on you");
				choice();
			}else{
				if(Data.Base_HP > Data.Endurance){
					Data.Base_HP = Data.Endurance;
					Console.WriteLine("You healed yourself");
					Console.WriteLine("Player: " + Data.Base_HP);
					Thread.Sleep(2000);
					Console.Clear();
					choice();
				}else if(Data.Base_HP == Data.Endurance){
					Console.WriteLine("You are at max HP");
					Thread.Sleep(2000);
					Console.Clear();
					choice();
				}else{
					Data.Base_HP += 10;
					Console.WriteLine("Player: " + Data.Base_HP);
					Data.MP -= 20;
					Thread.Sleep(2000);
					Console.Clear();
					choice();
				}
			}
		}
		
		public static void defend(){
			Data.Base_HP -= (Enemy.Enemy_atk / 2);
			Console.WriteLine(Enemy.Enemy_Name + " has dealt: " + Enemy.Enemy_atk);
			Console.WriteLine("Player: " + Data.Base_HP);
			if(Data.Base_HP <= 0){
				Console.WriteLine("You lost");
				Console.WriteLine("Would you like to try again?");
				UserInput.Retry();
			}else{
				Thread.Sleep(2000);
				Console.Clear();
				choice();
			}
		}
		
		public static void enemy_stat_checker()
		{
			if(Enemy.Enemy_HP <= 0) {
				Enemy.Enemy_HP = 0;
			}
		}
		
		public static void player_stat_checker()
		{
			if(Data.Base_HP <= 0) {
				Data.Base_HP = 0;
			}
		}
		
		
		public static void check(){
			if(Enemy.Enemy_HP <= 0){
				Console.WriteLine("Congratulations you have won");
				Console.WriteLine("Press any key to continue");
				Console.ReadKey(true);
				Console.Clear();
				Condition.first_floor_rng();
			}else if(Data.Base_HP <= 0){
				Console.WriteLine("You lost"); 
				Console.WriteLine("Would you like to try again?");
				UserInput.Retry();
			}else{
				Console.Clear();
				battle_phase();
			}
		}
	}
}
		
		
		
		
		
		
		
		
		
		
		
		
	