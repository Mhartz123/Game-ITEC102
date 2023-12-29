/*
 * Created by
*  SharpDevelop.
 * User: tolen
 * Date: 11/30/2023
 * Time: 9:19 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace game2._
{
	/// <summary>
	/// Description of Enemy.
	/// </summary>
	public class Enemy
	{
		public static string Enemy_Name { get; set; }
		public static double Enemy_HP { get; set; }
		public static double Enemy_atk { get; set; }
		public static double Enemy_Agility { get; set; }
		public static string Enemy_Art { get; set; }
		public static string Enemy_Atk_Animation { get; set;}
		
//		1ST FLOOR ENEMIES
		public static void goblin()
		{	
		    Enemy_Name = "Goblin";
		    Enemy_Art = Art.goblin();
		    
			Enemy_HP = 50;
			Enemy_atk = 8;
			Enemy_Agility = 25;	
			Data.Experience_Points = 50;
		}
		
		public static void Kobold()
		{
		 	Enemy_Name = "Kobold";
		 	Enemy_Art = Art.kobold();
			Enemy_HP = 150;
			Enemy_atk = 15;
			Enemy_Agility = 50;	
			Data.Experience_Points = 100;
		}
		
		public static void Shaman()
		{
		 	Enemy_Name = "Goblin Shaman";
		 	Enemy_Art = Art.goblin_shaman();
			Enemy_HP = 30;
			Enemy_atk = 20;
			Enemy_Agility = Data.Agility - 1;
			Data.Experience_Points = 150;
		}
		
		public static void Orc()
		{
		 	Enemy_Name = "Orc";
		 	Enemy_Art = Art.orc();
			Enemy_HP = 200;
			Enemy_atk = 24;
			Enemy_Agility = 55;
		 	Data.Experience_Points = 200;			
		}
		
		public static void Treant() // BOSS
		{
			Enemy_Name = "Treant";
			Enemy_Art = Art.boss_treant();
			Enemy_HP = 300;
			Enemy_atk = 30;
			Enemy_Agility = Data.Agility -1;
		 	Data.Experience_Points = 0;	
		}
		
//		2ND FLOOR ENEMIES
		public static void Swarm_of_Rats()
		{
			Enemy_Name = "Swarm of Rats";
			Enemy_Art = Art.swarm_of_rats();
			Enemy_HP = 160;
			Enemy_atk = 12;
			Enemy_Agility = Data.Agility +1;
		 	Data.Experience_Points = 0;	
		}
		
		public static void Pack_of_Wolves()
		{
			Enemy_Name = "Pack of Wolves";
			Enemy_Art = Art.pack_of_wolves();
			Enemy_HP = 210;
			Enemy_atk = 20;
			Enemy_Agility = Data.Agility +1;
		 	Data.Experience_Points = 0;	
		}
		
		public static void Rabid_Wolf()
		{
			Enemy_Name = "Rabid Wolf";
			Enemy_Art = Art.rabid_wolf();
			Enemy_HP = 250;
			Enemy_atk = 26;
			Enemy_Agility = Data.Agility -2;
		 	Data.Experience_Points = 0;	
		}
		
		public static void Werewolf()
		{
			Enemy_Name = "Werewolf";
			Enemy_Art = Art.Werewolf();
			Enemy_HP = 320;
			Enemy_atk = 34;
			Enemy_Agility = Data.Agility -1;
		 	Data.Experience_Points = 0;	
		}
		
		public static void Wyvern() // BOSS
		{
			Enemy_Name = "Wyvern";
			Enemy_Art = Art.boss_wyvern();
			Enemy_HP = 400;
			Enemy_atk = 38;
			Enemy_Agility = Data.Agility -1;
		 	Data.Experience_Points = 0;	
		}
		
//		FINAL BATTLE
		//here
	}
}
