// Decompiled with JetBrains decompiler
// Type: Class78
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;

internal static class Class78
{
  private static int int_0;
  private static int int_1;

  public static void smethod_0(ref byte byte_0)
  {
    byte_0 = (byte) Class78.int_0;
    Class78.int_1 = (int) byte_0;
  }

  public static void smethod_1(ref int int_2)
  {
    int_2 = Class78.int_0;
    Class78.int_1 = int_2;
  }

  public static void smethod_2(ref long long_0)
  {
    long_0 = (long) Class78.int_0;
    Class78.int_1 = (int) long_0;
  }

  public static void smethod_3(ref char char_0)
  {
    char_0 = (char) Class78.int_0;
    Class78.int_1 = (int) char_0;
  }

  public static void smethod_4(Array array_0, int int_2, int int_3) => Array.Clear(array_0, int_2, int_3);

  public static void smethod_5(Array array_0) => Class78.smethod_4(array_0, 0, array_0.GetLength(0));
}
