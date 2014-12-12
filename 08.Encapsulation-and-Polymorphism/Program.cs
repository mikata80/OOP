using System;
using System.Collections;
using System.Collections.Generic;
using TheSlum.GameEngine;

namespace TheSlum
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            string[] arrCommands = {"create mage Nakov 3 4 Red",
                    "add Nakov axe Axe ",
                    "add Nakov pill IronPill",
                    "add Nakov injection AnalInjection",
                    "create warrior Vlado 5 4 Blue",
                    "add Vlado shield HeavyShield",
                    "create healer Alex 7 8 Red",
                    "create warrior BateArni 2 3 Blue",
                    "add BateArni axe TurboMegaAxe",
                    "add BateArni shield TurtleShield",
                    };
            //IList<string> createClasses = new List<string>();
            IList<Character> characters = new List<Character>();
            IList<Mage> mages = new List<Mage>();
            IList<Warrior> warriors = new List<Warrior>();
            IList<Healer> healers = new List<Healer>();
            
            //Dictionary<string, string> createClasses = new Dictionary<string, string>();
            IList<string> createItems = new List<string>();

            foreach (var c in arrCommands)
            {
                if (c.StartsWith("create"))
                {
                    string[] arr = c.Split(' ');
                    string className = arr[1];
                    string id = arr[2];
                    int x = Int32.Parse(arr[3]);
                    int y = Int32.Parse(arr[4]);
                    string strTeam = arr[5];
                    Team team;
                    if (strTeam.ToLower() == "red" )
                    {
                        team = Team.Red;
                    }
                    else
                    {
                        team = Team.Blue;
                    }
                    
                    if (className.ToLower() == "mage")
                    {

                        characters.Add(new Mage(id, x, y, team));
                    }
                    else if (className.ToLower() == "warrior")
                    {
                        characters.Add(new Warrior(id, x, y, team));
                    }
                    else if (className.ToLower() == "healer")
                    {
                        characters.Add(new Healer(id, x, y, team));
                    }
                    
                    //createClasses.Add("ClassName",arr[1]);
                    //createClasses.Add("id",arr[2]);
                    //createClasses.Add("x",arr[3]);
                    //createClasses.Add("y",arr[3]);
                }
                else
                {
                    createItems.Add(c);
                }

            }


            foreach (var ch in characters)
            {
                Console.WriteLine(ch.ToString());
            }

            Engine engine = new Engine();
            engine.Run();
        }

     
    }
}
