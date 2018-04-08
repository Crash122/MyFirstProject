using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        { string a = Console.ReadLine();
            string[] yo = a.Split(' ');
            if (yo.Length == 5)
            {
                
                int[] numbers = new int[5];
                bool wat = false;
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = int.Parse(yo[i]);
                    if (numbers[i] > 6)
                    { wat = true; }
                }
                if (wat != true)
                {
                    Console.WriteLine(Combination(numbers));
                }
                else { Console.WriteLine("Одна из цифр слишком большая для существовании на кости"); }
            }
            else { Console.WriteLine("Недопустимая длина строки"); }
            Console.ReadKey();
        }

        static private string Combination(int[] a)
        {
            bool[] comb1 = new bool[7];
            comb1[0] = Poker(a);
            comb1[1] = Kare(a);
            comb1[2] = FullHouse(a);
            comb1[3] = Triple(a);
            comb1[4] = TwoDouble(a);
            comb1[5] = Double(a);
            comb1[6] = true;
            string[] comb = new string[7];
            string strongest = "Наивысшее очко";
            comb[0] = "Покер";
            comb[1] = "Каре";
            comb[2] = "Фулл Хаус";
            comb[3] = "Тройка";
            comb[4] = "Две пары";
            comb[5] = "Пара";
            comb[6] = "Наивысшее очко";
            for (int i = 0; i < a.Length; i++)
            {
                if (comb1[i] == true)
                {
                    strongest = comb[i];
                    break;
                }
            }
            
            return strongest;
        }
      static private bool Poker (int[] a)
        {
            int y = 0;
            for (int s = 1; s < a.Length; s++)
            {
                int i = 0;
                if (a[i] == a[s])
                {
                    y = y + 1;
                }
            }
            if (y == 4)
            {
                return true;
            }
            return false;
        }
        static private bool Kare(int[] a)
        {
           

            return false;
        }
        static private bool FullHouse(int[] a)
        {
            
            
            if (Double(a) == true && Triple(a) == true)
            {
                return true;
            }
            return false;
        }
       static private bool Triple(int[] a)
        {
           
            return false;
        }
           static private bool TwoDouble(int[] a)
            {
            
            return false;
            }
            static private bool Double(int[] a)
            {
            
            return false;
            }
    }
}
