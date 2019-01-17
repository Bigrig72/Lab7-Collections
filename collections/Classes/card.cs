namespace collections.Classes
{
    public class Card
    {


        public Suit Suit { get; set; }

        public Rank Value { get; set; }

        public Card(Rank value, Suit suit)
        {

            Value = value;
            Suit = suit;
        }


    }
    public enum Rank
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public enum Suit
    {
        Clubs,
        Spades,
        Hearts,
        Diamonds
    }
}
