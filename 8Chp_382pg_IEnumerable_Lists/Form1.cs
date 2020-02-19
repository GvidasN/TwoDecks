using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8Chp_382pg_IEnumerable_Lists
{

    public partial class Form1 : Form
    {
        Deck deck1;
        Deck deck2;
        Random random = new Random();

        void ResetDeck(int Deck)
        {
            if (Deck == 1)
            {
                int NumberOfCards = random.Next(1, 11);
                deck1 = new Deck(new Cards[] { });
                for (int i = 0; i < NumberOfCards; i++)
                    deck1.Add(new Cards((Suit)random.Next(4), (Value)random.Next(1, 14)));
                deck1.Sort();
            }
            else if (Deck == 2)
            {
                deck2 = new Deck();
            }
        }

        private void RedrawDeck(int Deck)
        {
            if (Deck == 1)
            {
                listDeck1.Items.Clear();
                foreach (string cardName in deck1.GetCardNames())
                    listDeck1.Items.Add(cardName);
                label1.Text = "Deck #1 (" + deck1.Count + " cards)";
            }
            else if (Deck == 2)
            {
                listDeck2.Items.Clear();
                foreach (string cardName in deck2.GetCardNames())
                    listDeck2.Items.Add(cardName);
                label2.Text = "Deck #1 (" + deck2.Count + " cards)";
            }
        }

        public Form1()
        {
            InitializeComponent();
            ResetDeck(1);
            ResetDeck(2);
            RedrawDeck(1);
            RedrawDeck(2);
      
        }

        private void butMoveToDeck2_Click(object sender, EventArgs e)
        {
            if (listDeck1.SelectedIndex >= 0)
            {
                if (deck1.Count > 0)
                {
                    deck2.Add(deck1.Deal(listDeck1.SelectedIndex));
                }
            }
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void butMoveToDeck1_Click(object sender, EventArgs e)
        {
            if (listDeck2.SelectedIndex >= 0)
            {
                if (deck2.Count > 0)
                {
                    deck1.Add(deck2.Deal(listDeck2.SelectedIndex));
                }
            }
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void butResetDeck1_Click(object sender, EventArgs e)
        {
            ResetDeck(1);
            RedrawDeck(1);
        }

        private void butResetDeck2_Click(object sender, EventArgs e)
        {
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void butShuffleDeck1_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(1);
        }

        private void butShuffleDeck2_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(2);
        }
    }
}
