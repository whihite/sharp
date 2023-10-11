using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            zadacha_1();
            zadacha_2();
            zadacha_3();
            zadacha_4();
            zadacha_5();
            zadacha_6(); 
            zadacha_7();
            zadacha_8();
            zadacha_9();
            zadacha_10();
        }
        public static void zadacha_1()
        {
            Console.WriteLine("Задача 1:Введите число");
            int A;
            bool zashita = Int32.TryParse(Console.ReadLine(), out A);
            while (!zashita)
                zashita = Int32.TryParse(Console.ReadLine(), out A);
                if (!zashita)
                    Console.WriteLine("Некорректный ввод. Попробуйте снова.");
            if (A % 3 == 0)
                Console.WriteLine("число делится на 3");
            else
                Console.WriteLine("число не делится на 3");

            Console.ReadKey();

        }
        public static void zadacha_2()
        {
            Console.WriteLine("Задача 2:Введите число: ");
            int A;
            bool check = Int32.TryParse(Console.ReadLine(), out A);
            if (check)
                if (A % 5 == 2 && A % 7 == 1)
                    Console.WriteLine("Число подходит критериям.");
                else
                    Console.WriteLine("Число не подходит критериям.");
            else
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
        }
        public static void zadacha_3()
        {
            Console.WriteLine("Задача 3:Введите число");
            int A;
            bool zashita = Int32.TryParse(Console.ReadLine(), out A);
            while (!zashita)
                zashita = Int32.TryParse(Console.ReadLine(), out A);
                if (!zashita)
                    Console.WriteLine("Некорректный ввод. Попробуйте снова.");
            if (A % 4 == 0 && A >= 10)
                Console.WriteLine("Число проходит по критериям");
            else
                Console.WriteLine("Число не проходит по критериям");

        }
        public static void zadacha_4()
        {
            Console.WriteLine("Задача 4:Введите целое число от 5 до 10");
            int A;
            bool zashita = Int32.TryParse(Console.ReadLine(), out A);
            while (!zashita)
                zashita = Int32.TryParse(Console.ReadLine(), out A);
            if (!zashita)
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
            if (A >= 5 && A <= 10)
                Console.WriteLine("Число входит в диапазон.");
            else
                Console.WriteLine("Число не входит в диапазон.");
        }
        public static void zadacha_5()
        {
            Console.WriteLine("Задача 5:Введите число от 1000 и до 10000");
            int A;
            bool zashita = Int32.TryParse(Console.ReadLine(), out A);
            while (!zashita)
                zashita = Int32.TryParse(Console.ReadLine(), out A);
            if (!zashita)
                Console.WriteLine("Некорректный ввод. Попробуйте снова.");
            int rezValue = A / 1000 % 10;
            Console.WriteLine("В числе " + A + "\nтысяч = " + rezValue);
        }
        public static void zadacha_6()
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());
            string chve = Convert.ToString(number, 8);
            if (chve.Length >= 2)
            {
                char second_right = chve[chve.Length - 2];
                Console.WriteLine("Вторая справа цифра в восьмеричной системе: " + second_right);
            }
            else
            {
                Console.WriteLine("Введенное число имеет меньше двух цифр в восьмеричной системе");
            } 
        }
        public static void zadacha_7()
        {
            Console.Write("Задача 7:Введите число: ");
            int A = int.Parse(Console.ReadLine());
            int pobit = A >> 2;
            int third_bit = pobit & 1;
            Console.WriteLine("Третий бит справа: " + third_bit);
        }
        public static void zadacha_8()
        {
            Console.WriteLine("Задача 8: Введите число:");
            int A = int.Parse(Console.ReadLine());
            int binar = SetThirdBitToOne(A);
            Console.WriteLine($"Число с установленным третьим битом: {binar}");

            Console.ReadLine();
        

            static int SetThirdBitToOne(int A)
            {
            int mask = 1 << 2;
            int result = A | mask;
            return result;

            }
        }
        public static void zadacha_9() 
        {
            Console.WriteLine("Задача 9:Введите число:");
            int A = int.Parse(Console.ReadLine());
            int binar = SetFourthBitToZero(A);
            Console.WriteLine($"Число с четвертым битом, установленным в нуль: {binar}");
            Console.ReadLine();
        

            static int SetFourthBitToZero(int A)
            {
                int Mask = ~(1 << 3);
                int result = A & Mask;
                return result;
            }

        }
        public static void zadacha_10() 
        {
        
        }
    }
}