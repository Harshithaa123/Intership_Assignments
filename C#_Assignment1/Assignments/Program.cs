using System;
using System.Collections.Generic;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter a string:");
//        string input = Console.ReadLine();

//        int wordCount = 0;


//        for (int i = 0; i < input.Length; i++)
//        {

//            if (input[i] != ' ' && (i == 0 || input[i - 1] == ' '))
//            {
//                wordCount++;
//            }
//        }
//        Console.WriteLine("Number of Words in the String: " + wordCount);
//    }
//}
// Average of 3 numbers
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter 3 Numbers :");

//        Console.Write("Enter First Number :");
//        double num1 = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Enter Second Number :");
//        double num2 = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Enter Third Number: ");
//        double num3 = Convert.ToDouble(Console.ReadLine());

//        double result = (num1 + num2 + num3) / 3;

//        Console.WriteLine("Average Of  {0},{1} and {2} is {3}", num1, num2, num3, result);



//    }
//}

//   Simple intrest

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter Principal amount");
//        double principal = Convert.ToDouble(Console.ReadLine());

//        Console.WriteLine("Enter the rate of intrest");
//        double rate = Convert.ToDouble(Console.ReadLine());

//        Console.WriteLine("Enter the time period");
//        double time = Convert.ToDouble(Console.ReadLine());

//        double simpleIntrest = (principal * rate * time) / 100;

//        Console.WriteLine("Peincipal Amount: {0}", principal);
//        Console.WriteLine("Rate of intrest is: {0}%", rate);
//        Console.WriteLine("Time period: {0} year", time);
//        Console.WriteLine("Simple Intrest is: {0}", simpleIntrest);

//    }
//}

//Biggest 3 numbers 

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter 3 numbers");

//        Console.Write("Enter First Num :");
//        int num1 = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Enter Second Num :");
//        int num2 = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Enter Third Num :");
//        int num3 = Convert.ToInt32(Console.ReadLine());

//        int largest = num1;

//        if (num2 > largest)
//        {
//            largest = num2;
//        }
//        if (num3 > largest)
//        {
//            largest = num3;
//        }
//        Console.WriteLine("The largest number among {0}, {1}, and {2} is: {3}", num1, num2, num3, largest);
//    }
//}

// remove the duplicated values




//class Program
//{
//    static void Main(string[] args)
//    {

//        int[] array = { 1, 2, 2, 3, 4, 4, 5 };

//        HashSet<int> uniqueValues = new HashSet<int>();


//        foreach (int num in array)
//        {
//            uniqueValues.Add(num);
//        }


//        int[] resultArray = new int[uniqueValues.Count];
//        uniqueValues.CopyTo(resultArray);


//        Console.WriteLine("Array without duplicate values:");
//        foreach (int num in resultArray)
//        {
//            Console.WriteLine(num);
//        }
//    }
//}

//Timezone  

class Program
{
    static void Main(string[] args)
    {

        TimeZoneInfo localZone = TimeZoneInfo.Local;
        Console.WriteLine("Time zone standard name: " + localZone.StandardName);
        Console.WriteLine("Time zone display name: " + localZone.DisplayName);

    }
}
