using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace zl
{
    class Zirkulator
    {
        private Entry first, last, newValue;
        public Entry current;
       
        // Konstanten = unveränderliche Werte!
        private const int standardGroesse = 26;
        private const int beginnAsCIIBuchstaben = 65;

        /*** Der Konstruktor soll eine zirkuläre, doppelverkettete Liste
         * mit Einträgen des Alphabets bereitstellen
         Die Liste soll in beide Richtungen durchlaufen werden!
         ***/
        public Zirkulator()
        {
            if (first == null)
            {
                newValue = new Entry() { Value = 'A' };
                first = newValue;
                last = newValue;
                current = newValue;
                newValue.Next = first;
                newValue.Prev = first;
                for (int i = 1; i < standardGroesse; i++)
                {
                        char c = (char)(i + beginnAsCIIBuchstaben);
                        AddElement(c, last,i);                   
                }                
            }
            else
            {
                Console.WriteLine("Da ist schon ne Liste. Du brauchst nur eine.");
            }
        }

        // Soll ein Zeichen entgegennehmen und ein Entry in die Liste einfügen
        private void AddElement(char c, Entry last, int i)
        {
            if (i == standardGroesse-1)
            {
                newValue = new Entry() { Value = c };
                last.Next = newValue;
                this.last = newValue;
                newValue.Prev = last;
                newValue.Next = first;
                first.Prev = newValue;
            }
            else
            {
            newValue = new Entry() { Value = c };
            last.Next = newValue;
            this.last = newValue;
            newValue.Prev = last;
            }

        }


        // gibt innerhalb der Klasse ein Entry des gesuchten Elements zurück
        private Entry FindEntry(char c)
        {
            return null;
        }

        // geht von einem gesuchten Entry x Eintragungen in Richtung Nächster
        // und liefert den Entry
        public Entry SkipXForward(Entry e, int distance)
        {
            
            for (int i = 0; i < distance; i++)
            {
                e = e.Next;
            }
            return e;
        }


        // geht von einem gesuchten Entry x Eintragungen in Richtung Vorgänger
        // und liefert den Entry
        public Entry SkipXBackward(Entry e, int distance)
        {

            for (int i = 0; i < distance; i++)
            {
               e = e.Prev;
            }
            return e;
        }


        // Soll einmal alles anzeigen ...
        public void ShowValues()
        {
                Console.WriteLine("Aktueller Wert: "+current.Value);          
        }


        // inner class = eine Klasse in einer Klasse
        public class Entry
        {
            public char Value { get; set; }
            public Entry Next { get; set; }
            public Entry Prev { get; set; }
        }  // ende Entry
    }
}
