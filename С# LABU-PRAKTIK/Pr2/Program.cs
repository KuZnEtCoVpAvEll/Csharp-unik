//zavdania 1
/*
using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Введіть три цілі числа:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());

        int[] numbers = { num1, num2, num3 };
        Console.WriteLine("Числа, які належать інтервалу [1, 27]:");
        for (int i = 0; i < numbers.Length; i++)
        {
            int lastDigit = i + 1;
            if (IsInRange(numbers[i]) && lastDigit >= 1 && lastDigit <= 27)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }

    static bool IsInRange(int num)
    {
        return num >= 1 && num <= 27;
    }
}
*/

//zavdania 2
/*
using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Введіть довжини сторін трикутника:");
        Console.Write("Сторона а: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Сторона b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Сторона c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (IsTriangleValid(a, b, c))
        {
            double perimeter = CalculatePerimeter(a, b, c);
            double area = CalculateArea(a, b, c);
            Console.WriteLine($"Периметр трикутника: {perimeter}");
            Console.WriteLine($"Площа трикутника: {area}");

            string triangleType = DetermineTriangleType(a, b, c);
            Console.WriteLine($"Трикутник є {triangleType}.");
        }
        else
        {
            Console.WriteLine("Трикутник з такими сторонами не існує.");
        }
    }

    static bool IsTriangleValid(double a, double b, double c)
    {
        return a + b >= c && a + c >= b && b + c >= a;
    }

    static double CalculatePerimeter(double a, double b, double c)
    {
        return a + b + c;
    }

    static double CalculateArea(double a, double b, double c)
    {
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s + a) * (s + b) * (s + c));
    }

    static string DetermineTriangleType(double a, double b, double c)
    {
        if (a == b && b == c)
            return "рівносторонній";
        else if (a == b || a == c || b == c)
            return "рівнобедрений";
        else
            return "різносторонній";
    }
}
*/


//zavadnia3
/*
using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        int n = 10 + 7;

        int[] X = new int[n];
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            X[i] = random.Next(1, 100);
        }

        int min = X[0];
        int max = X[0];
        for (int i = 1; i < n; i++)
        {
            if (X[i] < min)
            {
                min = X[i];
            }
            else if (X[i] > max)
            {
                max = X[i];
            }
        }

        Console.WriteLine("Масив X:");
        foreach (int num in X)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine($"\nМінімальне значення: {min}");
        Console.WriteLine($"Максимальне значення: {max}");
    }
}
*/

//zavdania4
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        int N = 7;
        int M = 15;

        int[] X = new int[10 + N];

        Random random = new Random();
        for (int i = 0; i < X.Length; i++)
        {
            int randomNum = random.Next(-50, 51);
            X[i] = randomNum;
        }

        Console.WriteLine("Масив X:");
        PrintArray(X);

        int[] Y = GetElementsGreaterThanM(X, M);

        Console.WriteLine($"\nЧисло M: {M}");
        Console.WriteLine("Масив Y (елементи з X більші за модулем числа M):");
        PrintArray(Y);
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static int[] GetElementsGreaterThanM(int[] arr, int M)
    {
        int count = 0;
        foreach (int num in arr)
        {
            if (Math.Abs(num) > M)
            {
                count++;
            }
        }

        int[] result = new int[count];
        int index = 0;
        foreach (int num in arr)
        {
            if (Math.Abs(num) > M)
            {
                result[index] = num;
                index++;
            }
        }

        return result;
    }
}
*/


