using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kivkez4
{
    class SajatKivetel : Exception
    {
        private string hibaUzenet { get; set; }

        public SajatKivetel(string message)
        {
            this.hibaUzenet = message;
        }

    }

    class KiindexelesKivetel : SajatKivetel
    {
        private string v;

        private int kiindexelesHelyes { get; set; }
        public static string message { get; private set; }

        public KiindexelesKivetel(int kiindexeles, string message) : base(message)
        {
            this.kiindexelesHelyes = kiindexeles;
        }
    }


    class TeleTombKivetel : SajatKivetel
    {
        private static string message { get; set; }

        private int[] melyikTombrolVanSzo { get; set; }
        public TeleTombKivetel(int[] melyikTömb, string message) : base(message)
        {
            this.melyikTombrolVanSzo = melyikTömb;
        }
    }
    class Tombkezelo
    {
        private int tombIndex;
        private int[] tomb;
        private int tombMeret;

        public int TombMeret
        {
            get { return tombMeret; }
        }

        public Tombkezelo(int meret)
        {
            this.tombMeret = meret;
            tomb = new int[meret];
            tombIndex = 0;
        }

        public int getTombElem(int index)
        {
            if (index > tomb.Length || index < 0)
            {
                throw new KiindexelesKivetel(index, "Hiba keletkezett");
            }
            else
            {
                return tomb[index];
            }
        }

        public void addTombElem(int elem)
        {
            if(tombIndex >= tomb.Length)
            {
                throw new TeleTombKivetel(tomb, "Tele a tömb!");
            } else
            {
                tomb[tombIndex++] = elem;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
