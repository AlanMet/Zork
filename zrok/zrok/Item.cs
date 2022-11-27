using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zrok
{
    [Serializable]
    public class Item
    {
        private string Name;
        private List<string> Synonyms;
        private string Description;
        private string State = "";
        private bool Treasure = false;
        private bool Takeable = true;
        private string TakeableNegative;

        public Item(string name, string description)
        {
            Name = name;
            Description = description;
            Synonyms = new List<string>();
        }

        public Item(string name, string description, bool takeable,  string negative)
        {
            Name = name;
            Description = description;
            Synonyms = new List<string>();
            takeable = Takeable;
            TakeableNegative = negative;

        }

        public Item(string name, string description, bool treasure)
        {
            Name = name;
            Description = description;
            Treasure = treasure;
            Synonyms = new List<string>();
        }

        public void AddSynonym(string word)
        {
            Synonyms.Add(word);
        }
        
        public string GetTakeableDialogue()
        {
            if (Takeable)
            {
                return "Taken.";
            }
            else
            {
                return TakeableNegative;
            }
        }

        public void SetTakeable(bool choice)
        {
            Takeable = choice;
        }

        public bool GetTakeable()
        { 
            return Takeable;
        }

        public bool IsSynonym(string word)
        {
            if (word == this.GetName())
            {
                return true;
            }
            else
            {
                foreach (var item in Synonyms)
                {
                    if (item == word)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public string GetName()
        {
            return Name;
        }

        public string GetDescription()
        {
            return Description;
        }

        public bool IsTreasure()
        {
            return Treasure;
        }

        public void SetTrasure(bool choice)
        {
            Treasure = choice;
        }

        public string GetState()
        {
            return State;
        }

        public void ChangeState(string state)
        {
            State = state;
        }
    }
}
