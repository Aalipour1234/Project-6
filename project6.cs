﻿using System;

namespace InsertElement
{
    class Program
    {
        static void Main(string[] args)
        {
            // تعریف آرایه اولیه
            int[] array = { 1, 2, 3, 4, 5 };

            // نمایش آرایه اولیه
            Console.WriteLine("First Arry:");
            PrintArray(array);

            // گرفتن اطلاعات از کاربر
            Console.WriteLine("\nEnter element number:");
            int element = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter position number(0 to 4) " + array.Length + "):");
            int position = int.Parse(Console.ReadLine());

            // درج عنصر در آرایه
            array = InsertElement(array, element, position);

            // نمایش آرایه نهایی
            Console.WriteLine("\nsecond Array:");
            PrintArray(array);
        }

        // متد برای درج عنصر در یک موقعیت خاص
        static int[] InsertElement(int[] array, int element, int position)
        {
            // بررسی موقعیت معتبر
            if (position < 0 || position > array.Length)
            {
                Console.WriteLine("invalid position.");
                return array;
            }

            // ایجاد آرایه جدید با یک خانه بیشتر
            int[] newArray = new int[array.Length + 1];

            // کپی عناصر قبل از موقعیت
            for (int i = 0; i < position; i++)
            {
                newArray[i] = array[i];
            }

            // درج عنصر جدید
            newArray[position] = element;

            // کپی عناصر بعد از موقعیت
            for (int i = position; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }

            return newArray;
        }

        // متد برای چاپ آرایه
        static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }
    }
}