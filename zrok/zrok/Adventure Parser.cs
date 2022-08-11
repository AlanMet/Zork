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
            Vocab.Add("n", WordType.VERB);
            Vocab.Add("ne", WordType.VERB);
            Vocab.Add("e", WordType.VERB);
            Vocab.Add("se", WordType.VERB);
            Vocab.Add("s", WordType.VERB);
            Vocab.Add("sw", WordType.VERB);
            Vocab.Add("w", WordType.VERB);
            Vocab.Add("nw", WordType.VERB);
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
                    case "s":
                        player.Move(Direction.South);
                        break;
                    case "w":
                        player.Move(Direction.West);
                        break;
                    case "e":
                        player.Move(Direction.East);
                        break;
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
                    case "move":
                        if (wt2.GetWord() == "North" || wt2.GetWord() == "n")
                        {
                            player.Move(Direction.North);
                        }
                        else if (wt2.GetWord() == "East" || wt2.GetWord() == "e")
                        {
                            player.Move(Direction.East);
                        }
                        else if (wt2.GetWord() == "South" || wt2.GetWord() == "s")
                        {
                            player.Move(Direction.South);
                        }
                        else if (wt2.GetWord() == "West" || wt2.GetWord() == "w")
                        {
                            player.Move(Direction.West);
                        }
                        else if (wt2.GetWord() == "Up" || wt2.GetWord() == "u")
                        {
                            player.Move(Direction.Up);
                        }
                        else if (wt2.GetWord() == "Down" || wt2.GetWord() == "d")
                        {
                            player.Move(Direction.Down);
                        }
                        break;
                    case "take":
                        player.TakeObject(wt2.GetWord());
                        break;
                    case "drop":
                        //DropOb(wt2.Word);
                        break;
                    case "open":
                        //OpenOb(wt2.Word);
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
                    default:
                        Console.WriteLine($"I don't know how to {wt.GetWord()} a {wt2.GetWord()}!");
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
                    case "move":
                        if (wt2.GetWord() == "North" || wt2.GetWord() == "n")
                        {
                            if (wt3.GetWord() == "East" || wt3.GetWord() == "e")
                            {
                                player.Move(Direction.NorthEast);
                            }
                            else if (wt3.GetWord() == "west" || wt3.GetWord() == "w")
                            {
                                player.Move(Direction.NorthWest);
                            }
                            
                        }
                        else if (wt2.GetWord() == "South" || wt2.GetWord() == "s")
                        {
                            if (wt3.GetWord() == "East" || wt3.GetWord() == "e")
                            {
                                player.Move(Direction.SouthEast);
                            }
                            else if (wt3.GetWord() == "west" || wt3.GetWord() == "w")
                            {
                                player.Move(Direction.SouthWest);
                            }

                        }
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

