using System;
using System.Collections.Generic;

namespace GRADEBOOK
{
    class Program
    {
        static void Main(string[] args)
        {
          var book =new Book();  
          
          book.AddGrade(59.1);
          book.AddGrade(100);
          book.AddGrade(20.6);
          book.AddGrade(70.2);
          book.AddGrade(95.3);

          book.Stats();
        }
    }
}
