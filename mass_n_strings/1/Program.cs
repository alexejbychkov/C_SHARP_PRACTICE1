using System;

public class Massive
{
   public static void Main()
   {
      string s = "j7aNAmai2";
      char[] chars = s.ToCharArray();
      Console.WriteLine("Введенная строка: {0}", s);
      Console.WriteLine("Массив символов: ");
      for (int ctr = 0; ctr < chars.Length; ctr++)
      {
         Console.WriteLine("   {0}: {1}", ctr, chars[ctr]);
      }
   }
}