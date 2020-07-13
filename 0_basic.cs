using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");  // always write on new line
      Console.Write("Tes");               // without enter
      Console.WriteLine("Hello World!");    
    }
  }
}

/*
Run on terminal: $ csc /out:0.exe 0_basic.cs && 0.exe

Line 1: using System means that we can use classes from the System namespace.
Line 2: A blank line. C# ignores white space. However, multiple lines makes the code more readable.
Line 3: namespace is a used to organize your code, and it is a container for classes and other namespaces.
Line 4: The curly braces {} marks the beginning and the end of a block of code.
Line 5: class is a container for data and methods, which brings functionality to your program. Every line of code that runs in C# must be inside a class. In our example, we named the class Program.
Line 7: Another thing that always appear in a C# program, is the Main method. Any code inside its curly brackets {} will be executed. You don't have to understand the keywords before and after Main. You will get to know them bit by bit while reading this tutorial.
Line 9: Console is a class of the System namespace, which has a WriteLine() method that is used to output/print text. In our example it will output "Hello World!".
If you omit the using System line, you would have to write System.Console.WriteLine() to print/output text.
Note: Every C# statement ends with a semicolon ;.
Note: C# is case-sensitive: "MyClass" and "myclass" has different meaning.
Note: Unlike Java, the name of the C# file does not have to match the class name, but they often do (for better organization). When saving the file, save it using a proper name and add ".cs" to the end of the filename. To run the example above on your computer, make sure that C# is properly installed: Go to the Get Started Chapter for how to install C#. The output should be:
*/