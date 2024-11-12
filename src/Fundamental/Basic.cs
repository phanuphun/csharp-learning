public class Basic 
{
    public void MultiplicationTable(int number)
    {
        // แม่สูตรคูณ
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(number + " x " + i + " = " + (number * i));
        }
    }

    public void SimpleCalculation(double num1, string optSymbol, double num2)
    {
        // คำนวณเครื่องหมาย 2 / 6 , 2 + 5
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
        // หาค่ามากที่สุด
        int largest = n1;
        if (largest < n2) largest = n2;
        if (largest < n3) largest = n3;
        Console.WriteLine(largest);
    }
}