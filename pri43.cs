using System;

// Base class
class Person
{

    private string name;
    protected int age;
    public string city;

    public Person(string n, int a, string c)
    {
        name = n;
        age = a;
        city = c;
    }

    // Public method to display name
    public void ShowName()
    {
        Console.WriteLine("Name        : " + name);
    }

    // Public method to display age
    public void ShowAge()
    {
        Console.WriteLine("Age         : " + age);
    }

    // Public method to display city
    public void ShowCity()
    {
        Console.WriteLine("City        : " + city);
    }
}

// Derived class - inherits Person
class Student : Person
{
    // Private data member
    private int enrollmentNo;

    // Protected data member
    protected string course;

    // Public data member
    public string college;

    // Constructor of derived class
    public Student(string n, int a, string c, int eno, string co, string col)
        : base(n, a, c)
    {
        enrollmentNo = eno;
        course = co;
        college = col;
    }

    // Public method to display enrollment number
    public void ShowEnrollment()
    {
        Console.WriteLine("Enrollment  : " + enrollmentNo);
    }

    // Public method to display course
    public void ShowCourse()
    {
        Console.WriteLine("Course      : " + course);
    }

    // Public method to display college
    public void ShowCollege()
    {
        Console.WriteLine("College     : " + college);
    }
}

// Demo class
class Demo
{
    static void Main()
    {
        // Creating first Student object
        Student s1 = new Student(
            "Meet", 24, "Rajkot", 101, "B.Tech IT", "RK University");

        // Creating second Student object
        Student s2 = new Student(
            "khush", 21, "Ahmedabad", 102, "B.Tech CE", "RK University");

        Console.WriteLine("--------- Student 1 ---------");
        s1.ShowName();
        s1.ShowAge();
        s1.ShowCity();
        s1.ShowEnrollment();
        s1.ShowCourse();
        s1.ShowCollege();

        Console.WriteLine("\n--------- Student 2 ---------");
        s2.ShowName();
        s2.ShowAge();
        s2.ShowCity();
        s2.ShowEnrollment();
        s2.ShowCourse();
        s2.ShowCollege();

        Console.Read();
    }
}