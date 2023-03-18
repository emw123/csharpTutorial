using System;
using System.Collections;

public class ExamplesStack  {

   public static void Main()  {
      Stack firstStack = new Stack();
      firstStack.Push("This");
      firstStack.Push("is");
      firstStack.Push("a");
      firstStack.Push("sentence");
      firstStack.Push("being");
      firstStack.Push("pushed");
      firstStack.Push("into");
      firstStack.Push("the");
      firstStack.Push("stack");
    foreach (var item in firstStack){
        Console.Write(item + " ");
      }
    Console.WriteLine();
     Stack secondStack = new Stack();
     secondStack.Push(firstStack.Pop());
     secondStack.Push(firstStack.Pop());
     secondStack.Push(firstStack.Pop());
     secondStack.Push(firstStack.Pop());
     secondStack.Push(firstStack.Pop());
     secondStack.Push(firstStack.Pop());
     secondStack.Push(firstStack.Pop());
     secondStack.Push(firstStack.Pop());
     secondStack.Push(firstStack.Pop());
         
      foreach (var item in secondStack){
        Console.Write(item + " ");
      }

   }
}



