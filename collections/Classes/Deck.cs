using System;
using System.Collections;
using System.Collections.Generic;

namespace collections.Classes
{
    /// <summary>
    /// Creating an array of 12 cards and using IEnumerator to return a collection of items. Yield return is used to return a deck of cards
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Deck<T> : IEnumerable<T>
    {
       T[] DeckOfCards = new T[12];
       public int currentIndex = 0;

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < currentIndex; i++)
            {
                yield return DeckOfCards[i];
            };
        }
        /// <summary>
        /// method to add a card to the deck and resize the deck times 2 
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            if (currentIndex > DeckOfCards.Length - 1)
            {
                Array.Resize(ref DeckOfCards, DeckOfCards.Length * 2);
            }

            DeckOfCards[currentIndex] = item;
            currentIndex++;
        }
        /// <summary>
        /// Removing a card by having a targeted value and iterating through to avoid that one item we want to delete
        /// </summary>
        /// <param name="item"></param>
        /// <returns>
        /// temp variable created that returns the new array without the one we want to delete
        /// </returns>
        public T Delete(T item)
        {
            T removed = default(T);

            for (int i = 0; i < currentIndex; i++)
            {
                if (DeckOfCards[i].Equals(item))
                {
                    removed = DeckOfCards[i];// finding the selected item we dont want

                    while (i < currentIndex - 1)
                    {
                        DeckOfCards[i] = DeckOfCards[i + 1]; // reset the new array
                        i++;
                    }
                    DeckOfCards[i] = default(T);

                    currentIndex--;
                    return removed;
                }             
            }


            throw new Exception("Card doesnt exist");
        } 
        
    }
}

