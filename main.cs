using System;
using static Helpers;

class Program {
  public static void Main (string[] args) {
    string name = "";
    int idade = 0;

    Head();
    name = Read();
    idade = ReadInt();
    Line();
    Write(name + " A METADE DA SUA IDADE É " + (idade/2));

  }

  
}
