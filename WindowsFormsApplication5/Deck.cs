using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Deck
    {
        LinkedList cardList = new LinkedList();



        public void fillDeck()
        {

            for (Values value = Values.Ace; value <= Values.King; value++)
            {
                for (Suits suit = Suits.Clubs; suit <= Suits.Spades; suit++)
                {
                    cardList.addValue(new Card(suit, value));
                }
            }



        }
        public Card DrawCard()
        {
            Card card = cardList.GetIndex(1);
            cardList.removeValue(card);
            return card;
        }

        public void shuffleDeck()
        {
            cardList.shuffleList();
        }
        public void printDeck()
        {
            cardList.printValues();
        }



    }
}
