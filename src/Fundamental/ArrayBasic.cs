public class ArrayBasic
{
    public void ArraySorting(int[] arr)
    {
        Array.Sort(arr);
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }

    public void ReverseString(string message)
    {
        Char[] arr = message.ToCharArray();
        Array.Reverse(arr);
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }

    public void FindLargestAndSmall(int[] arrNumbers)
    {
        int max = arrNumbers.Max();
        int min = arrNumbers.Min();

        Console.WriteLine("max " + max);
        Console.WriteLine("max " + min);
    }
}
 