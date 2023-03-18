using System;
using System.Collections;

public class ExamplesStack  {

   public static void Main()  {
      Stack firstStack = new Stack();
      firstStack.Push("Actinium	Ac	89");
      firstStack.Push("Aluminum	Al	13");
      firstStack.Push("Americium Am	95");
      firstStack.Push("Antimony	Sb	51");
      firstStack.Push("Argon	Ar	18");
      firstStack.Push("Arsenic	As	33");
      firstStack.Push("Astatine	At	85");
      firstStack.Push("Barium	Ba	56");
      firstStack.Push("Berkelium Bk	97");
      firstStack.Push("Beryllium Be	4");
      firstStack.Push("Bismuth	Bi	83");
      firstStack.Push("Bohrium	Bh	107");
      firstStack.Push("Boron	B	5");
      firstStack.Push("Bromine	Br	35");
      firstStack.Push("Cadmium	Cd	48");
      firstStack.Push("Calcium  Ca  20");
      firstStack.Push("Californium	Cf	98");
      firstStack.Push("Carbon	C	6");
      firstStack.Push("Cerium	Ce	58");
      firstStack.Push("Cesium	Cs	55");
      firstStack.Push("Chlorine	Cl	17");
      firstStack.Push("Chromium	Cr	24");
      firstStack.Push("Cobalt	Co	27");
      firstStack.Push("Copernicium	Cn	112");
      firstStack.Push("Copper	Cu	29");
      firstStack.Push("Curium	Cm	96");

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
     secondStack.Push(firstStack.Pop());
     secondStack.Push(firstStack.Pop());
     secondStack.Push(firstStack.Pop());
     secondStack.Push(firstStack.Pop());
     secondStack.Push(firstStack.Pop());
     secondStack.Push(firstStack.Pop());
     secondStack.Push(firstStack.Pop());
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
