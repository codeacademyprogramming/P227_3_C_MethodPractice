using System;

namespace Homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[] { 45, 2, 2, 21,2,3};

            int myNumber = 55;
            var result = Sum(myNumber, 10);

            ShowHello();

            AglimaBirSeyGelmir(new int[] { 1, 2,2, 3 ,2,54});
            AglimaBirSeyGelmir(numbers);

            var sumDigits = SumOfDigits(459);

            Console.WriteLine($"Reqemlerin cemi {sumDigits} beraberdir");

            var wantedIndex = FindIndex(numbers, 20);

            Console.WriteLine(wantedIndex);
            var biggest = FindBiggest(5,5,3);
            Console.WriteLine(biggest);

            Console.WriteLine(FindNumberCount(numbers,1));

            int avg = CalcAvgPoint(new int[] { 45, 80, 43, 10, 5, 3, 100 });


            Console.WriteLine("Qiymetlerin sayini daxil edin:");
            string pointsCountStr = Console.ReadLine();
            int pointCount = Convert.ToInt32(pointsCountStr);

            int[] points = new int[pointCount];

            for (int i = 0;i< points.Length; i++)
            {
                Console.WriteLine($"{i+1}. Qiymet daxil edin");
                string pointStr = Console.ReadLine();

                points[i] = Convert.ToInt32(pointStr);
            }

            Console.WriteLine($"Qiymetlerin ortalamasi: {CalcAvgPoint(points)}");

            string[] names = { "Hikmet", "Abbas", "Ayten", "Gulnaz" };
            string name = "Abbas";

            Console.WriteLine(HasName(names,"Nazli"));
        }

        static void ShowHello()
        {
            Console.WriteLine("Hello, World!");

            var result = Sum(45, 10);
            Console.WriteLine(result);
        }


        static int Sum(int num1, int num2)
        {
            int sum = num1 + num2;

            return sum;
        }

        static bool IsEven(int number)
        {
            bool check = number % 2 == 0;

            return check;
        }

        static int Biggest(int num1,int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine(num1);
                return num1;
            }
            else
                return num2;
        }

        static void AglimaBirSeyGelmir(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        //Verilmiş ədədin rəqəmləri cəmini tapıb qaytaran  metod

        static int SumOfDigits(int num)
        {
            int sum = 0;

            int lastDigit;

            while (num!=0)
            {
                lastDigit = num % 10;
                sum += lastDigit;
                num = (num - lastDigit) / 10;
            }

            return sum;
        }


        //Verilmiş interger arrayində verilmiş integer ədədinin yerləşdiyi ilk indexi
        //tapıb qaytaran metod.Əgər tapmasa -1 qaytarsın

        static int FindIndex(int[] numbers,int num)
        {
            int index = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] == num)
                {
                    index = i;
                    break;
                    //return i;
                }
            }

            return index;
        }

        //Verilmiş 3 ədədən ən böyüyünü qaytaran metod
        static int FindBiggest(int num1,int num2,int num3)
        {
            if (num1 >= num2 && num1 >= num3)
                return num1;
            else if (num2 >= num1 && num2 >= num3)
                return num2;
            else
                return num3;
        }

        //Verilmis ededler siyahisindaki verilmis n ededin sayini tapan metod

        static int FindNumberCount(int[] numbers,int n)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] == n)
                {
                    count++;
                }
            }

            return count;
        }

        //Verilmis qiymetlerin ortalamasini hesablayan qaytaran metod

        static int CalcAvgPoint(int[] points)
        {
            int sum = 0;
            int avg = 0;
            for (int i = 0; i < points.Length; i++)
            {
                sum += points[i];
            }

            if(points.Length>0)
                avg = sum / points.Length;

            return avg;
        }

        //Verilmis adlar siyahisinda axtarilan adin olub 
        //olmadigini tapan bir metod

        static bool HasName(string[] names,string wantedName)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == wantedName)
                    return true;
            }
            return false;
        }
    }
}
