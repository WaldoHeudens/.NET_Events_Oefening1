using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Oefening1
{
    internal class Stapel<T>
    {
        // Definieer een event gebaseeerd op de delegate ToonVolgende (in FormEvents.cs)
        public event ToonVolgende StapelIsGewijzigd;

        // Definieer een tussenmethode die het event trigert als er methoden aan het event werden toegevoegd
        // We geven ook een parameter mee die aangeleverd zal worden aan de lijst van eventueel toegekende gedelegeerde methoden
        void AlsStapelIsGewijzigd(string boodschap = "")
        {
            if (StapelIsGewijzigd != null)
                StapelIsGewijzigd(boodschap);
        }


        // Hergebruik grootendeels de Stapel-class uit een vorige oefening/taak
        List<T> stapel = new List<T>();

        public void Toevoegen(T toeTeVoegen)
        {
            stapel.Add(toeTeVoegen);
            
            // Triger het event met een gepaste string
            AlsStapelIsGewijzigd("Volgende element werd toegevoegd: ");
        }


        public void Verwijderen()
        {
            if (stapel.Count > 0)
            {
                T even = stapel[stapel.Count - 1];
                stapel.RemoveAt(stapel.Count - 1);
                
                // Trigger het event met een gepaste string
                AlsStapelIsGewijzigd("[" + even.ToString() + "] " + "werd Verwijderd.  Volgende element is ");
            }
        }

        public void Leegmaken()
        {
            stapel.Clear();
            
            // Trigger het event.  In dit geval zonder parameter
            AlsStapelIsGewijzigd();
        }

        public bool isAanwezig(T element)
        {
            // return stapel.Contains(element);
            string elementString = element.ToString();
            bool isAanwezig = false;
            foreach (T item in stapel)
            { 
                isAanwezig = item.ToString() == elementString;
                if (isAanwezig)
                    break;
            }
            return isAanwezig;
         }


        public List<T> Copy()
        {
            T[] newStapel = new T[stapel.Count];
            stapel.CopyTo(newStapel);
            return newStapel.ToList();
        }
        
        // Een methode die aan Stapel werd toegevoegd om de inhoud van het volgende element te tonen
        // zonder dit van de stapel af te halen
        public string ToonVolgende()
        {
            return stapel.Count > 0 ? stapel[stapel.Count - 1].ToString() : "Stapel is leeg";
        }

        public override string ToString()
        {
            string content = "";
            foreach (T t in stapel)
                content += t.ToString() + "; ";
            return content;
        }
    }
}
