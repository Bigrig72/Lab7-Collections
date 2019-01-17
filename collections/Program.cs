using System;
using collections.Classes;

namespace collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Deck<Card> Deck = new Deck<Card>();
            Card card1 = new Card(Rank.Ace,Suit.Clubs);
            Card card2 = new Card(Rank.Two, Suit.Hearts);
            Card card3 = new Card(Rank.Three, Suit.Spades);
            Card card4 = new Card(Rank.Four, Suit.Clubs);
            Card card5 = new Card(Rank.Five, Suit.Hearts);
            Card card6 = new Card(Rank.Six, Suit.Diamonds);
            Card card7 = new Card(Rank.Seven, Suit.Hearts);
            Card card8 = new Card(Rank.Eight, Suit.Spades);
            Card card9 = new Card(Rank.Nine, Suit.Diamonds);
            Card card10 = new Card(Rank.Ten, Suit.Diamonds);

            Deck.Add(card1);
            Deck.Add(card2);
            Deck.Add(card3);
            Deck.Add(card4);
            Deck.Add(card5);
            Deck.Add(card6);
            Deck.Add(card7);
            Deck.Add(card8);
            Deck.Add(card9);
            Deck.Add(card10);

            foreach (Card item in Deck)
            {
                Console.WriteLine($"Your card is: {item.Value} of {item.Suit}");
            }
        }


    }
}
