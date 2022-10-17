using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zrok
{
    class GameRunner
    {
        Adventure adv;

        public GameRunner()
        {
            adv = new Adventure();
            StartGame();
        }

        private void StartGame()
        {
            string input;
            do
            {
                adv.Describe();
                Console.Write("> ");
                input = Console.ReadLine().ToLower();
                adv.ParseCommand(input);
            } while (input != "q" && input !="quit");
        }
    }
}
