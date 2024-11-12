using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

public class Intermediate
{
    public void CountVowelsAndConsonants(string message)
    {
        // นับจำนวนสระ , และตัวอักษรพยัญชนะในข้อความ
        // สามารถใช้ .isLetter ได้เพื่อตรวจสอบว่าเป็นตัวอักษรหรือไม่
        // ('aeiou').Contain(); ใช้ตรวจสอบ string ที่มีสระได้ 
        message = message.ToLower();

        char[] arrMessage = message.ToCharArray();

        int vowelsCounting = 0;
        int ConsonantsCounting = 0;
        int anotherCounting = 0;

        char[] vowels = ['a', 'e', 'i', 'O', 'u'];
        char[] Consonants = ['b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z'];

        for (int i = 0; i < message.Length; i++)
        {
            if (vowels.Contains(message[i]))
            {
                vowelsCounting++;
            }
            else if (Consonants.Contains(message[i]))
            {
                ConsonantsCounting++;
            }
            else
            {
                anotherCounting++;
                Console.WriteLine("" + message[i]);
            }
        }
        Console.WriteLine("total Char :" + message.Length);
        Console.WriteLine("vowels :" + vowelsCounting);
        Console.WriteLine("Consonants : " + ConsonantsCounting);
        Console.WriteLine("another : " + anotherCounting);
    }

    public void ArmstrongChecker(int number)
    {
        // เลข 153 มี 3 หลัก
        // ถ้ายกกำลังแต่ละหลัก (1^3 + 5^3 + 3^3) จะได้ 153 ซึ่งเท่ากับตัวเลขเดิม ดังนั้น 153 เป็น Armstrong Number
        // 9474 มี 4 หลัก
        // 9^4 + 4^4 + 7^4 + 4^4 = 6561 + 256 + 2401 + 256 = 9474 ซึ่งเท่ากับตัวเลขเดิม เป็น Armstrong Number

        // ตัวช่วยในการยกกำลัง Math.Pow(unit, numberString.Length)

        string numberString = number.ToString();
        int resultUnit = 1;
        int baseNumber = number;
        List<double> numberUnit = new List<double>();
        for (int i = 0; i < numberString.Length; i++)
        {
            int unit = number % 10;
            for (int j = 0; j < numberString.Length; j++)
            {
                resultUnit *= unit;
            }
            numberUnit.Add(resultUnit);
            resultUnit = 1;
            number = number / 10;
        }
        numberUnit.Reverse();

        int total = 0;
        foreach (var item in numberUnit)
        {
            total += Convert.ToInt32(item);
        }

        Console.WriteLine("input: " + baseNumber);
        Console.WriteLine("output: " + total);

        if (baseNumber == total) Console.WriteLine(baseNumber + " is Armstrong Number");
        else Console.WriteLine(baseNumber + " is not Armstrong Number");
    }

    public void BinaryToDecimal(int base2)
    {
        // รับเลขฐานสองจากผู้ใช้แล้วแปลงเป็นเลขฐานสิบ
        // input => 110111
        // output => 55
        // หลักการ การกระจาย
        // 110111 ฐ2 => (1 * 2^5) + (1 * 2^4) + (0 * 2^3) + (1 * 2^2) + (1 * 2^1) + (1 * 2^0)
        // => (1x32) + (1x16) + (0x8) + (1x4) + (1x2) + (1x1) = 55 ฐ10

        string base2String = base2.ToString();
        Char[] arrBase2 = base2String.ToCharArray();
        Array.Reverse(arrBase2);

        List<double> arrTotal = new List<double>();
        for (int i = 0; i < base2String.Length; i++)
        {
            int baseUnit = Convert.ToInt32(arrBase2[i].ToString()); // char => string => int
            double resultOfUnit = baseUnit * Math.Pow(2, i);
            // Console.WriteLine($"2^{i} x {baseUnit} = {resultOfUnit}");
            arrTotal.Add(resultOfUnit);
        }

        double sum = 0;
        foreach (var item in arrTotal)
        {
            sum += item;
            // Console.Write($"{item} ");
        }
        Console.WriteLine($"{base2} => {sum}");
    }

    public void CaesarCipher()
    {
        // รับข้อความและเลขจำนวนการเลื่อนจากผู้ใช้ แล้วทำการเข้ารหัส Caesar Cipher
    }
}