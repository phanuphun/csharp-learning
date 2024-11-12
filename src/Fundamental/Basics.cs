using System.Globalization;

public class Basic
{
    public void HelloWorld(string text)
    {
        Console.WriteLine(text);
    }

    public void OddOrEvenChecker(int num)
    {
        if (num / 2 == 0)
        {
            Console.WriteLine(num + " is Even number");
        }
        else
        {
            Console.WriteLine(num + " is Odd number");
        }
    }

    public void SumOfNumbers(int n1, int n2)
    {
        Console.WriteLine("total: " + (n1 + n2));
    }

    public void MultiplicationTable(int number)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(number + " x " + i + " = " + (number * i));
        }
    }

    public void FactorialCalculation(int facNum)
    {
        long sum = 1;
        if (facNum == 0) Console.WriteLine(facNum + "! = " + 1);
        else{
            for (int i = 1; i <= facNum; i++)
            {
                sum *= i;
            }
            Console.WriteLine(facNum + "! = " + sum);
        }
    }

    public void SimpleCalculation(double num1, string optSymbol, double num2)
    {
        double result = 0;
        if (optSymbol == "+") result = num1 + num2;
        else if (optSymbol == "-") result = num1 - num2;
        else if (optSymbol == "*") result = num1 * num2;
        else if (optSymbol == "/") result = num1 / num2;
        else
        {
            Console.WriteLine("Your operator symbol incorect!");
        }

        Console.WriteLine(num1 + " " + optSymbol + " " + num2 + " = " + Math.Round(result, 3));
    }

    public void FindTheLagestNumber(int n1, int n2, int n3)
    {
        int largest = n1;
        if (largest < n2) largest = n2;
        if (largest < n3) largest = n3;
        Console.WriteLine(largest);
    }

    public void PalindromeChecker(string text)
    {
        // รับข้อความมาแล้วหากเขียนกลับหลังแล้วยังอ่านได้เหมือนเดิมถือว่าเป็น Palindrome
        // civic : civic => palindrpme
        // yello : olley => not palindrome

        Char[] arr = text.ToCharArray();
        Array.Reverse(arr);
        if (new String(arr) == text)
        {
            Console.WriteLine(text + " is Palindrme");
        }
        else
        {
            Console.WriteLine(text + " is not Palindrme");
        }
    }

    public void FibonacciSequen(int n)
    {
        // ลำดับเลขของแต่ละตำแหน่งจะต้องนำ ผลลัพธ์ ของตัวเลขที่เกิดจากการบวกกัน 2 ตัวเลขก่อนหน้า
        // โดยลำดับเริ่มต้นตำแหน่งที่ 1 = 0 กับตำแหน่ง 2 = 1 จากนั้นตำแหน่งต่อๆไปใช้สมการ F(n)=F(n−1)+F(n−2)
        // F(3) = F(3-1) + F(3-2)
        // n = 6 => 0, 1, 1, 2, 3, 5

        int first = 0, second = 1;
        List<int> arr = new List<int>();
        arr.Add(first);
        arr.Add(second);
        for (int i = 2; i < n; i++)
        {
            int sum = first + second;

            arr.Add(sum);

            first = second;
            second = sum;
        }

        foreach (int i in arr)
        {
            Console.Write(i + ", ");
        }
    }

    public void PrimeNumberChecker()
    {
        // จำนวนที่มีแค่ ตัวมันเอง กับ 1 ที่หารลงตัวเท่านั้น
        // ใช้ math.sqrt(num) เพื่อลดจำนวนลูป **แต่ไม่เข้าใจว่าทำไม
        // (e.g. 2, 3, 5, 7, 11)
        Console.Write("Enter your number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;
        if (num < 2) Console.WriteLine("prime number is start 2");
        else
        {
            for (int i = 2; i < num; i++)
            {
                // Console.WriteLine(i + ": " + i + " % " + num + "= " + (num % i));
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime) Console.WriteLine(num + " is prime number");
            else Console.WriteLine(num + " is not prime number");
        }
    }
}