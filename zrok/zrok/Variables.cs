using System;

namespace zrok
{
    public enum Direction
    {
        North,
        NorthEast,
        East,
        SouthEast,
        South,
        SouthWest,
        West,
        NorthWest,
        Up,
        Down
    }

    public enum WordType {
        NOUN,//people, places or things "dog"
        VERB,//action word
        ADJECTIVE,// descriptive word
        DETERMINER,//introductory word, "the" cat
        PRONOUN,//noun without specificity, "it"
        PREPOSITION,//location word
        OTHER,
        UNKNOWN,
        ERROR
    }

    public enum ItemType
    {
        Weapon,
        Tool,
        Food
    }
}
