using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;

// DI, Serilog, Settings

namespace GobiMax
{
    public class GameLoop : IGameLoop
    {
        private readonly ILogger<GreetingService> _log;
        private readonly IConfiguration _config;

        public GameLoop(ILogger<GreetingService> log, IConfiguration config)
        {
            _log = log;
            _config = config;
        }
        public void Run()
        {
            //_log.LogInformation("Starting Game");
            Console.Write("What is your name?");
            string charName = Console.ReadLine();
            int professionPick = 0;
            bool flag = false;
            while (!flag)
            {
                Console.Write("Pick a Profession (Enter a number):\n1) Artist\n2) Mage\n3) Knight\n4) Thief");
                professionPick = Convert.ToInt32(Console.ReadLine());
                if (professionPick < 1 || professionPick > 4)
                {
                    Console.WriteLine("Pick a valid option!");
                }
                else
                {
                    flag = true;
                }
            }

            string charProfession = "Default";
            switch (professionPick)
            {
                case 1:
                    charProfession = "Artist";
                    break;
                case 2:
                    charProfession = "Mage";
                    break;
                case 3:
                    charProfession = "Knight";
                    break;
                case 4:
                    charProfession = "Thief";
                    break;
                default:
                    break;
            }

            string charFaction = "Default";

            var mainCharacter = new PlayerCharacter(charName, charProfession, charFaction);
            Console.WriteLine(mainCharacter.Name);
            Console.WriteLine(mainCharacter.Profession);
        }
    }
}
