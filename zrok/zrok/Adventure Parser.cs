using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace zrok{
    public partial class Adventure
    {
        //command types:
        //Verb: North or Look
        //Verb-Noun: Take x, Drop y
        //VERB-PREPOSITION-NOUN: Look At x, 
        //VERB-NOUN-PREPOSITION-NOUN: Put x in y, Kill Troll With x
        //
        //

        private Dictionary<string, WordType> Vocab = new Dictionary<string, WordType>();

        private void InitVocab()
        {
            //vocab.Add("", WordType.);
            //including synonyms
            //verbs
            Vocab.Add("save", WordType.VERB);
            Vocab.Add("load", WordType.VERB);
            Vocab.Add("u", WordType.VERB);
            Vocab.Add("up", WordType.VERB);
            Vocab.Add("n", WordType.VERB);
            Vocab.Add("down", WordType.VERB);
            Vocab.Add("d", WordType.VERB);
            Vocab.Add("north", WordType.VERB);
            Vocab.Add("ne", WordType.VERB);
            Vocab.Add("northeast", WordType.VERB);
            Vocab.Add("e", WordType.VERB);
            Vocab.Add("east", WordType.VERB);
            Vocab.Add("se", WordType.VERB);
            Vocab.Add("southeast", WordType.VERB);
            Vocab.Add("s", WordType.VERB);
            Vocab.Add("south", WordType.VERB);
            Vocab.Add("sw", WordType.VERB);
            Vocab.Add("southwest", WordType.VERB);
            Vocab.Add("w", WordType.VERB);
            Vocab.Add("west", WordType.VERB);
            Vocab.Add("nw", WordType.VERB);
            Vocab.Add("northwest", WordType.VERB);
            Vocab.Add("go", WordType.VERB);
            Vocab.Add("move", WordType.VERB);
            Vocab.Add("look", WordType.VERB);
            Vocab.Add("climb", WordType.VERB);
            Vocab.Add("inventory", WordType.VERB);
            Vocab.Add("i", WordType.VERB);
            Vocab.Add("inv", WordType.VERB);
            Vocab.Add("open", WordType.VERB);
            Vocab.Add("close", WordType.VERB);
            Vocab.Add("take", WordType.VERB);
            Vocab.Add("read", WordType.VERB);
            Vocab.Add("drop", WordType.VERB);
            Vocab.Add("describe", WordType.VERB);
            Vocab.Add("enter", WordType.VERB);
            Vocab.Add("turn", WordType.VERB);
            Vocab.Add("put", WordType.VERB);

            //nouns 
            Vocab.Add("all", WordType.NOUN);
            Vocab.Add("mailbox", WordType.NOUN);
            Vocab.Add("leaflet", WordType.NOUN);
            Vocab.Add("coins", WordType.NOUN);
            Vocab.Add("box", WordType.NOUN);
            Vocab.Add("room", WordType.NOUN);
            Vocab.Add("sword", WordType.NOUN);
            Vocab.Add("window", WordType.NOUN);
            Vocab.Add("rug", WordType.NOUN);
            Vocab.Add("trapdoor", WordType.NOUN);
            Vocab.Add("leaves", WordType.NOUN);
            Vocab.Add("lantern", WordType.NOUN);
            Vocab.Add("lamp", WordType.NOUN);
            Vocab.Add("painting", WordType.NOUN);
            Vocab.Add("knife", WordType.NOUN);
            Vocab.Add("rope", WordType.NOUN);
            Vocab.Add("case", WordType.NOUN);
            Vocab.Add("trophycase", WordType.NOUN);
            Vocab.Add("egg", WordType.NOUN);
            Vocab.Add("figurine", WordType.NOUN);
            Vocab.Add("bracelet", WordType.NOUN);
            Vocab.Add("trident", WordType.NOUN);
            Vocab.Add("platinum", WordType.NOUN);
            Vocab.Add("coffin", WordType.NOUN);
            Vocab.Add("bag", WordType.NOUN);


            //adjectives


            //determiners


            //prepositions
            Vocab.Add("with", WordType.PREPOSITION);
            Vocab.Add("at", WordType.PREPOSITION);
            Vocab.Add("to", WordType.PREPOSITION);
            Vocab.Add("in", WordType.PREPOSITION);
            Vocab.Add("inside", WordType.PREPOSITION);
            Vocab.Add("under", WordType.PREPOSITION);
            Vocab.Add("on", WordType.PREPOSITION);
            Vocab.Add("off", WordType.PREPOSITION);

            //pronouns


            //other
            Vocab.Add("the", WordType.OTHER);


        }

        public void ProcessVerb(List<WordAndType> WordAndType)
        {
            WordAndType wt = WordAndType[0];
            if (wt.GetType() != WordType.VERB)
            {
                Console.WriteLine($"Can't do this because '{wt.GetWord()}' is not a command!");
            }
            else
            {
                switch (wt.GetWord())
                {
                    case "i":
                    case "inv":
                    case "inventory":
                        player.ShowInventory();
                        break;
                    case "describe":
                    case "look":
                        player.GetRoom().Describe();
                        break;
                    case "north":
                    case "n":
                        player.Move(Direction.North);
                        break;
                    case "northeast":
                    case "ne":
                        player.Move(Direction.NorthEast);
                        break;
                    case "northwest":
                    case "nw":
                        player.Move(Direction.NorthWest);
                        break;
                    case "south":
                    case "s":
                        player.Move(Direction.South);
                        break;
                    case "southwest":
                    case "sw":
                        player.Move(Direction.SouthWest);
                        break;
                    case "southeast":
                    case "se":
                        player.Move(Direction.SouthEast);
                        break;
                    case "west":
                    case "w":
                        player.Move(Direction.West);
                        break;
                    case "east":
                    case "e":
                        player.Move(Direction.East);
                        break;
                    case "climb":
                    case "up":
                    case "u":
                        player.Move(Direction.Up);
                        break;
                    case "down":
                    case "d":
                        player.Move(Direction.Down);
                        break;
                    default:
                        Console.WriteLine($"Sorry, I can't {wt.GetWord()}!");
                        break;
                }
            }
        }
        public void ProcessVerbNoun(List<WordAndType> WordAndType)
        {
            WordAndType wt = WordAndType[0];
            WordAndType wt2 = WordAndType[1];
            if (wt.GetType() != WordType.VERB)
            {
                Console.WriteLine($"Can't do this because '{wt.GetWord()}' is not a command!");
            }
            else if (wt2.GetType() != WordType.NOUN)
            {
                Console.WriteLine($"Can't do this because '{wt2.GetWord()}' is not an object!");
            }
            else
            {
                switch (wt.GetWord())
                {
                    case "take":
                        player.TakeObject(wt2.GetWord());
                        break;
                    case "read":
                        foreach (var item in player.GetInventory().GetItems())
                        {
                            if (item.IsSynonym(wt2.GetWord()))
                            {
                                Console.WriteLine(item.GetDescription());
                                return;
                            }
                        }
                        Console.WriteLine("You don't see that");
                        break;
                    case "drop":
                        player.DropObject(wt2.GetWord());
                        break;
                    case "open":
                        //check for containers
                        player.OpenObject(wt2.GetWord());
                        break;
                    case "close":
                        player.CloseObject(wt2.GetWord());
                        break;
                    case "pull":
                        //PullOb(wt2.Word);
                        break;
                    case "push":
                        //PushOb(wt2.Word);
                        break;
                    case "move":
                        if (wt2.GetWord() == "rug" || wt2.GetWord() == "leaves")
                        {
                            if (player.GetRoom().GetType() == typeof(TrapDoorRoom))
                            {
                                TrapDoorRoom aroom = (TrapDoorRoom)player.GetRoom();
                                aroom.Move();
                                Console.WriteLine($"With a great effort, the {wt2.GetWord()} is moved to one side of the room, revealing the dusty cover of a closed trap door.");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine($"I don't know how to {wt.GetWord()} a {wt2.GetWord()}!");
                        return;
                }
                if (wt.GetWord() + wt2.GetWord() == "takeall")
                {
                    player.TakeAll();
                }
            }
        }

        public void ProcessVerbVerbVerb(List<WordAndType> WordAndType)
        {
            WordAndType wt = WordAndType[0];
            WordAndType wt2 = WordAndType[1];
            WordAndType wt3 = WordAndType[2];
            if (wt.GetType() != WordType.VERB)
            {
                Console.WriteLine($"Can't do this because '{wt.GetWord()}' is not a command!");
            }
            else if (wt2.GetType() != WordType.VERB)
            {
                Console.WriteLine($"Can't do this because '{wt2.GetWord()}' is not a direction!");
            }
            else if (wt3.GetType() != WordType.VERB)
            {
                Console.WriteLine($"Can't do this because '{wt2.GetWord()}' is not a direction!");
            }
            else
            {
                switch (wt.GetWord())
                {
                    case "go":
                    case "move":
                        if (wt2.GetWord() == "north" || wt2.GetWord() == "n")
                        {
                            if (wt3.GetWord() == "east" || wt3.GetWord() == "e")
                            {
                                player.Move(Direction.NorthEast);
                            }
                            else if (wt3.GetWord() == "west" || wt3.GetWord() == "w")
                            {
                                player.Move(Direction.NorthWest);
                            }
                            else
                            {
                                player.Move(Direction.North);
                            }

                        }
                        else if (wt2.GetWord() == "south" || wt2.GetWord() == "s")
                        {
                            if (wt3.GetWord() == "east" || wt3.GetWord() == "e")
                            {
                                player.Move(Direction.SouthEast);
                            }
                            else if (wt3.GetWord() == "west" || wt3.GetWord() == "w")
                            {
                                player.Move(Direction.SouthWest);
                            }

                        }
                        break;
                }
            }
        }

        public void ProcessVerbVerb(List<WordAndType> WordAndType)
        {
            WordAndType wt = WordAndType[0];
            WordAndType wt2 = WordAndType[1];
            if (wt.GetType() != WordType.VERB)
            {
                Console.WriteLine($"Can't do this because '{wt.GetWord()}' is not a command!");
            }
            else if (wt2.GetType() != WordType.VERB)
            {
                Console.WriteLine($"Can't do this because '{wt2.GetWord()}' is not a direction!");
            }
            else
            {
                switch (wt.GetWord())
                {
                    case "move":
                    case "go":
                        //Console.WriteLine(wt2.GetWord());
                        switch (wt2.GetWord())
                        {
                            case "n":
                            case "north":
                                player.Move(Direction.North);
                                break;
                            case "ne":
                            case "northeast":
                                player.Move(Direction.NorthEast);
                                break;
                            case "e":
                            case "east":
                                player.Move(Direction.East);
                                break;
                            case "se":
                            case "southeast":
                                player.Move(Direction.SouthEast);
                                break;
                            case "s":
                            case "south":
                                player.Move(Direction.South);
                                break;
                            case "sw":
                            case "southwest":
                                player.Move(Direction.SouthWest);
                                break;
                            case "w":
                            case "west":
                                //Console.WriteLine(wt2.GetWord());
                                player.Move(Direction.West);
                                break;
                            case "northwest":
                                player.Move(Direction.NorthWest);
                                break;
                            case "down":
                                player.Move(Direction.Down);
                                break;
                            case "u":
                            case "up":
                                player.Move(Direction.Up);
                                break;
                        };
                        break;
                    case "south":
                        switch (wt2.GetWord())
                        {
                            case "east":
                                player.Move(Direction.SouthEast);
                                break;
                            case "west":
                                player.Move(Direction.SouthWest);
                                break;
                            default:
                                break;
                        }
                        break;
                    case "north":
                        switch (wt2.GetWord())
                        {
                            case "east":
                                player.Move(Direction.NorthEast);
                                break;
                            case "west":
                                player.Move(Direction.NorthWest);
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine($"I don't know how to {wt.GetWord()} {wt2.GetWord()}!");
                        break;
                }
            }
        }

        public void ProcessVerbPrepositionNoun(List<WordAndType> WordAndType)
        {
            WordAndType wt = WordAndType[0];
            WordAndType wt2 = WordAndType[1];
            WordAndType wt3 = WordAndType[2];
            string s = "";
            if ((wt.GetType() != WordType.VERB) || (wt2.GetType() != WordType.PREPOSITION))
            {
                s = $"Can't do this because I don't understand '{wt.GetWord()} {wt2.GetWord()}' !";
            }
            else if (wt3.GetType() != WordType.NOUN)
            {
                s = $"Can't do this because '{wt3.GetWord()}' is not an object!\r\n";
            }
            else
            {
                switch (wt.GetWord() + wt2.GetWord())
                {
                    case "lookat":
                        player.LookAt(wt3.GetWord());
                        break;
                    case "turnon":
                        player.TurnOn();
                        break;
                    case "turnoff":
                        player.TurnOff();
                        break;
                    default:
                        //Console.WriteLine("right ");
                        Console.WriteLine($"I don't know how to {wt.GetWord()} {wt2.GetWord()} a {wt3.GetWord()}!");
                        break;
                }
            }
        }
        public void ProcessVerbNounPrepositionNoun(List<WordAndType> WordAndType)
        {
            WordAndType wt1 = WordAndType[0];
            WordAndType wt2 = WordAndType[1];
            WordAndType wt3 = WordAndType[2];
            WordAndType wt4 = WordAndType[3];
            string s = "";
            if ((wt1.GetType() != WordType.VERB) || (wt3.GetType() != WordType.PREPOSITION))
            {
                s = $"Can't do this because I don't understand how to {wt1.GetWord()} something {wt3.GetWord()} something else!";
            }
            else if (wt2.GetType() != WordType.NOUN)
            {
                s = $"Can't do this because '{wt2.GetWord()}' is not an object!";
            }
            else if (wt4.GetType() != WordType.NOUN)
            {
                s = $"Can't do this because '{wt4.GetWord()}' is not an object!";
            }
            else
            {
                switch (wt1.GetWord() + wt3.GetWord())
                {
                    case "putinside":
                    case "putin":
                    case "putinto":
                        // allow either "put in" or "put into"...
                        player.PutObInContainer(wt2.GetWord(), wt4.GetWord());
                        break;
                    default:
                        Console.WriteLine($"I don't know how to {wt1.GetWord()} {wt2.GetWord()} {wt3.GetWord()} {wt4.GetWord()}!");
                        break;
                }
            }
        }

        public void RunCommand(List<WordAndType> WordAndType)
        {
            //runs based on length 
            int length = WordAndType.Count;
            if (length == 1)
            {
                ProcessVerb(WordAndType);
            }
            else if (length == 2)
            {
                //check if second word is a direction
                if (WordAndType[1].GetType() == WordType.NOUN)
                {
                    ProcessVerbNoun(WordAndType);
                }
                else
                {
                    ProcessVerbVerb(WordAndType);
                }
            }
            else if (length == 3)
            {
                if (WordAndType[1].GetType() == WordType.VERB && WordAndType[2].GetType() == WordType.VERB)
                {
                    ProcessVerbVerbVerb(WordAndType);
                }
                else
                {
                    ProcessVerbPrepositionNoun(WordAndType);
                }

            }
            else if (length == 4)
            {
                ProcessVerbNounPrepositionNoun(WordAndType);
            }
            else if (length >= 5)
            {
                Console.WriteLine("Command is too long!");
            }
        }

        public void ProcessCommand(List<string> StringList)
        {
            List<WordAndType> wordandtype = new List<WordAndType>();
            WordType wordtype;
            foreach (string word in StringList)
            {
                if (Vocab.ContainsKey(word))
                {
                    wordtype = Vocab[word];
                    if (wordtype == WordType.PREPOSITION)
                    {
                        wordandtype.Add(new WordAndType(word, wordtype));
                    }
                    else if (wordtype == WordType.OTHER)
                    {
                    }
                    else
                    {
                        wordandtype.Add(new WordAndType(word, wordtype));
                    }
                }
                else
                {
                    //levenshtein distance to find the percentage differance between words in the dictionary and respond with
                    //did you mean {word}?
                    
                    Console.WriteLine($"I don't understand {word}");
                    foreach (var item in Vocab)
                    {
                        string worda = item.Key;

                        if (CalcLevenshteinDistance(worda, word) <= 2)
                        {
                            Console.WriteLine($"did you mean {worda}?");
                            return;
                        }
                    }
                    return;
                }
            }
            RunCommand(wordandtype);
        }

        public void ParseCommand(string command)
        {
            //first check, valid command? parse
            //second check, valid words? process
            //third check, valid combination? run type
            //run command

            char[] Delims = { ' ', '.' };
            List<string> StringList;
            string lowstr = command.Trim().ToLower();
            if (lowstr == "")
            {
                Console.WriteLine("I beg your pardon?");
                return;
            }
            else
            {
                StringList = new List<string>(command.Split(Delims, StringSplitOptions.RemoveEmptyEntries));
                ProcessCommand(StringList);
            }
        }

        private static int CalcLevenshteinDistance(string a, string b)
        {
            if (String.IsNullOrEmpty(a) && String.IsNullOrEmpty(b))
            {
                return 0;
            }
            if (String.IsNullOrEmpty(a))
            {
                return b.Length;
            }
            if (String.IsNullOrEmpty(b))
            {
                return a.Length;
            }
            int lengthA = a.Length;
            int lengthB = b.Length;
            var distances = new int[lengthA + 1, lengthB + 1];
            for (int i = 0; i <= lengthA; distances[i, 0] = i++) ;
            for (int j = 0; j <= lengthB; distances[0, j] = j++) ;

            for (int i = 1; i <= lengthA; i++)
                for (int j = 1; j <= lengthB; j++)
                {
                    int cost = b[j - 1] == a[i - 1] ? 0 : 1;
                    distances[i, j] = Math.Min
                        (
                        Math.Min(distances[i - 1, j] + 1, distances[i, j - 1] + 1),
                        distances[i - 1, j - 1] + cost
                        );
                }
            return distances[lengthA, lengthB];
        }
    }
}

