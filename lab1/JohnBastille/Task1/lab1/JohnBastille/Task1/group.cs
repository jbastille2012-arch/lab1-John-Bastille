using System;
public class Group
{
   public string Name { get; set; }
    public List<Student> Students { get; set; } = new List<Student>();

    public void AddStudent(Student Stud)
    {
        Students.Add(Stud);
    }

    public void PrintAll()
    {
        Console.WriteLine($"Group: {Name}");
        Console.WriteLine("Students:");

        foreach (var Stud in Students)
        {
            Console.WriteLine($"{Stud.Id}: {Stud.FirstName} {Stud.LastName} - {Stud.Email} - Avg: {Stud.AverageGrade}");
        }
    }

}