using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICA9_JingLi
{
    public enum Combination
    {
        None,
        Pair,
        TwoPair,
        ThreeofaKind,
        Straight,
        Flush,
        FullHouse,
        FourofaKind,
        StraightFlush,
        RoyalFlush,
    }

    public enum Suit
    {
        Diamonds,
        Clubs,
        Hearts,
        Spades
    }
    public enum Faces
    {
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    public struct Cards
    {

        public Suit Suits;
        public Faces Face;

        public Cards(Suit S, Faces F)
        {
            Suits = S;
            Face = F;
        }



        public override string ToString()
        {
            return Face + " of " + Suits;
        }


    }
}
