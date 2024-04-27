using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

// student age more then 18
//class Student
//{
//    public string name;
//    public int age;
//    public string Class;

//    public Student(string name, int age, string Class)
//    {
//        this.name = name;
//        this.age = age;
//        this.Class = Class;
//    }
//}
//class Class
//{
//    public string className;
//    public string classTeacher;

//    public Class(string className, string classTeacher)
//    {
//        this.className = className;
//        this.classTeacher = classTeacher;
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {

//        List<Student> students = new List<Student>();

//        students.Add(new Student("Harshitha", 20, "A"));
//        students.Add(new Student("Anjali", 18, "B"));
//        students.Add(new Student("Pruthvi", 19, "C"));
//        students.Add(new Student("Rashmi", 17, "A"));

//        List<Class> classes = new List<Class>()
//        {
//            new Class("A", "Mr. Smith"),
//            new Class("B", "Ms. Suraksha"),
//            new Class("C", "Mr. Alias")
//        };

//        var olderStudents = from student in students
//                            where student.age > 18
//                            join cls in classes on student.Class equals cls.className
//                            select new { StudentName = student.name, StudentAge = student.age, ClassName = cls.className, ClassTeacher = cls.classTeacher };

//        Console.WriteLine("Students whose age is greater than 18:");
//        foreach (var student in olderStudents)
//        {
//            Console.WriteLine($"Name: {student.StudentName}, Age: {student.StudentAge}, Class: {student.ClassName}, Class Teacher: {student.ClassTeacher}");
//        }
//    }
//}

//print employee salary between 6000 and 800

//public class Employee
//{
//    public int empId;
//    public string empName;
//    public double empSalary;

//    public Employee(int empId, string empName, double empSalary)
//    {
//        this.empId = empId;
//        this.empName = empName;
//        this.empSalary = empSalary;
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        List<Employee> employees = new List<Employee>();
//        employees.Add(new Employee(101, "John", 8000));
//        employees.Add(new Employee(102, "Smith", 600));
//        employees.Add(new Employee(103, "Alias", 3000));
//        employees.Add(new Employee(104, "Jerry", 5000));

//        var filterEmployee = employees.Where(e => e.empSalary <= 6000 && e.empSalary >= 800);
//        Console.WriteLine("\n**********Employee Details whose salary between 6000 and 800***********");

//        // var filterEmployee=from employee in employees where employee.empSalary<=6000 && employee.empSalary>=800 select employee;
//        foreach (var employee in filterEmployee)
//        {
//            Console.WriteLine($"Employee Id : {employee.empId}\n  Employee Name : {employee.empName} \n Employee Salary : {employee.empSalary}");
//        }
//    }
//}

// print employee names less than 4 characters
//class Program
//{
//    static void Main(string[] args)
//    {
//        List<string> employees = new List<string>();

//        Console.WriteLine("\n*******************Welcome to the employee name entry program*****************");

//        while (true)
//        {
//            Console.WriteLine("Enter an employee name or type 'done' to finish:");
//            string input = Console.ReadLine();

//            switch (input.ToLower())
//            {
//                case "done":
//                    Console.WriteLine("\nAll entered employee names:");
//                    foreach (var employee in employees)
//                    {
//                        Console.WriteLine(employee);
//                    }
//                    var shortNamedEmployees = from employee in employees
//                                              where employee.Length < 4
//                                              select employee;

//                    // var shortNamedEmployees = employees.Where(emp => !emp.Contains("a",StringComparison.OrdinalIgnoreCase));

//                    Console.WriteLine("\nEmployees with names less than 4 characters:");
//                    foreach (var employee in shortNamedEmployees)
//                    {
//                        Console.WriteLine(employee);
//                    }
//                    return;

//                default:
//                    employees.Add(input);
//                    break;
//            }
//        }
//    }
//}

//specific value
//class Product
//{
//    public int ID;
//    public string Name;
//    public double Price;
//    public Product(int id, string name, double price)
//    {
//        ID = id;
//        Name = name;
//        Price = price;
//    }
//    public override string ToString()
//    {
//        return $"ID: {ID}, Name: {Name}, Price: {Price}";
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        List<Product> products = new List<Product>();

//        Console.WriteLine("Enter product details (ID, Name, Price):");
//        while (true)
//        {
//            Console.WriteLine("Enter product ID (enter -1 to stop):");
//            int id = Convert.ToInt32(Console.ReadLine());
//            if (id == -1)
//                break;

//            Console.WriteLine("Enter product name:");
//            string name = Console.ReadLine();

//            Console.WriteLine("Enter product price:");
//            double price = Convert.ToDouble(Console.ReadLine());

//            Product product = new Product(id, name, price);
//            products.Add(product);
//        }
//        Console.WriteLine("Enter product ID to update values:");
//        int updateId = Convert.ToInt32(Console.ReadLine());

//        Product productToUpdate = products.FirstOrDefault(p => p.ID == updateId);

//        if (productToUpdate != null)
//        {
//            Console.WriteLine("Enter new name for product:");
//            string newName = Console.ReadLine();
//            Console.WriteLine("Enter new price for product:");
//            double newPrice = Convert.ToDouble(Console.ReadLine());

//            productToUpdate.Name = newName;
//            productToUpdate.Price = newPrice;

//            Console.WriteLine("Updated product details:");
//            Console.WriteLine(productToUpdate.ToString());
//        }
//        else
//        {
//            Console.WriteLine("Product ID not found.");
//        }
//    }
//}

//*****************asynchronous program***********************
//using System.Numerics;
//using System.Threading.Tasks;
//class program
//{ 
//    static async Task Main(string[] args)
//    {

//        BigInteger factorialresult = await Task.Run(() => factorialasync(15));
//        Console.WriteLine("factorial of 15: " + factorialresult);

//        BigInteger fibonacciresult = await Task.Run(() => fibonacciasync(25));
//        Console.WriteLine("25th term of fibonacci sequence: " + fibonacciresult);
//    }

//    static async Task<BigInteger> factorialasync(int n)
//    {
//        if (n == 0)
//            return 1;
//        return n * await factorialasync(n - 1);
//    }

//    static async Task<BigInteger> fibonacciasync(int n)
//    {
//        if (n <= 1)
//            return n;
//        return await fibonacciasync(n - 1) + await fibonacciasync(n - 2);
//    }
//}

//PersonBankAccount program

//class PersonBankAccount
//{
//    private static string bankName;
//    private const int minimumBalance = 1000;
//    private const double intrestRate = 0.07;
//    private const int intrestPeriodicity = 6;

//    private double balance = 1000;

//    static PersonBankAccount()
//    {
//        Console.WriteLine("Enter the name of the bank :");
//        bankName = Console.ReadLine();
//    }
//    public static void RenameBankAccount(string newName)
//    {
//        bankName = newName;
//        Console.WriteLine($"Bank renamed successfully {bankName}");
//    }
//    public void Withdraw(int amount)
//    {
//        if (balance - amount < minimumBalance)
//        {
//            Console.WriteLine("Insufficient balance. Withdraw failed");
//            return;
//        }
//        balance -= amount;
//        Console.WriteLine($"Withdraw of {amount}$ successful. Current Balance is :{balance}$");
//    }
//    public void Deposit(int amount)
//    {
//        balance += amount;

//        Console.WriteLine($"Deposite of {amount}$ successful. Current Balance is : {balance}$");
//    }
//    public void AddInterest()
//    {
//        double intrest = balance * intrestRate * (intrestPeriodicity / 12.0);
//        balance += intrest;
//        Console.WriteLine($"Intrest is added : {intrest}. New Balance is :{balance}");
//    }
//    public double GetBalance()
//    {
//        return balance;
//    }

//}
//class MainClass
//{
//    static void Main(string[] args)
//    {
//        PersonBankAccount account = new PersonBankAccount();

//        while (true)
//        {
//            Console.WriteLine("\nChoose an option:");
//            Console.WriteLine("1. Withdraw");
//            Console.WriteLine("2. Deposit");
//            Console.WriteLine("3. Add Interest");
//            Console.WriteLine("4. Check Balance");
//            Console.WriteLine("5. Rename Bank");
//            Console.WriteLine("6. Exit");

//            Console.Write("Enter your choice: ");
//            string choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    Console.Write("Enter withdrawal amount: ");
//                    int withdrawAmount = Convert.ToInt32(Console.ReadLine());
//                    account.Withdraw(withdrawAmount);
//                    break;

//                case "2":
//                    Console.Write("Enter deposit amount: ");
//                    int depositAmount = Convert.ToInt32(Console.ReadLine());
//                    account.Deposit(depositAmount);
//                    break;

//                case "3":
//                    account.AddInterest();
//                    break;

//                case "4":
//                    Console.WriteLine($"Current Balance: {account.GetBalance()}");
//                    break;

//                case "5":
//                    Console.Write("Enter new bank name: ");
//                    string newBankName = Console.ReadLine();
//                    PersonBankAccount.RenameBankAccount(newBankName);
//                    break;

//                case "6":
//                    Console.WriteLine("Exiting program...");
//                    return;

//                default:
//                    Console.WriteLine("Invalid choice. Please try again.");
//                    break;
//            }
//        }
//    }
//}


//json Program

//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main(string[] args)
//    {
//        List<Product> products = new List<Product>
//        {
//            new Product { ProductId = 1, ProductName = "Laptop", Price = 99999, Quantity = 10 },
//            new Product { ProductId = 2, ProductName = "Smartphone", Price = 70000, Quantity = 20 },
//            new Product { ProductId = 3, ProductName = "Tablet", Price =80000, Quantity = 15 },
//            new Product { ProductId = 4, ProductName = "Headphones", Price = 79999, Quantity = 30 },
//            new Product { ProductId = 5, ProductName = "Mouse", Price = 30000, Quantity = 50 }
//        };

//        string jsonString = JsonConvert.SerializeObject(products);

//        Console.WriteLine("JSON string:");
//        Console.WriteLine(jsonString);

//        List<Product> deserializedProducts = JsonConvert.DeserializeObject<List<Product>>(jsonString);

//        Console.WriteLine("\nDeserialized Products:");
//        foreach (var product in deserializedProducts)
//        {
//            Console.WriteLine($"Product ID: {product.ProductId}, Name: {product.ProductName}, Price: {product.Price}, Quantity: {product.Quantity}");
//        }
//    }
//}

//class Product
//{
//    public int ProductId { get; set; }
//    public string ProductName { get; set; }
//    public decimal Price { get; set; }
//    public int Quantity { get; set; }
//}