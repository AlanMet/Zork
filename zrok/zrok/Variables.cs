using System;

namespace zrok
{
    public enum Direction
    {
        North,
        South,
        East,
        West,
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
        UNKNOWN,
        ERROR
    }
}
