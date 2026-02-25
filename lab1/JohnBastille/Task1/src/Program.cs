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
        // using constructors to create student objects and adding them to the group
        Group PSe = new Group {Name = "PSe"};
        PSe.AddStudent(new Student(1, "John", "Bastille", "jbastille2012@gmail.com", 9.5));
        
        PSe.AddStudent (new Student(2, "Bob", "Smith", "Bobsmith@gmail.com", 8.5));
      
        PSe.AddStudent (new Student(3, "Jane", "Pop", "JanePop@gmail.com", 10)); 
       
       Group PSe2 = new Group {Name = "PSe2"};
        PSe2.AddStudent(new Student(1, "Alice", "Johnson", "AliceJohnson@gmail.com", 9.0));

        PSe2.AddStudent(new Student(2, "Charlie", "Brown", "CharlieBrown@gmail.com", 8.0));

        PSe2.AddStudent(new Student(3, "Eve", "Davis", "EveDavis@gmail.com", 7.5)); 
        
        PSe.PrintAll();
        PSe2.PrintAll();

    }


}