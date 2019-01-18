using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace collections.Classes
{
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

        public void Add(T item)
        {
            if (currentIndex > DeckOfCards.Length - 1)
            {
                Array.Resize(ref DeckOfCards, DeckOfCards.Length * 2);
            }

            DeckOfCards[currentIndex] = item;
            currentIndex++;
        }

        public T Delete(T item)
        {
            T removed = default(T);

            for (int i = 0; i < currentIndex; i++)
            {
                if (DeckOfCards[i].Equals(item))
                {
                    removed = DeckOfCards[i];

                    while (i < currentIndex - 1)
                    {
                        DeckOfCards[i] = DeckOfCards[i + 1];
                        i++;
                    }
                    DeckOfCards[i] = default(T);
                }
            }


           // Array.Resize(ref DeckOfCards, DeckOfCards.Length/2);
            currentIndex--;
            return removed;
        }
    }
}

