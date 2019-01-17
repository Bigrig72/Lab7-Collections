using System;
using collections.Classes;

namespace collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============Dealers Deck Of Cards============");

            Deck<Card> Deck = new Deck<Card>();
            Card card1 = new Card(Rank.Ace, Suit.Clubs);
            Card card2 = new Card(Rank.Two, Suit.Hearts);
            Card card3 = new Card(Rank.Three, Suit.Spades);
            Card card4 = new Card(Rank.Four, Suit.Clubs);
            Card card5 = new Card(Rank.Five, Suit.Hearts);
            Card card6 = new Card(Rank.Six, Suit.Diamonds);
            Card card7 = new Card(Rank.Seven, Suit.Hearts);
            Card card8 = new Card(Rank.Eight, Suit.Spades);
            Card card9 = new Card(Rank.Nine, Suit.Diamonds);
            Card card10 = new Card(Rank.Ten, Suit.Diamonds);
            Card card11 = new Card(Rank.Jack, Suit.Spades);
            Card card12 = new Card(Rank.Queen, Suit.Clubs);


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
            Deck.Add(card11);
            Deck.Add(card12);

            foreach (Card item in Deck)
            {
                Console.WriteLine($"{item.Value} of {item.Suit}");
            }

            Console.WriteLine("==============Dealt Cards============");

            int counter = 0;

            foreach (Card item in Deck)
            {
                counter++;

                if (counter < 6)
                {
                    Console.WriteLine($"Player 1 cards: {item.Value} of {item.Suit}");
                }
                else if (counter >= 6 && counter < 11)
                {
                    //Console.WriteLine("==================Player 2 Cards============")

                    Console.WriteLine($"Player 2 cards are: {item.Value} of {item.Suit}");
                }
                else
                {
                    Console.WriteLine($"Dealer cards are: {item.Value} of {item.Suit}");
                }

            }
            //Deck.Delete(card1);

            //foreach (Card item in Deck)
            //{
            //    Console.WriteLine($"{item.Value} of {item.Suit}");
            //}
        }

        //public static bool PlayerOneCards()
        //{
        //    for (int i = 0; i < Deck.Le; i++)
        //    {

        //    }
        //}



        //public Card DealCard()
        //{


        //    //Deal cards to player 1 and 2 randomly to a set number of cards
        //    //the remaining cards go to the dealer
        //    //as you renove a card from a player it goes back to dealer or to the deck
        //    //output what player 1 has player 2 has and dealer before and after cards are delt
        //  }


    }
}
