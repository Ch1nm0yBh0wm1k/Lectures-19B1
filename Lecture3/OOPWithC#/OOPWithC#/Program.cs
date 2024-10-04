// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//class and object
//Person personObj = new Person();
//personObj.PrintSomething();

//class Person
//{
//    public string Name; // filed
//    public int age;

//    public void PrintSomething() //method
//    {
//        Console.WriteLine("I am from method");
//    }
//}

//constructor

//Person personObj = new Person();
//Console.WriteLine(personObj.name);

//Person personObj2 = new Person("Parameterized Constructor", 2);
//Console.WriteLine(personObj2.name);

//class Person
//{
//    public string name; // filed
//    public int age;


//    //default constructor
//    public Person()
//    {
//        name = "Default Constructor";
//    }
//    //parameterized constructor
//    public Person(string Name, int Age)
//    {
//        name = Name;

//    }
//}

//Access Modifier
//Person person = new Person();
//Console.WriteLine(person.name);
//Console.WriteLine(person.RetSomething());
//class Person
//{
//    public string name = "I am Public";
//    private string pvtVar = "I am Private"; // filed
//    public int age;

//    public string RetSomething()
//    {
//        return pvtVar;
//    }
//}

//protected
////Access Modifier
//Person2 person2 = new Person2();
//person2.RetSomething();
//class Person1
//{
//    protected string name="protected";
//    protected string DoSomething()
//    {
//        return "abcd";
//    }
//}
//class Person2 : Person1
//{
//    private string pvtVar = "I am Private"; // filed
//    public int age;

//    public void Print()
//    {
//        Console.WriteLine(name);
//    }

//    public string RetSomething()
//    {
//        return DoSomething();
//    }
//}

//static keyword

//Person1 person = new Person1();
//Console.WriteLine(person.MakePreIncNonStat());
//Console.WriteLine(person.MakePreIncStat());

//Person1 person1 = new Person1();
//Console.WriteLine(person1.MakePreIncNonStat());
//Console.WriteLine(person1.MakePreIncStat());

//class Person1
//{
//    public int a = 0;
//    public static int b = 0;

//    public int MakePreIncNonStat()
//    {
//        return ++a;
//    }
//    public int MakePreIncStat()
//    {
//        return ++b;
//    }

//}

//properties
//Person1 person = new Person1();
//Console.WriteLine(person.A);

//person.A = 10;
//Console.WriteLine(person.A);

//class Person1
//{
//    private int a = 0;

//    public int A { get { return a; } set { a = value; } }

//}
//method overloading
//Person person = new Person();
//person.Sum(1, 2);
//person.Sum(1.1F, 2.1F);
//person.Sum(1.10D, 2.23D);
//class Person
//{
//    public void Sum(int a, int b)
//    {
//        Console.WriteLine("Int");
//    }
//    public void Sum(float a, float b)
//    {
//        Console.WriteLine("Float");
//    }
//    public void Sum(double a, double b)
//    {
//        Console.WriteLine("Double");
//    }
//}

//method overriding
//Person person1 = new Person();
//person1.Sum(1, 2);

//Person2 person = new Person2();
//person.Sum(1, 2);
//class Person
//{
//    virtual public void Sum(int a, int b)
//    {
//        Console.WriteLine("main");
//    }
//}
//class Person2 : Person
//{
//    override public void Sum(int a, int b)
//    {
//        Console.WriteLine("I am Overrided");
//    }
//}

//abstaction

//using System.Reflection.Metadata.Ecma335;

//abstract class Person
//{
//    public int Sum(int a, int b)
//    {
//        return a + b;
//    }

//    abstract public int DoSum(int a, int b);
//}
//class Person2 : Person
//{
//    public override int DoSum(int a, int b)
//    {
//        return a + b;
//    }
//}

//interface

interface IPerson1
{

}

class A
{

}
class B: A
{

}
class C:  B
{

}

interface IA
{

}
interface IB
{

}
interface IC : IA, IB 
{

}