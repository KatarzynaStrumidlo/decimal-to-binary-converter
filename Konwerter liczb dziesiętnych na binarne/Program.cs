using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konwerter_liczb_dziesiętnych_na_binarne
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int n, i;
                int[] a = new int[10];
                Console.Write("Enter the number to convert: ");
                n = int.Parse(Console.ReadLine());
                for (i = 0; n > 0; i++)
                {
                    a[i] = n % 2;
                    n = n / 2;
                }
                Console.Write("Binary of the given number= ");
                for (i = i - 1; i >= 0; i--)
                {
                    Console.Write(a[i]);
                }
                Console.ReadLine(); 
            



                //        int userNum = Convert.ToInt32(Console.ReadLine());
                //        int value = 2;
                //        int involutionResult = 0;
                //        int[] numbers = new int[];
                //        for (int power = 0; power <= userNum; power++)
                //        {
                //            involutionResult = (int)(long)Math.Pow(value, power); //kolejne potęgi liczby 2 zaczynając od 2^0
                //            numbers[power] = involutionResult;

                //            if (involutionResult >= userNum)
                //            {
                //                break;
                //            }
                //        }
                //        int[] numbersCopy = numbers;
                //        Array.Reverse(numbers);
                //        foreach(int number in numbers)
                //        {
                //            Console.WriteLine(number);
                //        }

                //        Console.ReadKey();
            }
    }
}
