using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kivkez2
{
    class Program
    {
        static void tombKezeles()
        {
            Console.WriteLine("Add meg a tömb méretét: ");
            int[] tomb = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(">érték:");
                tomb[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Melyik elem érdekel?");
            Console.WriteLine(tomb[int.Parse(Console.ReadLine())]);
        }
        static void Main(string[] args)
        {
            try
            {
                tombKezeles();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index hiba!");
            }
            catch(FormatException)
            {
                Console.WriteLine("Formai hiba van!");
            }
            catch (Exception)
            {
                Console.WriteLine("Hiba van!");
            }
            finally
            {
                Console.WriteLine("End of story.");
            }
            Console.ReadLine();
        }
    }
}
