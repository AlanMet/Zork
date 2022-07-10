using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zrok
{
    partial class Adventure
    {
        //command types:
        //Verb: North or Look
        //Verb-Noun: Take x, Drop y
        //VERB-PREPOSITION-NOUN: Look At x, 
        //VERB-NOUN-PREPOSITION-NOUN: Put x in y, Kill Troll With x
        //
        //

        Dictionary<string, WordType> vocab = new Dictionary<string, WordType>();

        private void InitVocab() {
            //vocab.Add("", WordType.);
            //including synonyms
            //verbs
            vocab.Add("save", WordType.VERB);
            vocab.Add("load", WordType.VERB);
            vocab.Add("n", WordType.VERB);
            vocab.Add("e", WordType.VERB);
            vocab.Add("w", WordType.VERB);
            vocab.Add("s", WordType.VERB);

            //nouns 
            vocab.Add("mailbox", WordType.VERB);
            vocab.Add("box", WordType.);

            //adjectives


            //determiners


            //prepositions


            //pronouns
            

        }

        public static void ProcessCommand(List<string> StringList)
        {

            foreach(string word in StringList) 
            {
                if(vocab.ContainsKey(word))
                {

                }
                else
                {
                    return;
                }
            }
        }

        public static void ParseCommand(string command)
        {
            char[] Delims = { ' ', '.' };
            List<string> StringList;
            string lowstr = command.Trim().ToLower();
            if(lowstr == "")
            {
                Console.WriteLine("Enter a valid command");
                return;
            }
            else
            {
                StringList = new List<string>(inputstr.Split(Delims, StringSplitOptions.RemoveEmptyEntries));
                ProcessCommand(StringList);
            }
        }
    }
}
