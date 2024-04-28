//create 2 class Employee and SalesAssociate
using System;
class Employee
{
    public string empName { get; set; }
    public int empId { get; set; }

}
class SalesAssociate : Employee
{
    private int sales;

    public SalesAssociate(string empName, int empId)
    {
        this.empName = empName;
        this.empId = empId;
    }
    public void NumberOfSales(int monthlySales)
    {
        sales = monthlySales;
    }
    public double SalesBonus()
    {
        double bounus = 0;
        if (sales > 10)
        {
            bounus = sales * 0.05;
        }
        else if (sales > 20)
        {
            bounus = sales * 0.10;
        }
        else if (sales > 30)
        {
            bounus = sales * 0.20;
        }
        return bounus;
    }
}
class MainProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter sales Associate's Name");
        string name = (Console.ReadLine());

        Console.WriteLine("Enter Employee Id :");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Monthly Sales");
        int sales = int.Parse(Console.ReadLine());

        SalesAssociate salesAssociate = new SalesAssociate(name, id);
        salesAssociate.NumberOfSales(sales);

        Console.WriteLine($"Sales associate {salesAssociate.empName} earned a bonus of {salesAssociate.SalesBonus()}.");
    }
}

//delegate function perform add,sub,mul,div

//using System;

//delegate double MathOperation(double x, double y);
//class Program
//{

//    static double Add(double x, double y)
//    {
//        return x + y;
//    }
//    static double Subtract(double x, double y)
//    {
//        return x - y;
//    }
//    static double Multiply(double x, double y)
//    {
//        return x * y;
//    }
//    static double Divide(double x, double y)
//    {
//        if (y != 0)
//        {
//            return x / y;
//        }
//        else
//        {
//            return double.NaN;
//        }
//    }
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter First Number :");
//        double num1 = Convert.ToDouble(Console.ReadLine());

//        Console.WriteLine("Enter Second Number:");
//        double num2 = Convert.ToDouble(Console.ReadLine());

//        MathOperation operationAdd = new MathOperation(Add);
//        MathOperation operationSub = new MathOperation(Subtract);
//        MathOperation operationMul = new MathOperation(Multiply);
//        MathOperation operationDiv = new MathOperation(Divide);

//        Console.WriteLine("Result of addition is " + operationAdd(num1, num2));
//        Console.WriteLine("Result of subtraction is " + operationSub(num1, num2));
//        Console.WriteLine("Result of multiplication is " + operationMul(num1, num2));
//        Console.WriteLine("Result of division is " + operationDiv(num1, num2));
//    }

//}

//Predicate function  

//using System;
//using System.Collections.Generic;

//class Customer
//{
//    public int id;
//    public string name;
//    public string address;
//    public string city;
//    public string country;

//    public Customer(int id, string name, string address, string city, string country)
//    {
//        this.id = id;
//        this.name = name;
//        this.address = address;
//        this.city = city;
//        this.country = country;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        List<Customer> customers = new List<Customer>();
//         customers.Add(new Customer(101, "John", "123 Main St", "Bengaluru", "Karnataka"));
//        customers.Add(new Customer(102, "Alias", "123 Main St", "Bengaluru", "Karnataka"));
//        customers.Add(new Customer(103, "Smith", "654 Main St", "Mysuru", "Karnataka"));
//        customers.Add(new Customer(104, "Alexa", "878 Main St", "Mandya", "Karnataka"));
//        customers.Add(new Customer(105, "Jerry", "444 Main St", "Ramnagar", "Karnataka"));

//        Predicate<Customer> printCustomerDetails = (customer) =>
//        {
//            Console.WriteLine($"Customer ID: {customer.id}");
//            Console.WriteLine($"Customer Name: {customer.name}");
//            Console.WriteLine($"Address: {customer.address}");
//            Console.WriteLine($"City: {customer.city}");
//            Console.WriteLine($"Country: {customer.country}");
//            Console.WriteLine();
//            return true; 
//        };
//        foreach (var cust in customers)
//        {
//            printCustomerDetails(cust);
//        }
//        Console.ReadKey();
//    }
//}