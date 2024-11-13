# C# Learning
This repository stores my C# learning files, including problem-solving exercises, experiments with new techniques, and my personal notes.

## Table of contents
- [Basics](#Input and Output)

## Basics
```csharp
dotnet --version // check version .net sdk
dotnet new console -o <projectName> // creat console project
dotnet run // start project
```

### Input and Output

```csharp
var input = Console.ReadLine();
Console.Write(input + "Hello");  
Console.WriteLine($"{input} Hello");  
```

### Variables

```csharp
const var staticName = "phanuphun" 
var name = "john"; // compiler will infer the type on value assigned value

int num = 25; // 4 bytes
long numling = 222; // 8 bytes
float pi = 3.14; // 4 byptes
double temp = 3.1235; // 8 bytes

string name = "Alice";
char letter = 'A';
bool isTrue = false;

int num1 = 90, num2=99 , num3=109;  
```

### Nullable Type
```csharp
// use ? for allow variable can be null
int? nullableInt = null;
nullableInt = 10;

// nullable type property
nullableInt.Value; // => 10
nullableInt.HasValue; // => true
nullableInt = null;
nullableInt.HasValue; // => false

//example use with try catch
try{
    int? nullableInt = null;

    // if you try to access variable , InvalidOperationException err will trigger 
    Console.WriteLine(nullableInt.Value); 
}catch(InvalidOperationException err){
    Console.WriteLine("Err :" + err);
}

```
### Char and String Methods
```csharp
// string method
string msg = "Hello";
msg[0]; // => 'H'
msg.ToUpper(); // => "HELLO"
msg.ToLower(); // => "hello"
msg.Trim(); 
msg.Contains("Hel")  
msg.StartsWith("He")  
msg.EndsWith("lo") 

// trick use contain checking letter
char letter = 'a'; 
("aeiou").Contains(letter); // => true 

// char method , return true and false
Char.isLetter('a');  
Char.IsUpper('A');  
Char.IsLower('A');  
Char.IsDigit('2');
Char.IsWhiteSpace(' ');
```

### Type Casting
```csharp
double pi = 3.14; 
int piInt = (int)pi; // => 3

// Convert Method
Convert.ToString();  
Convert.ToInt32(); // to int
Convert.ToInt64(); // to long
Convert.ToDouble();  

int price = Convert.ToInt32(ReadLind()); // convert string => int
```

### Math
```csharp
Math.Round(3.1568, 3); // => 3.157
Math.Pow(2,3); // 2^3 => 8
Math.Sqrt(81); // => 9
Math.Abs(-10); // => 10
```

## Array
### Static Array
```csharp
int[] arrNum; // unknow size
arrNum = new int[] {2,5,4,9}; // add values

string[] arrName = new string[4]; // defind size

int[] arrNums = {1,2,3,4,5}; //  define the variable with {}

// static method
Array.Reverse(arrNums); // => [5,4,3,2,1]
Array.Sort(arrNum); => // => [2,4,5,9] 
Array.IndexOf(arrNums,5); // => index 0
Array.Fill(arrNums); // => [10,10,10,10,10]
Array.Exists(arrNums, n => n == 3) // true
Array.Clear();
```

### Dynamic Array
```csharp
List<T> arr = new List<T>();
List<T> arr2 = new List<T> {2,5,8,66,7}; 

// instant method
arr.Add(value); // add new value
arr.Remove(Value); // delete by using value
arr.RemoveAt(Index); // delete by using index 
arr.Reverse(); // reverse value aligment in arr
arr.Contains(value); // check value in arr => true / false
arr.IndexOf(value); // finding value index
arr.Clear(); // delete all values
```

### Array Conversion
```csharp
// string => char[]
string msg = "hello";
char[] arrMsg = msg.ToCharArray(); // => ['h','e','l','l',o]

// char[] => string
char arrVowels = {'a','e','i','o','u'};
string vowels = new string(arrVowels); // => "aeiou"

// arr => list
int[] arr = { 1, 2, 3, 4, 5 };
List<int> list = arr.ToList(); 
```