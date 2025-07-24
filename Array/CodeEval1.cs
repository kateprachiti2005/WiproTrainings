using System;

class Student
{
    // Define properties
    // Complete Step 1:............
    public string name{get; set;}
    public int age{get; set;}
    public string grade{get; set;}
    // Define constructor
    // Complete Step 2:............
   public Student(string name,int age,string grade)
    {
        this.name=name;
        this.age=age;
        this.grade=grade;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter student details
        Console.WriteLine("Enter student's name:");
        // Complete Step 3:............
         string name=Console.ReadLine();
        Console.WriteLine("Enter student's age:");
        // Complete Step 4:............
        int age=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter student's grade:");
        // Complete Step 5:............
         string grade=Console.ReadLine();

        // Create an instance of the Student class
        // Complete Step 6:............
         Student s= new Student(name,age,grade);
        // Print student details
        // Complete Step 7:............
        Console.WriteLine("Student Name:"+s.name);
        Console.WriteLine("Student Age:"+s.age);
        Console.WriteLine("Student Grade:"+s.grade);

    }
}