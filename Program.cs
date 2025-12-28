using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // รับค่าจากผู้ใช้
            string inputA = Console.ReadLine();
            string inputB = Console.ReadLine();
            string inputC = Console.ReadLine();
            string inputD = Console.ReadLine();

            int a = int.Parse(inputA);
            int b = int.Parse(inputB);
            int c = int.Parse(inputC);
            int d = int.Parse(inputD);

            // เรียกใช้ฟังก์ชัน
            print_average_result(a, b, c, d);
            print_Maximum_value_result(a, b, c, d);
            print_lowest_value_result(a, b, c, d);
            print_Average_data_result(a, b, c, d);
            print_Descending_result(a, b, c, d);
            print_Ascending_result(a, b, c, d);
        }

        // ค่าเฉลี่ย
        static void print_average_result(int a, int b, int c, int d)
        {
            double average = (a + b + c + d) / 4.0;
            Console.WriteLine("Average: " + average);
        }

        // ค่าสูงสุด
        static void print_Maximum_value_result(int a, int b, int c, int d)
        {
            int max = Math.Max(Math.Max(a, b), Math.Max(c, d));
            Console.WriteLine("Maximum Value: " + max);
        }

        // ค่าต่ำสุด
        static void print_lowest_value_result(int a, int b, int c, int d)
        {
            int min = Math.Min(Math.Min(a, b), Math.Min(c, d));
            Console.WriteLine("Lowest Value: " + min);
        }

        // ค่ากลางข้อมูล (Median)
        static void print_Average_data_result(int a, int b, int c, int d)
        {
            int[] numbers = { a, b, c, d };
            Array.Sort(numbers);

            double median = (numbers[1] + numbers[2]) / 2.0;
            Console.WriteLine("Average Data (Median): " + median);
        }

        // เรียงจากมากไปน้อย
        static void print_Descending_result(int a, int b, int c, int d)
        {
            int[] numbers = { a, b, c, d };
            Array.Sort(numbers);
            Array.Reverse(numbers);

            Console.WriteLine("Descending: " + string.Join(", ", numbers));
        }

        // เรียงจากน้อยไปมาก
        static void print_Ascending_result(int a, int b, int c, int d)
        {
            int[] numbers = { a, b, c, d };
            Array.Sort(numbers);

            Console.WriteLine("Ascending: " + string.Join(", ", numbers));
        }
    }
}
