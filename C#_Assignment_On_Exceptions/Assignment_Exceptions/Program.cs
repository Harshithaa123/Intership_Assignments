//Exception 
using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

//public class TempratureIsZeoException : Exception
//{
//    public TempratureIsZeoException(string message) : base(message) { }
//}
//class Temprature
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Enter the Temprature");
//        int temp = Convert.ToInt32(Console.ReadLine());

//        try
//        {
//            if (temp > 0)
//            {
//                Console.WriteLine("The Temprature is " + temp);
//            }
//            else
//            {
//                throw new TempratureIsZeoException("Temprature cannot be Zero");
//            }
//        }
//        catch (TempratureIsZeoException e)
//        {
//            //Console.WriteLine(e.GetType()+" : "+e.StackTrace);
//            Console.WriteLine(e.GetType() + " : " + e.Message);
//        }
//    }
//}

//Generic List
//class Program
//{
//    public static void Main(string[] args)
//    {
//        List<string> list = new List<string>();

//        list.Add("Harshitha");
//        list.Add("Pruthvi");
//        list.Add("Rashmi");
//        list.Add("Lakshmi");


//        Console.WriteLine("\nAccess an elements using an for loop");
//        for (int i = 0; i < list.Count; i++)
//        {
//            Console.WriteLine(list[i]);
//        }

//        Console.WriteLine("\n******************************************************");
//        Console.WriteLine("Access an elements using an foreaach loop");
//        foreach (string s in list)
//        {
//            Console.WriteLine(s);
//        }
//        Console.WriteLine("\n******************************************************");
//        Console.WriteLine("Access an elements through index positions");
//        Console.WriteLine($"First element is :{list[0]}");
//        Console.WriteLine($"Second element is :{list[1]}");
//        Console.WriteLine($"Third element is :{list[2]}");
//        Console.WriteLine($"Fourth element is :{list[0]}");
//    }
//}


//File creation

//class Program
//{
//    static void Main(string[] args)
//    {
//        string path = @"E:\C#Files\sample.txt";

//        FileInfo fileInfo = new FileInfo(path);
//        fileInfo.Create();

//        if (fileInfo.Exists)
//        {
//            Console.WriteLine("File exists.");
//        }
//        else
//        {
//            Console.WriteLine("File does not exist or path is incorrect.");
//        }
//    }
//}

//Reading and writing an file

//class Program
//{
//    public static void Main(string[] args)
//    {
//        string filepath = @"E:\C#Files\sample.txt";
//        File.WriteAllText(filepath, "Hello welcome to C# Programming");

//        Console.WriteLine(File.ReadAllText(filepath));

//        Console.WriteLine("Enter the text you want to store inside a file");
//        string usertext = Console.ReadLine();

//        File.AppendAllText(filepath, usertext + "\n");

//        Console.WriteLine("Displying text present inside a file");
//        Console.WriteLine(File.ReadAllText(filepath));
//    }
//}

//indexcers

class Employee
{
    private string[] details = new string[6];

public string this[int index]
{
    get
    {
        return details[index];
    }
    set
    {
        details[index] = value;
    }
}
}
class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();

        Console.WriteLine("Enter employee details:");
        Console.Write("Employee ID: ");
        emp[0] = Console.ReadLine();

        Console.Write("Name: ");
        emp[1] = Console.ReadLine();

        Console.Write("Job: ");
        emp[2] = Console.ReadLine();

        Console.Write("Salary: ");
        emp[3] = Console.ReadLine();

        Console.Write("Location: ");
        emp[4] = Console.ReadLine();

        Console.Write("Gender: ");
        emp[5] = Console.ReadLine();


        Console.WriteLine($"EID={emp[0]},Name={emp[1]},Job={emp[2]},Salary={emp[3]},Location={emp[4]},Gender={emp[5]}");


        Console.WriteLine("Enter modified employee details:");
        Console.Write("Name: ");
        emp[1] = Console.ReadLine();

        Console.Write("Salary: ");
        emp[3] = Console.ReadLine();

        Console.Write("Location: ");
        emp[4] = Console.ReadLine();


        Console.WriteLine("***After Modification******");
        Console.WriteLine($"EID={emp[0]},Name={emp[1]},Job={emp[2]},Salary={emp[3]},Location={emp[4]},Gender={emp[5]}");
    }
}

