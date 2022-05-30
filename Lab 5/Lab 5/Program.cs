using System;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №5 “Преобразование чисел” выполнена Горьковым Алексеем");

            String num1 = "FA089";
            String num2 = "D1234089";

            Console.WriteLine($"{num1} = {Convert.ToInt32(num1, 16)} = {Convert.ToString(Convert.ToInt32(num1, 16), 2)}");
            Console.WriteLine($"{num2} = {Convert.ToInt32(num2, 16)} = {Convert.ToString(Convert.ToInt32(num2, 16), 2)}");

        }
    }
}
