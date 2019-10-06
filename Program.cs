using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Бинарный_поиск
{
    class Program
    {

        static void Main(string[] args)
        {
            do
            {
                int col = Sort.vvod();
                if (col == -1)
                {
                    Console.WriteLine("Для выхода нажмите q. Для продолжения любую кнопку.");
                    continue;
                }
             
                int[] arr = new int[col];
                Random rnd = new Random();
                for (int i = 0; i < col; i++)
                {
                    arr[i] = rnd.Next(0, 100);
                }

                Console.WriteLine("Исходный массив:");
                Sort.vivod(arr);
                Sort.sort1(arr);
                do
                {
                    Console.WriteLine("\n\n\nОтсортированный массив:");
                    Sort.vivod(arr);
                    Console.Write("Ввести элемент поиска: ");
                    int target = Convert.ToInt32(Console.ReadLine());
                    int k = Sort.binPoisk(target, arr);
                    Console.WriteLine("Бинарный поиск:");
                    if (k > -1)
                        Console.WriteLine("Номер элемента = {0}", k);
                    else
                        Console.WriteLine("нет заданного элемента");

                    Console.WriteLine("Для выхода нажмите q. Для продолжения любую кнопку.");
                }while(Console.ReadLine() != "q");
            } while (Console.ReadLine() != "q");
            
       }
    }
}
