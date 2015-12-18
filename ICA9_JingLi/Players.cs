using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICA9_JingLi
{
    public class Players
    {
        DeckofCards playerDeck = new DeckofCards();
        public List<Cards> hand = new List<Cards>();


        public void GenerateHand()
        {
            for (int i = 0; i < 52; i++)
            {
                Cards c = playerDeck.Random();
                hand.Add(c);
                playerDeck.deck.Remove(c);
            }


        }

        public Combination CardCombo(Combination cardcombo)
        {
            cardcombo = Combination.None;
            return cardcombo;
        }
    }
}
