public class ArrayBasic
{
    public void ArrayBubbleSort(int[] arr)
    {
        // เปรียบเทียบค่าที่อยู่ใกล้กันก่อน
        // loop นอกใช้ในการลูปให้ครบทุก index
        Console.WriteLine("Length: " + arr.Length);

        for (int i = 0; i < arr.Length; i++)
        {
            // loop ในใช้ในการลูปเปรียบเทียบทีละ index ให้ครบทีละตัว
            // length -1 ก็เพื่อไม่ให้เกินขอบเขตของ arr กรณีที่ +1
            for (int j = 0; j < (arr.Length - 1); j++)
            {
                // Console.WriteLine($"Round[{i}]:" + arr[j] + $" Compare with Round{j} " + arr[j + 1] + " => " + (arr[j] > arr[j + 1]));
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j]; // สำรองไว้
                    arr[j] = arr[j + 1]; // ให้ช่องที่เอาไปเปรียบเทียบ เท่ากับช่องถัดไป
                    arr[j + 1] = temp;
                }
            }
        }
        Console.WriteLine(" ");
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }

    public void ReverseString(string message)
    {
        // reverse message
        char[] arr = message.ToCharArray();
        char[] newArr = new char[arr.Length];
        Console.WriteLine("length:" + arr.Length);
        for (int i = 1; i <= arr.Length; i++)
        {
            newArr[i - 1] = arr[arr.Length - i];
        }
        Console.WriteLine("Based "+message);
        Console.WriteLine("Reverse " + new string(newArr));
    }

    public void FindLargestAndSmall(int[] arr)
    {
        // หาจำนวนมากสุดน้อยสุดใน array
        if (arr == null || arr.Length == 0)
        {
            Console.WriteLine("Array is empty.");
            return;
        }

        int max = arr[0] , min = arr[0];
        for(int i = 1 ; i < arr.Length ; i++){
            if(arr[i] > max) max = arr[i];
            if(arr[i] < min) min = arr[i];
        }
        Console.Write($"MAX: {max} , MIN: {min}");
    }
}
