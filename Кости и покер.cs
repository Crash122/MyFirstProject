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
            string[] comb = new string[5];
            string strongest = "Наивысшее очко";
            int y = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int s = 0; s < a.Length; s++)
                { 
                    if (s != i)
                    {
                        y = 0;
                       
                        
                       
                        if (a[i] == a[s] && comb[i] == "Каре" && y != 1)
                        {
                            comb[i] = "Покер";
                            strongest = "Покер";
                            y = 1;
                            break;
                        }
                        else if (a[i] == a[s] && comb[i] == "Тройка" && y != 1)
                        {
                            comb[i] = "Каре";
                            strongest = "Каре";
                            y = 1;
                        }

                       else if (a[i] == a[s] && comb[i] == "Пара" && y != 1)
                        {
                            comb[i] = "Тройка";
                            strongest = "Тройка";
                            y = 1;
                        }
                       
                       else if (a[i] == a[s])
                        {
                            comb[i] = "Пара";
                            strongest = "Пара";
                            y = 1;
                        }
                    }


                }
                if (comb[i] == "Покер")
                { break;  }
            }
            int pair = 0;
            int house = 0;
            if (strongest != "Покер" || strongest != "Каре")
            {
                for (int i = 0; i < comb.Length; i++)
                {
                    if (comb[i] == "Пара")
                    {
                        pair = pair + 1;
                        house = house + 1;
                    }
                    if (comb[i] == "Тройка")
                    {
                        house = house + 1;

                    }
                    if (house == 5)
                    { strongest = "Фулл Хаус"; }
                    else if (pair == 4 && strongest != "Тройка")
                    { strongest = "Две пары"; }
                }
            }
            return strongest;
        }
    }
}
