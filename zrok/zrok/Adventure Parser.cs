using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zrok
{
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
            Vocab.Add("e", WordType.VERB);
            Vocab.Add("w", WordType.VERB);
            Vocab.Add("s", WordType.VERB);

            //nouns 
            Vocab.Add("mailbox", WordType.NOUN);
            Vocab.Add("box", WordType.NOUN);

            //adjectives


            //determiners


            //prepositions


            //pronouns
            

        }

        public void ProcessCommand(List<string> StringList)
        {
            Dictionary<string, WordType> WordAndType = new Dictionary<string, WordType>();
            WordType wordtype;
            foreach (string word in StringList) 
            {
                if(Vocab.ContainsKey(word))
                {
                    wordtype = Vocab[word];
                }
                else
                {
                    return;
                }
            }
        }

        public void ParseCommand(string command)
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
                StringList = new List<string>(command.Split(Delims, StringSplitOptions.RemoveEmptyEntries));
                ProcessCommand(StringList);
            }
        }
    }
}
