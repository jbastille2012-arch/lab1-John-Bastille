using System;
using System.ComponentModel;
using System.Dynamic;
public class Student 
{                             // Student class with properties and constructor
    public int Id {get; private set;}
    public string FirstName {get; private set;}
    public string LastName {get; private set;}
    public string Email {get; private set;}
    public double AverageGrade {get; private set;}


    public Student(int id, string firstName, string lastName, string email, double avgGrade)
    {                               // Constructor to initialize student properties
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        AverageGrade = avgGrade;
    }
public override string ToString()         // Override ToString for better display of student information
    {
        return $"{Id}: {FirstName} {LastName} - {Email} - Grade: {AverageGrade:F1}";
    }
}