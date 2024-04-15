// See https://aka.ms/new-console-template for more information



var student = new Student("faten","ce",4.0);
student.StudentSummary();
public class Student
{

    public string Name { get; set; }
    public string Major { get; set; }
    public double Gpa { get; set; }
    public Student(string name, string major, double gpa)
    {
        Name = name;
        Major = major;
        Gpa = gpa;
    }
    public void StudentSummary()
    {
        Console.WriteLine($"$student {Name} major {Major} gpa {Gpa}");

    }
}


