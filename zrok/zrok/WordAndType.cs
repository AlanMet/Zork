using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zrok
{
    class WordAndType
    {
        private string Word;
        private wordtype Type;

        public WordAndType(string word, wordtype type){
            Word = word;
            Type = type;
        }

        public string GetWord(){
            return Word;
        }

        public wordtype GetType(){
            return Type;
        }
    }
}
