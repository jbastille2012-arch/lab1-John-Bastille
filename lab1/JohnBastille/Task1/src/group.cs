using System;
using System.Collections.Generic;

public class Group
{
    // Make Name writable (has public set)
    public string Name { get; set; } = string.Empty;

    public List<Student> Students { get; set; } = new List<Student>();

    public void AddStudent(Student student)
    {
        if (student == null) throw new ArgumentNullException(nameof(student));
        Students.Add(student);
    }

    public void PrintAll()
    {
        Console.WriteLine($"Group: {Name}");
        Console.WriteLine("Students:");

        if (Students.Count == 0)
        {
            Console.WriteLine("  (no students)");
            return;
        }

        foreach (var s in Students)
        {
            Console.WriteLine($"{s.Id}: {s.FirstName} {s.LastName} - {s.Email} - Avg: {s.AverageGrade}");
        }
    }
}