using System.Text.RegularExpressions;
using System;
using System.ComponentModel;
using System.Data.Common;
using System.Reflection.Metadata;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;

class Program
{
    public static void Main(string[] args)
    {
        Group PSe = new Group {Name = "PSe"};
        PSe.AddStudent( new Student
        {
            Id = 1,
            FirstName = "John",
            LastName = "Bastille",
            Email = "jbastille2012@gmail.com",
            AverageGrade = 9.5

        });
        PSe.AddStudent (new Student
        {
            Id = 2,
            FirstName = "Bob",
            LastName = "Smith",
            Email = "Bobsmith@gmail.com",
            AverageGrade = 9
        });
        PSe.AddStudent (new Student
        {
            Id = 3,
            FirstName = "Jane",
            LastName = "Pop", 
            Email = "JanePop@gmail.com",
            AverageGrade = 10
        });
        PSe.PrintAll();

    }


}