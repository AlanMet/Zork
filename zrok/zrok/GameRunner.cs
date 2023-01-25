using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace zrok
{
    public class GameRunner
    {
        string adminfilename = "";
        Adventure adv;

        //instantiaton and input loop start
        public GameRunner()
        {
            adv = new Adventure();
            StartGame();
        }

        private void StartGame()
        {
            int darkcounter = 0;
            string input = "";
            int count = 0;
            string lines = "";
            string[] Delims = { "\n", "\r", "\r\n" };
            List<string> commands = new List<string>();
            do
            {
                //if a filename has been entered but not yet loaded
                if (adminfilename != "" && lines == "")
                {
                    try
                    {
                        using (StreamReader streamReader = new StreamReader(adminfilename))
                        {
                            lines = streamReader.ReadToEnd();
                            commands = lines.Split(Delims, StringSplitOptions.RemoveEmptyEntries).ToList();
                            count = 0;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("filename doesn't exist");
                    }

                }
                Console.WriteLine();
                //if the room is dark but the player doesnt have his lantern turned on
                if (adv.GetPlayer().GetRoom().GetDark() == true && adv.GetPlayer().GetLampStatus() == false)
                {

                    darkcounter++;
                    if (darkcounter == 1)
                    {
                        Console.WriteLine("It is pitch black. You are likely to be eaten by a Grue.");
                    }
                    if (darkcounter >= 2)
                    {
                        //dies when player makes any move that isn't turning on the lamp
                        Console.WriteLine("Oh, no!  A fearsome grue slithered into the room and devoured you.");
                        Console.WriteLine();
                        Console.WriteLine("You have died.");
                        //rickroll
                        //System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                        restart();
                    }
                }
                else
                {
                    //describe room and set entered to true
                    adv.Describe();
                    adv.GetPlayer().GetRoom().entered();
                    darkcounter = 0;
                }
                Console.Write("> ");
                if (commands.Count > 0)
                {
                    if (count == commands.Count)
                    {
                        commands = new List<string>();
                        continue;
                    }
                    else
                    {
                        //input when file loaded
                        input = commands[count];
                        count += 1;
                    }
                    Console.WriteLine(input);
                    //for reader convenience
                    Thread.Sleep(2000);
                }
                else
                {
                    //input
                    input = Console.ReadLine().ToLower();
                }
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
                else if (input.Trim() == "adminload")
                {
                    //automatically run commands
                    //still runs them as usual
                    Console.Write("filename: ");
                    adminfilename = Console.ReadLine();
                    adminfilename += ".txt";
                    Console.WriteLine();
                }
                else
                {
                    adv.ParseCommand(input.ToLower());
                }
            } while (input != "q" && input != "quit");
        }

        private void SaveGame()
        {
            //convert to binary file
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
            //load from binary file
            FileStream fs;
            BinaryFormatter binfmt;
            string filename;
            Console.Write("Enter filename to load: ");
            //check for symbols
            filename = Console.ReadLine();
            //error on not found
            try
            {
                fs = new FileStream(filename, FileMode.Open);
                binfmt = new BinaryFormatter();
                adv = (Adventure)binfmt.Deserialize(fs);
                fs.Close();
                Console.Clear();
                Console.WriteLine($"Successfully loaded {filename}");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("The file was not found.");
            }
            catch { Console.WriteLine("There was an issue doing that."); };
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
                    //reset state of console.
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
