// Decompiled with JetBrains decompiler
// Type: L7_1.Program
// Assembly: L7-1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7508F3E9-5F4C-4DC2-8CEC-EB0E47151399
// Assembly location: C:\Users\shaba\Documents\Programming\Lesson7\L7-1\L7-1\bin\Debug\net5.0\L7-1.dll

using System;

namespace L7_1
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("Введите первое число:");
      float single1 = Convert.ToSingle(Console.ReadLine());
      Console.WriteLine("Введите второе число:");
      float single2 = Convert.ToSingle(Console.ReadLine());
      Console.WriteLine(string.Format("Произведение чисел равно: {0}", (object) (float) ((double) single1 * (double) single2)));
    }
  }
}
