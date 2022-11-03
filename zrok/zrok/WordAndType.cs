using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zrok
{
    [Serializable]
    public class WordAndType
    {
        private string Word;
        private WordType Type;

        public WordAndType(string word, WordType type){
            Word = word;
            Type = type;
        }

        public string GetWord(){
            return Word;
        }

        public new WordType GetType(){
            return Type;
        }
    }
}
