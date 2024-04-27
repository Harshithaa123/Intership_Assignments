using System;
using System.IO;
//class Student
//{
//    public string name;
//    public int age;
//    public string address;
//    public Student(string name, int age, string address)
//    {
//        this.name = name;
//        this.age = age;
//        this.address = address;
//    }
//    public void displayStudentInfo()
//    {
//        Console.WriteLine("Student information is here :");
//        Console.WriteLine($" Name is : {name}, Age is : {age} , Address is : {address}");
//    }

//}
//class Teacher : Student
//{
//    private string qualification;
//    public Teacher(string name, int age, string address, string qualification) : base(name, age, address)

//    {
//        this.qualification = qualification;
//    }
//    public void displayTeacherInfo()
//    {
//        Console.WriteLine("Teacher Information is here :");
//        Console.WriteLine($" Name is : {name}, Age is : {age} , Address is : {address},Qualification is : {qualification}");
//    }
//}
//class MainClass
//{
//    static void Main(string[] args)
//    {
//        Teacher t = new Teacher("Jerry", 26, "Mysore", "Ph.d");
//        t.displayTeacherInfo();
//        Student s = new Student("Alias", 22, "Benglore");
//        s.displayStudentInfo();

//    }
//}

//Encapsulation employee info

//class Employee
//{
//    private string name;
//    private int age;
//    private double salary;
//    private string address;

//    public string Name
//    {
//        get { return name; }
//        set { name = value; }
//    }
//    public int Age
//    {
//        get { return age; }
//        set { age = value; }
//    }
//    public double Salary
//    {
//        get { return salary; }
//        set { salary = value; }
//    }
//    public string Address
//    {
//        get { return address; }
//        set { address = value; }
//    }
//    public Employee(string name, int age, double salary, string address)
//    {
//        this.name = name;
//        this.age = age;
//        this.salary = salary;
//        this.address = address;
//    }
//    public void displyEmployeeInfo()
//    {
//        Console.WriteLine($"Employee Name : {name}\n,Employee Age : {age}\n,Employee Salary :{salary}\n,Adresss :{address}");
//    }
//}
//class EmployeeInfo
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter employee name:");
//        string name = Console.ReadLine();

//        Console.WriteLine("Enter employee age:");
//        int age = int.Parse(Console.ReadLine());

//        Console.WriteLine("Enter employee address:");
//        string address = Console.ReadLine();

//        Console.WriteLine("Enter employee salary:");
//        double salary = double.Parse(Console.ReadLine());


//        Employee emp = new Employee(name, age, salary, address);
//        emp.displyEmployeeInfo();

//    }
//}

//polymorphism
//abstract class PaymentMethod
//{
//    public abstract void MakePayment(double amount);
//}

//class DigitalWallet : PaymentMethod
//{
//    public override void MakePayment(double amount)
//    {
//        Console.WriteLine($"Paid {amount} using Digital Wallet.");
//    }
//}

//class BankTransfer : PaymentMethod
//{
//    public override void MakePayment(double amount)
//    {
//        Console.WriteLine($"Paid {amount} using Bank Transfer.");
//    }
//}

//class CreditCard : PaymentMethod
//{
//    public override void MakePayment(double amount)
//    {
//        Console.WriteLine($"Paid {amount} using Credit Card.");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter the Amount using Digitalwallet");
//        int digitalAmount = int.Parse(Console.ReadLine());

//        Console.WriteLine("Enter the Amount Transfer through Bank");
//        int bankAmount = int.Parse(Console.ReadLine());

//        Console.WriteLine("Enter the Amount using CreditCard");
//        int creditAmount = int.Parse(Console.ReadLine());

//        PaymentMethod digitalWallet = new DigitalWallet();
//        PaymentMethod bankTransfer = new BankTransfer();
//        PaymentMethod creditCard = new CreditCard();

//        digitalWallet.MakePayment(digitalAmount);
//        bankTransfer.MakePayment(bankAmount);
//        creditCard.MakePayment(creditAmount);
//    }
//}

// Abstract class
//abstract class Shape
//{
//    public abstract double CalculateArea();
//}

