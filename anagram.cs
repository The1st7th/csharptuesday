using System;
using System.Collections.Generic;



class Progam
{
  static void swap(List<char> l, int int1, int int2){

  char slit = l[int1];
    l[int1] = l[int2];
    l[int2] = slit;
  }
  static void swapback(List<char> l, int int1, int int2){

  char slit = l[int2];
    l[int2] = l[int1];
    l[int1] = slit;
  }


  public static void Main()
  {


   List<char> letter= new List<char>();

   string wordInput;
   wordInput = Console.ReadLine();
   Console.WriteLine("answer here");
   foreach(char l in wordInput)
   {
     letter.Add(l);
   }

  for (var i = 0; i < letter.Count-1; i++){
    for( var j = i+1; j < letter.Count -1; j++){
      int r = j+1;
      int y = i+1;
     swap(letter,y,r);
  string Something = string.Join("", letter);
  Console.WriteLine(Something);
  swapback(letter,y,r);
  }
}
}
}



//  foreach(char l in letter)
//  {
//    Console.WriteLine(l);
 //
//  }
