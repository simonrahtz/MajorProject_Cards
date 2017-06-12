using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        Button newCard;
        Deck deck;
        Player player;
        

        private int buttonLocation = 100;

        public Form1()
        {
            InitializeComponent();
            deck = new Deck();
            player = new Player(deck);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            newCard = new Button();
            newCard.Location = new Point(buttonLocation,55);
            newCard.Size = (btnCard.Size);
            newCard.BackgroundImage = Image.FromFile("back.png");
            newCard.Tag = "back";
            newCard.BackgroundImageLayout = ImageLayout.Stretch;
            this.Controls.Add(newCard);

            buttonLocation += 50; //increase x coordinate by 50 each button click

            newCard.Click += new System.EventHandler(this.newCard_Click);

            

        }
        private void newCard_Click(object sender, EventArgs e)
        {
            Card card = deck.DrawCard();
            Button b = (Button)sender;
            
                        
                b.BackgroundImage = Image.FromFile(card.getValue().ToString() + "_of_" + card.getSuit().ToString() + ".png");
                b.Tag = "front";
                b.BackgroundImageLayout = ImageLayout.Stretch;
            
            
       
                       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            btnCard.BackgroundImage = Image.FromFile("back.png");
            btnCard.BackgroundImageLayout = ImageLayout.Stretch;

            deck.fillDeck();
            deck.shuffleDeck();

            

        }
       
    }
}
