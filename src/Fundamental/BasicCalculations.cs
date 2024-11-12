using System.Globalization;

public class BasicCalculations
{
    public void FactorialCalculation(int facNum)
    {
        // Factorial
        // 5! = 5 x 4 x 3 x 2 x 1 = ? 
        long sum = 1;
        if (facNum == 0) Console.WriteLine(facNum + "! = " + 1);
        else
        {
            for (int i = 1; i <= facNum; i++)
            {
                sum *= i;
            }
            Console.WriteLine(facNum + "! = " + sum);
        }
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
            Console.WriteLine(text + " is Parindrome");
        }
        else
        {
            Console.WriteLine(text + " is not Parindrome");
        }
    }

    public void FibonacciSequen(int n)
    {
        // ลำดับเลขของแต่ละตำแหน่งจะต้องนำ ผลลัพธ์ ของตัวเลขที่เกิดจากการบวกกัน 2 ตัวเลขก่อนหน้า
        // โดยลำดับเริ่มต้นตำแหน่งที่ 1 = 0 กับตำแหน่ง 2 = 1 จากนั้นตำแหน่งต่อๆไปใช้สมการ F(n)=F(n−1)+F(n−2)
        // F(3) = F(3-1) + F(3-2)
        // n = 6 => 0, 1, 1, 2, 3, 5
        int first = 0, second = 1;
        List<int> arr = [first, second];
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