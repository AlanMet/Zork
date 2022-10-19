using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        private void InitVocab() {
            //vocab.Add("", WordType.);
            //including synonyms
            //verbs
            Vocab.Add("save", WordType.VERB);
            Vocab.Add("load", WordType.VERB);
            Vocab.Add("u", WordType.VERB);
            Vocab.Add("up", WordType.VERB);
            Vocab.Add("n", WordType.VERB);
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
            Vocab.Add("look", WordType.VERB);
            Vocab.Add("inventory", WordType.VERB);


            //nouns 
            Vocab.Add("mailbox", WordType.NOUN);
            Vocab.Add("box", WordType.NOUN);

            //adjectives


            //determiners


            //prepositions
            Vocab.Add("with", WordType.NOUN);
            Vocab.Add("at", WordType.NOUN);
            Vocab.Add("to", WordType.NOUN);
            Vocab.Add("in", WordType.NOUN);
            Vocab.Add("down", WordType.NOUN);
            Vocab.Add("up", WordType.NOUN);
            Vocab.Add("under", WordType.NOUN);

            //pronouns


            //other



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
                    case "inventory":
                        //ShowInventory();
                        break;
                    case "describe":
                    case "look":
                        player.GetRoom().Describe();
                        break;
                    case "n":
                        player.Move(Direction.North);
                        break;
                    case "ne":
                        player.Move(Direction.NorthEast);
                        break;
                    case "nw":
                        player.Move(Direction.NorthWest);
                        break;
                    case "s":
                        player.Move(Direction.South);
                        break;
                    case "sw":
                        player.Move(Direction.SouthWest);
                        break;
                    case "se":
                        player.Move(Direction.SouthEast);
                        break;
                    case "w":
                        player.Move(Direction.West);
                        break;
                    case "e":
                        player.Move(Direction.East);
                        break;
                    case "climb":
                    case "up":
                        player.Move(Direction.Up);
                        break;
                    case "down":
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
                    case "drop":
                        player.DropObject(wt2.GetWord());
                        break;
                    case "open":
                        //player.OpenOb(wt2.Word);
                        break;
                    case "close":
                        //CloseOb(wt2.Word);
                        break;
                    case "pull":
                        //PullOb(wt2.Word);
                        break;
                    case "push":
                        //PushOb(wt2.Word);
                        break;
                    case "move":
                        //MoveOb(w2.Word)
                    default:
                        Console.WriteLine($"I don't know how to {wt.GetWord()} a {wt2.GetWord()}!");
                        break;
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
            else if(wt3.GetType() != WordType.VERB)
            {
                Console.WriteLine($"Can't do this because '{wt2.GetWord()}' is not a direction!");
            }
            else
            {
                switch (wt.GetWord())
                {
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
                            case "West":
                                player.Move(Direction.West);
                                break;
                            case "northwest":
                                player.Move(Direction.NorthWest);
                                break;
                        };
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
                        //LookAtOb(wt3.Word);
                        break;
                    default:
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
                    case "putin":
                    case "putinto":         // allow either "put in" or "put into"...
                        //PutObInContainer(wt2.Word, wt4.Word);
                        break;
                    default:
                        Console.WriteLine($"I don't know how to {wt1.GetWord()} {wt2.GetWord()} {wt3.GetWord()} {wt4.GetWord()}!");
                        break;
                }
            }
        }

        public void RunCommand(List<WordAndType> WordAndType)
        {
            int length = WordAndType.Count;
            if (length == 1)
            {
                ProcessVerb(WordAndType);
            }
            else if (length == 2)
            {
                //check if second word is a direction

                ProcessVerbNoun(WordAndType);
            }
            else if (length == 3)
            {
                ProcessVerbPrepositionNoun(WordAndType);
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
                if(Vocab.ContainsKey(word))
                {
                    wordtype = Vocab[word];
                    if (wordtype == WordType.PREPOSITION)
                    {
                    }
                    else
                    {
                        wordandtype.Add(new WordAndType(word, wordtype));
                    }
                }
                else
                {
                    Console.WriteLine($"I don't understand {word}");
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
            if(lowstr == "")
            {
                Console.WriteLine("I beg your pardon?");
                return;
            }
            else
                StringList = new List<string>(command.Split(Delims, StringSplitOptions.RemoveEmptyEntries));
                ProcessCommand(StringList);
            }
        }
    }

