using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Chp_382pg_IEnumerable_Lists
{
    class Deck
    {
        private List <Cards> cards;
        private Random random = new Random();

        public Deck()
        {
            cards = new List<Cards>();

             for (int suits = 0; suits < 4; suits++)
                {
                for (int values = 1; values < 14; values++)
                {
                    cards.Add(new Cards((Suit)suits, (Value)values));
                }
            }
        }

        public Deck(IEnumerable<Cards> initialCards)
        {
            cards = new List<Cards>(initialCards);
        }

        public int Count { get { return cards.Count; } }

        public void Add(Cards cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        public Cards Deal(int index)
        {
            Cards CardToDeal = cards[index];
            cards.RemoveAt(index);
            return CardToDeal;
        }

        public void Shuffle()
        {
            List<Cards> cardsCopy = new List<Cards>();

            while (cards.Count > 0)
            {
                int CardToRemove = random.Next(cards.Count);
                cardsCopy.Add(cards[CardToRemove]);
                cards.RemoveAt(CardToRemove);
            }

            cards = cardsCopy;
        }

        public IEnumerable<string> GetCardNames()
        {
            string[] CardNames = new string[cards.Count];

            for (int i = 0; i < cards.Count; i++)
            {
                CardNames[i] = cards[i].Name;
            }

            return CardNames;
        }

        public void Sort()
        {
            cards.Sort(new CardComparer_BySuit());
        }
    }
}
