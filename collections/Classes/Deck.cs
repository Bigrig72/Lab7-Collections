using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace collections.Classes
{
    public class Deck<T> : IEnumerable<T>
    {
        T[] DeckOfCards = new T[52];
        int currentIndex = 0;

        public void Add(T item)
        {
            if (currentIndex > DeckOfCards.Length - 1)
            {
                Array.Resize(ref DeckOfCards, DeckOfCards.Length + 1);
            }
            DeckOfCards[currentIndex] = item;
            currentIndex++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < currentIndex; i++)
            {
                yield return DeckOfCards[i];
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
    
