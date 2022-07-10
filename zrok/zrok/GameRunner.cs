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
            InitGame();
        }
        private void InitGame()
        {
            adv = new Adventure();
            Login();
        }

        private void Login()
        {
            //sql
        }

        private void StartGame()
        {
            string input;
            do
            {
                Console.Write("> ");
                input = Console.ReadLine().ToLower();
            } while (input != "q");
        }
    }
}
