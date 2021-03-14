using System;

namespace ProCool 
{
  class morePro 
  {
    static void Function() 
    {
      Console.WriteLine("[FUNCTION] This is a function");
    }
    
    static void Main(string[] args) 
    {
      int x = 10;
      int y = 10;
      
      if(x > y) {
        Console.WriteLine("x is greater than y");
      } else if(x < y) {
        Console.WriteLine("y is greater than x");
      } else {
        Console.WriteLine("they're equal idiot");
      }
      
      for(int i = 0; i < 5; i++) {
        Console.WriteLine("[FOR LOOP] i = " + i);
      }
      
      int o = 0;
      while(o < 5) {
        Console.WriteLine("[WHILE LOOP] o = " + o);
        o++;
      }
      
      Function();
      
      int day = 7;
      switch (day) 
      {
        case 1:
          Console.WriteLine("[SWITCH INT]mMonday");
          break;
        case 2:
          Console.WriteLine("[SWITCH INT] Tuesday");
          break;
        case 3:
          Console.WriteLine("[SWITCH INT] Wednesday");
          break;
        case 4:
          Console.WriteLine("[SWITCH INT] Thursday");
          break;
        case 5:
          Console.WriteLine("[SWITCH INT] Friday");
          break;
        case 6:
          Console.WriteLine("[SWITCH INT] Saturday");
          break;
        case 7:
          Console.WriteLine("[SWITCH INT] Sunday");
          break;
        default: 
          Console.WriteLine("[SWITCH INT] There is no such date as " + day);
          break;
      }
      
      string item = "banana";
      switch(item) 
      {
        case "banana":
          Console.WriteLine("[SWITCH STRING] The item is a banana");
          break;
        case "carrot":
          Console.WriteLine("[SWITCH STRING] The item is a carrot");
          break;
      }
      
      string[] food = { "carrot", "burger", "pizza", "banana", "cow" };
      foreach(string i in food) 
      {
        Console.WriteLine("[FOREACH] " + i);
      }
      
      Console.WriteLine("[SPECIFIC ITEM FROM ARRAY] " + food[0]);
      
      Console.WriteLine(args);
      
      string str = "you are fat";
      foreach (string i in str.Split(" ")) {
        Console.WriteLine("[FOREACH SPLIT] " + i);
      }
      
      string[] array = {"Number1", "Number2", "Number3"};
      Console.WriteLine("[ARRAY LENGTH] " + array.Length);
      string JoiningArray = string.Join(" - ", array);
      Console.WriteLine("[JOINING ARRAY] " + JoiningArray);
      
      for(int num = 0; num < 5; num++) {
        Console.WriteLine("[FOR LOOP ADDING NUMBERS] " + num);
      }
      
      for(int num = -5; num < 1; num++) {
        Console.WriteLine("[FOR LOOP NEGATIVE NUMBERS] " + num);
      }
      
      for(int num = -5; num < 6; num++) {
        Console.WriteLine("[FOR LOOPS NEGATIVE AND POSITIVE NUMBERS] " + num);
      }
      
      
    }
  }
}