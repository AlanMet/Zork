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

        public void RunCommand(List<WordAndType> StringList)
        {
            return;
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
                    wordandtype.Add(new WordAndType(word,wordtype));
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

