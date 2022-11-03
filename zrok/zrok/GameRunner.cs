using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace zrok
{
    public class GameRunner
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
                if (adv.GetPlayer().GetRoom().IsUnderground() && adv.GetPlayer().GetInventory().GetTreasureCount() > 0)
                {
                    //Thief thief = new Thief(100 );
                }
                Console.Write("> ");
                input = Console.ReadLine().ToLower();
                if (input.Trim() == "save")
                {
                    SaveGame();
                    continue;
                }
                else if (input.Trim() == "load")
                {
                    LoadGame();
                    continue;
                }
                else if (input.Trim() == "reset" || input.Trim() == "restart")
                {
                    restart();
                    continue;
                }
                adv.ParseCommand(input);
            } while (input != "q" && input !="quit");
        }

        public void SaveGame()
        {
            FileStream fs;
            BinaryFormatter binfmt;
            string filename;
            Console.Write("Enter filename to save: ");
            filename = Console.ReadLine();
            //check for symbols
            fs = new FileStream(filename, FileMode.Create);
            binfmt = new BinaryFormatter();
            try
            {
                binfmt.Serialize(fs, adv);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("There was a problem doing that" + e);
            }
            finally
            {
                fs.Close();
                Console.WriteLine($"Successfully saved as {filename}");
            }
        }

        public void LoadGame()
        {
            FileStream fs;
            BinaryFormatter binfmt;
            string filename;
            Console.Write("Enter filename to load: ");
            //check for symbols
            filename = Console.ReadLine();
            fs = new FileStream(filename, FileMode.Open);
            binfmt = new BinaryFormatter();
            try
            {
                adv = (Adventure)binfmt.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("there was an error doing that." + e);
            }
            finally
            {
                fs.Close();
                Console.Clear();
                Console.WriteLine($"Successfully loaded {filename}");
            }
        }

        public void restart()
        {
            string Choice = "f";
            Console.WriteLine("Are you sure you want to restart? Y/N ");
            while (Choice.Trim() != "y" || Choice.Trim() != "n")
            {
                Choice = Console.ReadLine().ToLower();
                if (Choice.Trim() == "y")
                {
                    Console.Clear();
                    adv = new Adventure();
                    return;
                }
                if (Choice.Trim() == "n")
                {
                    return;
                }
                Console.WriteLine("please enter a valid choice.");
            }
        }
    }
}