//Assignments part 2
// merge two array
//class Program
//{
//    static int[] MergeTwoArray(int[] a, int[] b)
//    {
//        int[] merged_array = new int[a.Length + b.Length];
//        int k = 0;
//        for (int i = 0; i < merged_array.Length; i++)
//        {
//            if (i < a.Length)
//            {
//                merged_array[i] = a[i];
//            }
//            else
//            {
//                merged_array[i] = b[k++];
//            }
//        }
//        Array.Sort(merged_array);
//        return merged_array;
//    }

//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Enter the size of arrays:");
//        int size = int.Parse(Console.ReadLine());

//        int[] arr1 = new int[size];
//        int[] arr2 = new int[size];

//        Console.WriteLine("Enter the first array elements:");
//        for (int i = 0; i < size; i++)
//        {
//            arr1[i] = int.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("Enter the second array elements:");
//        for (int i = 0; i < size; i++)
//        {
//            arr2[i] = int.Parse(Console.ReadLine());
//        }

//        int[] mergedArray = MergeTwoArray(arr1, arr2);
//        Console.WriteLine("Merged Arrays in ascending order:");
//        for (int i = 0; i < mergedArray.Length; i++)
//        {
//            Console.WriteLine(mergedArray[i]);
//        }
//    }
//}

// frequency
//using System.Collections.Generic;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter the size of the array:");
//        int size = int.Parse(Console.ReadLine());

//        int[] arr = new int[size];

//        Console.WriteLine("Enter the array elements:");
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }

//        Dictionary<int, int> frequencyMap = CountFrequency(arr);

//        Console.WriteLine("Element\tFrequency");
//        foreach (var entry in frequencyMap)
//        {
//            Console.WriteLine($"{entry.Key}\t{entry.Value}");
//        }
//    }

//    static Dictionary<int, int> CountFrequency(int[] arr)
//    {
//        Dictionary<int, int> frequencyMap = new Dictionary<int, int>(); //{1,2,1,4,3,2}

//        foreach (int num in arr)
//        {
//            if (frequencyMap.ContainsKey(num))
//            {
//                frequencyMap[num]++;
//            }
//            else
//            {
//                frequencyMap[num] = 1;
//            }
//        }

//        return frequencyMap;
//    }
//}

//electricity bill

//class Program
//{
//    static void Main(string[] args)
//    {
//        const double per_unit = 6.50;

//        Console.WriteLine("Enter customer's name:");
//        string customerName = Console.ReadLine();

//        Console.WriteLine("Enter customer's ID:");
//        string customerId = Console.ReadLine();

//        Console.WriteLine("Enter units consumed:");
//        double unitsConsumed = double.Parse(Console.ReadLine());

//        Console.WriteLine("Enter due amount :");
//        int dueamount = int.Parse(Console.ReadLine());

//        double totalAmount = dueamount + (per_unit * unitsConsumed);

//        Console.WriteLine("\nElectricity Bill");
//        Console.WriteLine("Customer Name: " + customerName);
//        Console.WriteLine("Customer ID: " + customerId);
//        Console.WriteLine("Units Consumed: " + unitsConsumed);
//        Console.WriteLine("Due amount is :" + dueamount);
//        Console.WriteLine("Total Amount is: " + totalAmount);
//    }
//}



//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter the string :");
//        string input = Console.ReadLine();

//        string pattern = "[^a-zA-Z0-9 _-]";
//        string result = Regex.Replace(input, pattern, "");

//        Console.WriteLine("Original string: " + input);
//        Console.WriteLine("******************************************");
//        Console.WriteLine("String after removing special characters: " + result);
//    }
//}

//static string RemoveSpecialCharacters(string text)
//{
//    string result = "";

