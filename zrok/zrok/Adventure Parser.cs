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

        public void ProcessVerb(List<WordAndType> StringList)
        {
            WordAndType wt = StringList[0];
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
                        room.Describe();
                        break;
                    case "n":
                        room = Move(Direction.North, room);
                        break;
                    case "s":
                        room = Move(Direction.South, room);
                        break;
                    case "w":
                        room = Move(Direction.West, room);
                        break;
                    case "e":
                        room = Move(Direction.East, room);
                        break;
                    case "up":
                        room = Move(Direction.Up, room);
                        break;
                    case "down":
                        room = Move(Direction.Down, room);
                        break;
                    default:
                        Console.WriteLine($"Sorry, I can't {wt.GetWord()}!");
                        break;
                }
            }
        }
        public void ProcessVerbNoun(List<WordAndType> StringList)
        {
            WordAndType wt = command[0];
            WordAndType wt2 = command[1];
            string s = "";
            if (wt.Type != WT.VERB)
            {
                s = $"Can't do this because '{wt.Word}' is not a command!";
            }
            else if (wt2.Type != WT.NOUN)
            {
                s = $"Can't do this because '{wt2.Word}' is not an object!";
            }
            else
            {
                switch (wt.Word)
                {
                    case "take":
                        s = TakeOb(wt2.Word);
                        break;
                    case "drop":
                        s = DropOb(wt2.Word);
                        break;
                    case "open":
                        s = OpenOb(wt2.Word);
                        break;
                    case "close":
                        s = CloseOb(wt2.Word);
                        break;
                    case "pull":
                        s = PullOb(wt2.Word);
                        break;
                    case "push":
                        s = PushOb(wt2.Word);
                        break;
                    default:
                        s = $"I don't know how to {wt.Word} a {wt2.Word}!";
                        break;
                }
            }
            return s;
        }
        public void ProcessVerbPrepositionNoun(List<WordAndType> StringList)
        {
            WordAndType wt = command[0];
            WordAndType wt2 = command[1];
            WordAndType wt3 = command[2];
            string s = "";
            if ((wt.Type != WT.VERB) || (wt2.Type != WT.PREPOSITION))
            {
                s = $"Can't do this because I don't understand '{wt.Word} {wt2.Word}' !";
            }
            else if (wt3.Type != WT.NOUN)
            {
                s = $"Can't do this because '{wt3.Word}' is not an object!\r\n";
            }
            else
            {
                switch (wt.Word + wt2.Word)
                {
                    case "lookat":
                        s = LookAtOb(wt3.Word);
                        break;
                    default:
                        s = $"I don't know how to {wt.Word} {wt2.Word} a {wt3.Word}!";
                        break;
                }
            }
            return s;
        }
        public void ProcessVerbNounPrepositionNoun(List<WordAndType> StringList)
        {
            WordAndType wt1 = command[0];
            WordAndType wt2 = command[1];
            WordAndType wt3 = command[2];
            WordAndType wt4 = command[3];
            string s = "";
            if ((wt1.Type != WT.VERB) || (wt3.Type != WT.PREPOSITION))
            {
                s = $"Can't do this because I don't understand how to {wt1.Word} something {wt3.Word} something else!";
            }
            else if (wt2.Type != WT.NOUN)
            {
                s = $"Can't do this because '{wt2.Word}' is not an object!";
            }
            else if (wt4.Type != WT.NOUN)
            {
                s = $"Can't do this because '{wt4.Word}' is not an object!";
            }
            else
            {
                switch (wt1.Word + wt3.Word)
                {
                    case "putin":
                    case "putinto":         // allow either "put in" or "put into"...
                        s = PutObInContainer(wt2.Word, wt4.Word);
                        break;
                    default:
                        s = $"I don't know how to {wt1.Word} {wt2.Word} {wt3.Word} {wt4.Word}!";
                        break;
                }
            }
            return s;
        }

        public void RunCommand(List<WordAndType> StringList)
        {
            int length = StringList.Count;
            if (length == 1)
            {
                ProcessVerb(StringList);
            }
            else if (length == 2)
            {
                ProcessVerbNoun(StringList);
            }
            else if (length == 3)
            {
                ProcessVerbPrepositionNoun(StringList);
            }
            else if (length == 4)
            {
                ProcessVerbNounPrepositionNoun(StringList);
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

