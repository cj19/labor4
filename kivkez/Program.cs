using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kivkez
{
    class Program
    {
        static int eredmeny;

        static int osztas(int oszto, int osztando)
        {
            if(oszto == 0)
            {
                return -1; // hiba jelzése
            } else
            {
                return osztando / oszto;
            }
        }

        static int osztas2(int oszto, int osztando)
        {
            if (oszto == 0)
            {
                return -1;
            } else
            {
                eredmeny = osztando / oszto;
                return 0;
            }
        }

        static int osztas3(int oszto, int osztando)
        {
            return osztando / oszto;
        }
        static void Main(string[] args)
        {
            try { 
            osztas3(0, 10);
        } catch (Exception)
            {
                Console.WriteLine("Hiba van!");
            }
        }
    }
}