//class Circle : Shape
//{
//    private double radius;
//    public Circle(double radius)
//    {
//        this.radius = radius;
//    }
//    public override double CalculateArea()
//    {
//        return 3.14 * radius * radius;
//    }
//}
//class Square : Shape
//{
//    private double side;
//    public Square(double side)
//    {
//        this.side = side;
//    }


//    public override double CalculateArea()
//    {
//        return side * side;
//    }
//}

//class Triangle : Shape
//{

//    private double baseLength;
//    private double height;
//    public Triangle(double baseLength, double height)
//    {
//        this.baseLength = baseLength;
//        this.height = height;
//    }
//    public override double CalculateArea()
//    {
//        return 0.5 * baseLength * height;
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter the area of Circle");
//        int circleValue = int.Parse(Console.ReadLine());

//        Console.WriteLine("Enter the area of Square");
//        int areaValue = int.Parse(Console.ReadLine());

//        Console.WriteLine("Enter the area of Triangle (baselength and value)");
//        int baselength = int.Parse(Console.ReadLine());
//        int height = int.Parse(Console.ReadLine());


//        Shape circle = new Circle(circleValue);
//        Shape square = new Square(areaValue);
//        Shape triangle = new Triangle(baselength,height);

//        Console.WriteLine("Area of Circle: " + circle.CalculateArea());
//        Console.WriteLine("Area of Square: " + square.CalculateArea());
//        Console.WriteLine("Area of Triangle: " + triangle.CalculateArea());
//    }
//}

//Exception Handling

//using System;

//class Program
//{
//    public static void Main(string[] args)
//    {
//        try
//        {
//            int[] arr = { 1, 2, 3, 4, 5 };

//            Console.WriteLine("Enter the index to access the element in the array:");
//            int index = int.Parse(Console.ReadLine());

//            int result = arr[index];
//            Console.WriteLine("Element at index " + index + " is " + result);

//            Console.WriteLine("Enter Numerator:");
//            int num1 = int.Parse(Console.ReadLine());

//            Console.WriteLine("Enter Denominator:");
//            int num2 = int.Parse(Console.ReadLine());

//            int resultNum = num1 / num2;
//            Console.WriteLine("Result of division: " + resultNum);
//        }
//        catch (IndexOutOfRangeException e)
//        {
//            Console.WriteLine(e.Message);
//           // Console.WriteLine(e.StackTrace);
//        }
//        catch (FormatException e)
//        {
//            Console.WriteLine(e.Message);
//           // Console.WriteLine("Cannot convert string to interger give the numerical values only ");
//        }
//        catch (DivideByZeroException e)
//        {
//            Console.WriteLine(e.Message);
//        }
//    }
//}

//File Handling

//class Program
//{
//public static void fileReading()
//{
//    Console.WriteLine("Enter the data want to save in a file");
//    string data = Console.ReadLine();

//    FileInfo info = new FileInfo(@"E:\simpledata.txt");
//    StreamWriter writer = info.CreateText();
//    writer.Flush();
//}
//public static void Main(string[] args)
//{
// File.Create(@"E:\data.txt");  //creating a file
// File.WriteAllText(@"E:\data.txt","Hello Good Morning"); 

// Directory.CreateDirectory(@"E:\Angularexample"); //creating an directory

// File.Move(@"E:\data.txt", @"E:\Angularexample\hello.txt"); // move one filr to another file

// ***************take message from user and store***************

//    Console.WriteLine("Enter message to display");
//    string data = Console.ReadLine();

//    string filepath = "E:\\Angularexample\\hello.txt";

//    File.WriteAllText(filepath, data);

// **********take message from user and store not overriding data**************

//Console.WriteLine("Enter message to display");
//string data = Console.ReadLine();

//string filepath = "E:\\Angularexample\\hello.txt";

//File.AppendAllText(filepath, data+"\n");
//    }
//}

// **********  ArrayList program **************
using System.Collections;
class Program
{
    public static void Main(string[] args)
    {
        //ArrayList list = new ArrayList();
        //list.Add(10);
        //list.Add(20);
        //list.Add("hello");
        //list.Add(null);

        //list.Remove(null);
        //list.RemoveAt(2);

        //foreach(object obj in list)
        //{
        //    Console.WriteLine(obj);
        //}

        Stack stack = new Stack();
        stack.Push(10);
        stack.Push(20);

    }
}















































