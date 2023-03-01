using System;

class Student
{
    // auto-implemented properties
    public int Id { get; init; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // default constructor
    public Student()
    {
        Id = 0;
        FirstName = "";
        LastName = "";
    }
    // parameterized constructor
    public Student(int i, string First, string Last)
    {
        Id = i;
        FirstName = First;
        LastName = Last;
    }
    //another parameterized constructor
    public Student(int id)
    {
        Id=id;
        FirstName = string.Empty;
        LastName = string.Empty;
    }

}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student(1);
        student.FirstName = "Bob";
        student.LastName = "Builder";

        Student student1 = new Student(2, "Spongebob", "Squarepants");

        Console.WriteLine($"Student 1: {student.LastName}, {student.FirstName}");
        Console.WriteLine($"Student 2: {student1.LastName}, {student1.FirstName}");
    }
}