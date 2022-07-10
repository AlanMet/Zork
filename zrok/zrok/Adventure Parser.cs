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

        Dictionary<string, WT> vocab = new Dictionary<string, WT>();

        private void InitVocab() {
            //vocab.Add("", WT.);
            //including synonyms
            //verbs
            vocab.Add("save", WT.VERB);
            vocab.Add("load", WT.VERB);
            vocab.Add("n", WT.VERB);
            vocab.Add("e", WT.VERB);
            vocab.Add("w", WT.VERB);
            vocab.Add("s", WT.VERB);

            //nouns 
            vocab.Add("mailbox", WT.VERB);
            vocab.Add("box", WT.);

            //adjectives
            //determiners
            //prepositions
            //pronouns
            


        }

        public static void ParseCommand(string command)
        {
            char[] Delims = { ' ', '.' };
            List<string> StringList;
            string lowstr = command.Trim().ToLower();
            if(lowstr == "")
            {
                Console.WriteLine("Enter a valid command");
            }
            else
            {
                StringList = new List<string>(inputstr.Split(Delims, StringSplitOptions.RemoveEmptyEntries));
                Process(StringList);
            }
        }
    }
}
