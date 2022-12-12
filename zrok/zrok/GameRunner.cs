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
            int darkcounter = 0;
            string input;
            do
            {
                Console.WriteLine();
                
                
                if (adv.GetPlayer().GetRoom().GetDark() == true && adv.GetPlayer().GetLampStatus() == false)
                {
                    
                    darkcounter++;
                    if (darkcounter == 1)
                    {
                        Console.WriteLine("It is pitch black. You are likely to be eaten by a Grue.");
                    }
                    if (darkcounter >= 2)
                    {
                        Console.WriteLine("Oh, no!  A fearsome grue slithered into the room and devoured you.");
                        Console.WriteLine();
                        Console.WriteLine("You have died.");
                        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                        restart();
                    }
                }
                else
                {
                    adv.Describe();
                    adv.GetPlayer().GetRoom().entered();
                    darkcounter = 0;
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

        private void SaveGame()
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

        private void LoadGame()
        {
            FileStream fs;
            BinaryFormatter binfmt;
            string filename;
            Console.Write("Enter filename to load: ");
            //check for symbols
            filename = Console.ReadLine();
            //error on not found
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
