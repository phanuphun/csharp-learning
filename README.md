# C# Learning

This repository stores my C# learning files, including problem-solving exercises, experiments with new techniques, and my personal notes.

## Table of contents

- [C# Learning](#c-learning)
  - [Table of contents](#table-of-contents)
  - [Basics](#basics)
    - [Input and Output](#input-and-output)
    - [Variables](#variables)
    - [Nullable Type](#nullable-type)
    - [Char and String Methods](#char-and-string-methods)
    - [Type Casting](#type-casting)
    - [Math](#math)
    - [If-else](#if-else)
  - [Array](#array)
    - [Static Array](#static-array)
    - [Dynamic Array](#dynamic-array)
    - [Array Conversion](#array-conversion)
  - [OOP](#oop)
    - [Basic Structure and Encapsulate](#basic-structure-and-encapsulate)
    - [Ineritantce](#ineritantce)
    - [Override](#override)
    - [Abstract](#abstract)
  - [Interface](#interface)

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

### If-else

```csharp
if(condition){}
if(condition){} else{}
if(condition)() else if(condition2){} else{}

// short hand
if (condition) ? statement... : elseStetement... ;
string name = (condition)? "newName" : "defaultName" ; // usage
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

## OOP

### Basic Structure and Encapsulate

```csharp
// Test.cs
class Test
{
   // access modify
   // public : any class can access.
   // private : only within in the same class can access.
   // protected : within in the same class and inheritance class can access.

   public string name { get; set; } // called property by using access modify
   readonly public string oldname ; // called a Field by using "readonly" modify that means you can only be set in constructor

   // Constructure : will call this method when instant create!
   public Test()
   {
      oldname = "Jonathan"; // defind field in structure
      Console.Writeline(oldname);
   }

   public void Test(string newName)
   {
      name = name;
      Console.Writeline(name);
   }
}

// Program.cs
Test testnew = new Test(); // => Jonathan
Test testnew = new Test("Jenny"); // => Jenny
```

### Ineritantce

```csharp
// Parent
class Test
{
   public string name { get; set; }
   readonly public string oldname ;

   public Test(string newName)
   {
      oldname = "Johnny";
      name = newName;
   }

   public int Sum(int n1,int n2)
   {
      return n1+n2;
   }
}
// Child
class TestChild : Test // inheritance Test
{

}

// Program.cs
Test parent = new Test();
parent.Sum(1,5); // => 6

// child class will have every method and properties from parent
TestChild child = new TestChild();
child.Sum(2,6); // => 8  , use method
child.oldname; // => Johnny , access property
```

### Override

```csharp
// Parent
class Test
{
   // use virtual is mean you can override this method in child class
   public virtual int Sum(int n1,int n2)
   {
      return n1+n2;
   }
}

// Child
class TestChild : Test // inheritance Test
{
   // use "override" in child method that you need
   public override int Sum(int n1,int n2)
   {
      return n1+n2+20;
   }
}

// Program.cs
Test parent = new Test();
parent.Sum(5,5); // => 10

TestChild child = new TestChild();
child.Sum(5,5); // => 30
```

### Abstract

```csharp
// Parent
// ** abstact like a "blueprint"
// if want to use "abstract" , class must be abstract too
abstract class Parent
{
   public abstract int doubleSum(int n1,int n2); // create abstract method , no logic here

   public void show(string text){ // non abstract
      Console.WriteLine(text);
   }
}

// ChildOne
class ChildOne : Parent
{
   // override abstract class in child class
   public override int doubleSum(int n1,int n2)
   {
      return (n1+n2)*2 ;
   }
}

// ChildTwo
class ChildTwo : Parent
{
   // *** you must override doubleSum
   // because abstract fource every child use it
    public override int doubleSum(int n1,int n2)
   {
      return 0 ;
   }
}

// Program.cs
Parent parent = new Parent(); // *** you can't create instant from parent class bc this class is a abstract(blueprint)

ChildOne one = new ChildOne();
one.doubleSum(5,5); //=> 20
ChildTwo two = new ChildTwo();
two.doubleSum(5,5); //=> 0
two.show("hello world"); // => hello world
```

## Interface

```csharp
// create interface
// * interface no need to use access modify
// ** interface cant implement login in method
// *** interface can't have property or field
// **** interface only have method for child
// ***** child need to implement yourself
interface Parent
{
   int plusTen(int n1);
   string show(string text);
}

// every child need to implement every method like abstract class
class One:Parent
{
   public int plusTen(int n1)
   {
      return n1+10;
   }

   public show(string text)
   {
      return "one : " + text ;
   }
}

class Two:Parent
{
   public int plusTen(int n1)
   {
      return n1 + 100;
   }

   public show(string text)
   {
      return "two : " + text ;
   }
}

//Program.cs
One one1 = new One();
one1.plusTen(20); // => 30
one1.show("One"); // => one : One

Two two2 = new Two();
two2.plusTen(20); // => 120
two2.show("Two"); // => two : Two
```
