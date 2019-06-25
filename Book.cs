using System;
using System.Collections.Generic;
namespace GRADEBOOK

{
class Book
    {
List <double> grades;
public Book()
{
    grades = new List<double>() {};
}
public void AddGrade(double grade)
        { 
           
            grades.Add(grade);

        }

public void Stats()
{
    var avg = 0.0;
    var highestRes = double.MinValue;
    var lowestRes= double.MaxValue;
    foreach(var grade in grades) 
    {
        avg+=grade;
        highestRes=Math.Max(grade,highestRes);
        lowestRes=Math.Min(grade,lowestRes);
    }
    
    
    avg /= grades.Count;
 System.Console.WriteLine($"Average Result: {avg}"); 
 System.Console.WriteLine($"Highest Result: {highestRes}");
 System.Console.WriteLine($"Lowest Result: {lowestRes}");
}
   }
}