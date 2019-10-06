using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Бинарный_поиск
{
    class Sort
    {
        static public int[] sort1(int[] array)
        {
            for (int j = 0; j < array.Length  -1; j++)
            {
               for (int i = 0; i < array.Length - 1; i++)
                 {
                     int x;
                    if (array[i] > array[i + 1])
                    {
                        x = array[i]; array[i] = array[i + 1]; array[i + 1] = x;
                    }



               }
            }
            return array;
        }

        static public int binPoisk(int target, int[] array)
        {
            int mid;
            int left = 0;
            int right = array.Length - 1;
            mid = (right + left) / 2;
            while (left < right - 1)
            {
                mid = (right + left) / 2;
                if (array[mid] == target)
                    return mid;
                if (array[mid] < target)
                    left = mid;
                else
                    right = mid;
            }
            if (array[mid] != target)
            {
                if (array[left] == target)
                    mid = left;
                else
                {
                    if (array[right] == target)
                        mid = right;
                    else
                        mid = -1;
                };
            }
            return mid;
        }
        static public void vivod(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
        static public int vvod()
        {
            int k;
            Console.Write("Ведите число элементов массива: ");
            //k = Console.ReadLine();
            
            try 
            { 
               k =  Convert.ToInt32(Console.ReadLine()); 
            }
            //if (Convert.ToInt32(k) == 0) 
           
            catch (System.FormatException)
            {
                Console.WriteLine("Неверный формат данных\n");
                return -1;
            }
            //k = Convert.ToInt32(Console.ReadLine());
            //if (k == -2) Console.WriteLine("Неверный формат данных");
            
            if (k < 0) 
            {
                Console.WriteLine("Отрицательное значение не допустимо\n");
                
                return -1; 
            }
            return k;
        }
    }
}