//    foreach (char ch in text)
//    {
//        if (char.IsLetterOrDigit(ch) || ch == ' ' || ch == '_' || ch == '-')
//        {
//            result += c;
//        }
//    }

//    return result;
//}



//separate odd and even the array
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] inputArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//        int[] oddArray = GetOddNumbers(inputArr);
//        int[] evenArray = GetEvenNumbers(inputArr);

//        Console.WriteLine("Original Array:");
//        DisplayingArray(inputArr);

//        Console.WriteLine("\nEven Integers Are:");
//        DisplayingArray(evenArray);

//        Console.WriteLine("\nOdd Integers Are:");
//        DisplayingArray(oddArray);

//    }

//    static int[] GetOddNumbers(int[] input)
//    {
//        int oddCount = CountOddNumbers(input);
//        int[] oddNumbers = new int[oddCount];

//        int i = 0;
//        foreach (int num in input)
//        {
//            if (num % 2 != 0)
//                oddNumbers[i++] = num;
//        }

//        return oddNumbers;
//    }

//    static int[] GetEvenNumbers(int[] input)
//    {
//        int evenCount = CountEvenNumbers(input);
//        int[] evenNumbers = new int[evenCount];

//        int i = 0;
//        foreach (int num in input)
//        {
//            if (num % 2 == 0)
//                evenNumbers[i++] = num;
//        }

//        return evenNumbers;
//    }

//    static int CountOddNumbers(int[] input)
//    {
//        int count = 0;
//        foreach (int num in input)
//        {
//            if (num % 2 != 0)
//                count++;
//        }
//        return count;
//    }

//    static int CountEvenNumbers(int[] input)
//    {
//        int count = 0;
//        foreach (int num in input)
//        {
//            if (num % 2 == 0)
//                count++;
//        }
//        return count;
//    }

//    static void DisplayingArray(int[] arr)
//    {
//        foreach (int num in arr)
//        {
//            Console.Write(num + " ");
//        }
//        Console.WriteLine();
//    }
//}

//Copy and Display the content


//class Program
//{
//    static void Main(string[] args)
//    {
//        string sourceFilePath = @"E:\sourceFileExample";
//        string destinationFilePath = @"E:\destinationFileExample";

//        //  File.Create(sourceFilePath);

//        WriteToFile(sourceFilePath, "Hello, Good Morning This content is from source file!!!!!!!!!!!!!!");

//        CopyFile(sourceFilePath, destinationFilePath);

//        DisplayFileContent(destinationFilePath);
//    }

//    static void WriteToFile(string filePath, string content)
//    {
//        File.WriteAllText(filePath, content);
//    }

//    static void CopyFile(string sourceFilePath, string destinationFilePath)
//    {
//        File.Copy(sourceFilePath, destinationFilePath);
//    }

//    static void DisplayFileContent(string filePath)
//    {
//        string content = File.ReadAllText(filePath);
//        Console.WriteLine("Displaying the contents here:");
//        Console.WriteLine(content);
//    }
//}

// line lies x axis or y axis

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter the X coordinate:");
//        int x = int.Parse(Console.ReadLine());

//        Console.WriteLine("Enter the Y coordinate:");
//        int y = int.Parse(Console.ReadLine());

//        string quadrant = DetermineQuadrant(x, y);

//        Console.WriteLine($"The point ({x}, {y}) lies in {quadrant}");
//    }

//    static string DetermineQuadrant(int x, int y)
//    {
//        if (x > 0 && y > 0)
//        {
//            return "the first quadrant.";
//        }
//        else if (x < 0 && y > 0)
//        {
//            return "the second quadrant.";
//        }
//        else if (x < 0 && y < 0)
//        {
//            return "the third quadrant.";
//        }
//        else if (x > 0 && y < 0)
//        {
//            return "the fourth quadrant.";
//        }
//        else if (x == 0 && y == 0)
//        {
//            return "the origin quadrant.";
//        }
//        else if (x == 0)
//        {
//            return "the Y-axis quadrant.";
//        }
//        else
//        {
//            return "the X-axis quadrant.";
//        }

//    }

//}
