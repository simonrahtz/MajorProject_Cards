using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Player
    {
        LinkedList playerHand = new LinkedList();
        Deck deck;
        
              

        public Player(Deck deck)
        {
            this.deck = deck;
        }
     


        public void drawCard ()
        {
            playerHand.addValue(deck.DrawCard());
                       
                            
        }
        public void printCards()
        {
            playerHand.printValues();
        }
        public void shuffleHand()
        {
            playerHand.shuffleList();
        }
        

         public void saveToFile(string fileName)
        {
            
            
            BinaryFiles.writeData(fileName, playerHand);

                              
            
        }
        public void loadHandfromFile(string fileName)
        {
            

            BinaryFiles.readData(fileName, playerHand);
        }



    }
}
