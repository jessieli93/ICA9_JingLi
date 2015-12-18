using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICA9_JingLi
{
    class DeckofCards
    {
        private Random RandN = new Random();
        public List<Cards> deck = new List<Cards>();
        const int NofC = 52; // numbers in deck of cards
        char d = new char();



        public DeckofCards()
        {


            Cards AceOfSpa = new Cards(Suit.Spades, Faces.Ace);
            deck.Add(AceOfSpa);

            Cards TofSpa = new Cards(Suit.Spades, Faces.Two);
            deck.Add(TofSpa);

            Cards ThreeofSpa = new Cards(Suit.Spades, Faces.Three);
            deck.Add(ThreeofSpa);

            Cards FourofSpa = new Cards(Suit.Spades, Faces.Four);
            deck.Add(FourofSpa);

            Cards FiveofSpa = new Cards(Suit.Spades, Faces.Five);
            deck.Add(FiveofSpa);

            Cards SixofSpa = new Cards(Suit.Spades, Faces.Six);
            deck.Add(SixofSpa);

            Cards SevenofSpa = new Cards(Suit.Spades, Faces.Seven);
            deck.Add(SevenofSpa);

            Cards EightofSpa = new Cards(Suit.Spades, Faces.Eight);
            deck.Add(EightofSpa);

            Cards NineofSpa = new Cards(Suit.Spades, Faces.Nine);
            deck.Add(NineofSpa);

            Cards TenofSpa = new Cards(Suit.Spades, Faces.Ten);
            deck.Add(TenofSpa);

            Cards JackofSpa = new Cards(Suit.Spades, Faces.Jack);
            deck.Add(JackofSpa);

            Cards QueenofSpa = new Cards(Suit.Spades, Faces.Queen);
            deck.Add(QueenofSpa);

            Cards KingofSpa = new Cards(Suit.Spades, Faces.King);
            deck.Add(KingofSpa);

            //Hearts

            Cards AofH = new Cards(Suit.Hearts, Faces.Ace);
            deck.Add(AofH);

            Cards TwoofH = new Cards(Suit.Hearts, Faces.Two);
            deck.Add(TwoofH);

            Cards ThreeofH = new Cards(Suit.Hearts, Faces.Three);
            deck.Add(ThreeofH);

            Cards FourofH = new Cards(Suit.Hearts, Faces.Four);
            deck.Add(FourofH);

            Cards FiveofH = new Cards(Suit.Hearts, Faces.Five);
            deck.Add(FiveofH);

            Cards SixofH = new Cards(Suit.Hearts, Faces.Six);
            deck.Add(SixofH);

            Cards SevenofH = new Cards(Suit.Hearts, Faces.Seven);
            deck.Add(SevenofH);

            Cards EightofH = new Cards(Suit.Hearts, Faces.Eight);
            deck.Add(EightofH);

            Cards NineofH = new Cards(Suit.Hearts, Faces.Nine);
            deck.Add(NineofH);

            Cards TenofH = new Cards(Suit.Hearts, Faces.Ten);
            deck.Add(TenofH);

            Cards JackofH = new Cards(Suit.Hearts, Faces.Jack);
            deck.Add(JackofH);

            Cards QueenofH = new Cards(Suit.Hearts, Faces.Queen);
            deck.Add(QueenofH);

            Cards KingofH = new Cards(Suit.Hearts, Faces.King);
            deck.Add(KingofH);



            //Clubs

            Cards AofC = new Cards(Suit.Clubs, Faces.Ace);
            deck.Add(AofC);
            Cards TwoofC = new Cards(Suit.Clubs, Faces.Two);
            deck.Add(TwoofC);
            Cards ThreeofC = new Cards(Suit.Clubs, Faces.Three);
            deck.Add(ThreeofC);
            Cards FourofC = new Cards(Suit.Clubs, Faces.Four);
            deck.Add(FourofC);
            Cards FiveofC = new Cards(Suit.Clubs, Faces.Five);
            deck.Add(FiveofC);
            Cards SixofC = new Cards(Suit.Clubs, Faces.Six);
            deck.Add(SixofC);
            Cards SevenofC = new Cards(Suit.Clubs, Faces.Seven);
            deck.Add(SevenofC);
            Cards EightofC = new Cards(Suit.Clubs, Faces.Eight);
            deck.Add(EightofC);
            Cards NineofC = new Cards(Suit.Clubs, Faces.Nine);
            deck.Add(NineofC);
            Cards TenofC = new Cards(Suit.Clubs, Faces.Ten);
            deck.Add(TenofC);
            Cards JackofC = new Cards(Suit.Clubs, Faces.Jack);
            deck.Add(JackofC);
            Cards QueenofC = new Cards(Suit.Clubs, Faces.Queen);
            deck.Add(QueenofC);
            Cards KingofC = new Cards(Suit.Clubs, Faces.King);
            deck.Add(KingofC);

            //Diamonds

            Cards AofD = new Cards(Suit.Diamonds, Faces.Ace);
            deck.Add(AofD);
            Cards TwoofD = new Cards(Suit.Diamonds, Faces.Two);
            deck.Add(TwoofD);
            Cards ThreeofD = new Cards(Suit.Diamonds, Faces.Three);
            deck.Add(ThreeofD);
            Cards FourofD = new Cards(Suit.Diamonds, Faces.Four);
            deck.Add(FourofD);
            Cards FiveofD = new Cards(Suit.Diamonds, Faces.Five);
            deck.Add(FiveofD);
            Cards SixofD = new Cards(Suit.Diamonds, Faces.Six);
            deck.Add(SixofD);
            Cards SevenofD = new Cards(Suit.Diamonds, Faces.Seven);
            deck.Add(SevenofD);
            Cards EightofD = new Cards(Suit.Diamonds, Faces.Eight);
            deck.Add(EightofD);
            Cards NineofD = new Cards(Suit.Diamonds, Faces.Nine);
            deck.Add(NineofD);
            Cards TenofD = new Cards(Suit.Diamonds, Faces.Ten);
            deck.Add(TenofD);
            Cards JackofD = new Cards(Suit.Diamonds, Faces.Jack);
            deck.Add(JackofD);
            Cards QueenofD = new Cards(Suit.Diamonds, Faces.Queen);
            deck.Add(QueenofD);
            Cards KingofD = new Cards(Suit.Diamonds, Faces.King);
            deck.Add(KingofD);




        }




        // Shuffling the deck
        public void Shuffle()
        {
            Random randN = new Random();
            int e = 0;

            //run the shuffle 500 times
            foreach (Cards c in deck)
            {
                e++;
            }
            for (int i = 0; i < 500; i++)
            {
                int x = randN.Next(0, e);
                Cards c = deck[x];
                deck.Remove(c);
                deck.Add(c);
            }
        }
        public Cards Random()
        {
            Shuffle();
            Random Randn = new Random();
            int i = 0;
            foreach (Cards c in deck)
            {
                i++;
            }
            int a = Randn.Next(0, i);
            return deck[a];
        }
        public Players DetermineWinner(Players One, Players Two)
        {
            return null;
        }


    } // after the players
}
