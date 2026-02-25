using System;
using System.Collections.Generic;

public class Group
{
    public string Name { get; set; } = string.Empty;  // ← must have public set

    public List<Student> Students { get; set; } = new List<Student>();

    // Optional: explicit parameterless constructor (helps with initializers)
    public Group() { }

    public void AddStudent(Student student)
    {
        Students.Add(student ?? throw new ArgumentNullException(nameof(student)));
    }

    public void PrintAll()
    {
        Console.WriteLine($"Group: {Name}");
            Console.WriteLine("Students:");

        foreach (var s in Students)
        {
            Console.WriteLine($"{s.Id}: {s.FirstName} {s.LastName} - {s.Email} - Avg: {s.AverageGrade:F1}");
        }
    }
}
    