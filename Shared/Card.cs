using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public enum Suits
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Values
    {
        Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
    }

    public class Card
    {
        
        private Suits suit;
        private Values value;

        public Card()
        {

        }

        public Card (Suits suit, Values value)
        {
            this.suit = suit;
            this.value = value;
        } 

        public Suits getSuit ()
        {
            return suit;
        }
        public void setSuit(Suits suit)
        {
            this.suit = suit;
        }
        public void setValue(Values value)
        {
            this.value = value;
        }
        public Values getValue()
        {
            return value;
        }

        public override string ToString()
        {

            return value.ToString() + " of " + suit.ToString();
        }
       
    }
}
