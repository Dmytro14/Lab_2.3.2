using System;

namespace Lab2._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть n");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Random rand = new Random();
            for (int i = 0; i < a.Length; i++)
                a[i] = rand.Next(-100, 100);
            int num = 0; // кількість нульових елементів
            for (int i = 0; i < n; ++i)
                if (a[i] == 0)
                {
                    ++num;
                }
            Console.WriteLine("Кiлькiсть нульових елементiв = " + num);

            int maxPosition = 0;
            int maxNum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int temp = a[i];
                if (a[i] < 0)
                    temp = a[i] * (-1);
                if (temp > maxNum)
                {
                    maxNum = temp;
                    maxPosition = i;
                }

            }
            int answer = 1;
            for (int j = maxPosition + 1; j < a.Length; j++)
                answer = answer * a[j];
            Console.WriteLine(" Добуток елементiв, пiсля максимального за модулем " + answer);
        }
    }
}
