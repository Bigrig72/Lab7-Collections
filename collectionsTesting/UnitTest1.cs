using collections.Classes;
using System;
using Xunit;

namespace collectionsTesting
{
    public class UnitTest1
    {
        [Fact]
        // Test to see if you can add a card
        public void CheckToAddCard1()
        {
            Deck<Card> deck = new Deck<Card>();
            Card card1 = new Card(Rank.Ace, Suit.Clubs);

            deck.Add(card1);

            Assert.Equal(1, deck.currentIndex);
        }
        [Fact]
        public void CheckToAddCard2()
        {
            Deck<Card> deck = new Deck<Card>();
            Card card1 = new Card(Rank.Ace, Suit.Clubs);
            Card card2 = new Card(Rank.Ace, Suit.Clubs);

            deck.Add(card1);
            deck.Add(card2);

            Assert.Equal(2, deck.currentIndex);
        }
        [Fact]
        public void CheckToAddCard3()
        {
            Deck<Card> deck = new Deck<Card>();
            Card card1 = new Card(Rank.Ace, Suit.Clubs);
            Card card2 = new Card(Rank.Ace, Suit.Clubs);
            Card card3 = new Card(Rank.Ace, Suit.Clubs);

            deck.Add(card1);
            deck.Add(card2);
            deck.Add(card3);

            Assert.Equal(3, deck.currentIndex);
        }
        [Fact]
        // check to see if you can remove card from deck
        public void CheckToDeleteCard1()
        {
            Deck<Card> deck = new Deck<Card>();
            Card card1 = new Card(Rank.Ace, Suit.Clubs);

            deck.Add(card1);
            deck.Delete(card1);            

            Assert.Equal(0, deck.currentIndex);
        }
        [Fact]
        public void CheckToDeleteCard2()
        {
            Deck<Card> deck = new Deck<Card>();
            Card card1 = new Card(Rank.Ace, Suit.Clubs);
            Card card2 = new Card(Rank.Ace, Suit.Clubs);

            deck.Add(card1);
            deck.Add(card2);

            deck.Delete(card1);

            Assert.Equal(1, deck.currentIndex);
        }
        [Fact]
        public void CheckToDeleteCard3()
        {
            Deck<Card> deck = new Deck<Card>();
            Card card1 = new Card(Rank.Ace, Suit.Clubs);
            Card card2 = new Card(Rank.Ace, Suit.Clubs);
            Card card3 = new Card(Rank.Ace, Suit.Clubs);

            deck.Add(card1);
            deck.Add(card2);
            deck.Add(card3);

            deck.Delete(card1);

            Assert.Equal(2, deck.currentIndex);
        }
        [Fact]
        // Can not remove a card that does not exist in the deck
        public void CanNotRemoveCard1()
        {
            Deck<Card> deck = new Deck<Card>();
            Card card1 = new Card(Rank.Ace, Suit.Clubs);        
            deck.Add(card1);

            Card newCard = new Card(Rank.Eight, Suit.Clubs);

            Exception ex = Assert.Throws<Exception>(() => deck.Delete(newCard));

            Assert.Equal("Card doesnt exist", ex.Message);

        }
    }
}
    