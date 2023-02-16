using System;
using System.Collections.Generic;
using System.Text;

namespace Sorts
{
    class MenuTask
    {
        private static int n = 0;
        private static int[] arr;
        public static void Menu(ref int num)
        {
            Console.WriteLine("1 - Создать массив");
            Console.WriteLine("2 - Вывести элементы массива");
            Console.WriteLine("3 - Сортировка выбором");
            Console.WriteLine("4 - Пирамидальная сортировка");
            Console.WriteLine("5 - Сортировка «Пузырьком»");
            Console.WriteLine("6 - Шейкер сортировка");
            Console.WriteLine("7 - Поменять два элемента местами");
            Console.WriteLine("8 - Выход");
            Console.WriteLine("Введите номер от 1 до 8:");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (num)
            {
                case 1:
                    Console.WriteLine("Введите диапозон массива:");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    CreateArray(ref arr, n);
                    break;
                case 2:
                    Print(ref arr);
                    Console.WriteLine("\n");
                    break;
                case 3:
                    SortChoice(ref arr);
                    Console.WriteLine();
                    break;
                case 4:
                    HeapSort();
                    break;
                case 5:
                    BubbleSort(ref arr);
                    break;
                case 6:
                    ShakerSort(ref arr);
                    break;
                case 7:
                    SwapElements(ref arr);
                    Console.WriteLine();
                    break;
                default:
                    break;
            }
        }
        private static void Print(ref int[] arr)
        {
            Console.WriteLine("Массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        private static void CreateArray(ref int[] arr, int n)
        {
            arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 100);
            }
        }

        private static void SortChoice(ref int[] arr)
        {
            int MinIndex;
            for (int i = 0; i < arr.Length; i++)
            {
                MinIndex = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[MinIndex])
                    {
                        MinIndex = j;
                    }
                }
                if (arr[i] == arr[MinIndex]) continue;


                int temp = arr[i];
                arr[i] = arr[MinIndex];
                arr[MinIndex] = temp;


            }
        }

        private static void HeapSort()
        {
            Console.WriteLine("Не справился с этой сортировкой.");
            Console.WriteLine();
        }

        private static void BubbleSort(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        private static void ShakerSort(ref int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = left; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
                right--;
                for (int i = right; i > 0; i--)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;
                    }
                }
                left++;
            }
        }

        private static void SwapElements(ref int[] arr)
        {
            Console.WriteLine("Введите через пробел два элемента, которые хотите поменять местами: ");
            string elements = Console.ReadLine();
            string[] els = elements.Split(" ");
            int el1 = int.Parse(els[0]);
            int el2 = int.Parse(els[1]);
            int FirstIndex = 0;
            int SecondIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == el1)
                {
                    FirstIndex = i;
                }
                if (arr[i] == el2)
                {
                    SecondIndex = i;
                }
            }
            int temp = arr[FirstIndex];
            arr[FirstIndex] = arr[SecondIndex];
            arr[SecondIndex] = temp;
        }
    }
}
