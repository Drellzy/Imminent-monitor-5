// Decompiled with JetBrains decompiler
// Type: Class1
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

internal static class Class1
{
  private static Class1.Class9 class9_0 = new Class1.Class9();

  internal static long smethod_0()
  {
    if ((object) Assembly.GetCallingAssembly() != (object) typeof (Class1).Assembly || !Class1.smethod_2())
      return 0;
    lock (Class1.class9_0)
    {
      long long_0 = Class1.class9_0.method_0();
      if (long_0 == 0L)
      {
        Assembly executingAssembly = Assembly.GetExecutingAssembly();
        List<byte> byteList = new List<byte>();
        AssemblyName assemblyName;
        try
        {
          assemblyName = executingAssembly.GetName();
        }
        catch
        {
          assemblyName = new AssemblyName(executingAssembly.FullName);
        }
        byte[] collection = assemblyName.GetPublicKeyToken();
        if (collection != null && collection.Length == 0)
          collection = (byte[]) null;
        if (collection != null)
          byteList.AddRange((IEnumerable<byte>) collection);
        byteList.AddRange((IEnumerable<byte>) Encoding.Unicode.GetBytes(assemblyName.Name));
        int num1 = Class1.smethod_4(typeof (Class1));
        int num2 = Class1.Class3.smethod_0();
        byteList.Add((byte) (num1 >> 24));
        byteList.Add((byte) (num2 >> 8));
        byteList.Add((byte) num1);
        byteList.Add((byte) (num2 >> 16));
        byteList.Add((byte) (num1 >> 16));
        byteList.Add((byte) num2);
        byteList.Add((byte) (num1 >> 8));
        byteList.Add((byte) (num2 >> 24));
        int count = byteList.Count;
        ulong num3 = 0;
        for (int index = 0; index != count; ++index)
        {
          ulong num4 = num3 + (ulong) byteList[index];
          ulong num5 = num4 + (num4 << 20);
          num3 = num5 ^ num5 >> 12;
          byteList[index] = (byte) 0;
        }
        ulong num6 = num3 + (num3 << 6);
        ulong num7 = num6 ^ num6 >> 22;
        long_0 = (long) (num7 + (num7 << 30)) ^ 3244831955564598067L;
        Class1.class9_0.method_1(long_0);
      }
      return long_0;
    }
  }

  internal static void smethod_1(byte[] byte_0)
  {
    if ((object) Assembly.GetCallingAssembly() != (object) typeof (Class1).Assembly || !Class1.smethod_2())
      return;
    long num = Class1.smethod_0();
    byte[] numArray = new byte[8]
    {
      (byte) num,
      (byte) (num >> 40),
      (byte) (num >> 56),
      (byte) (num >> 48),
      (byte) (num >> 32),
      (byte) (num >> 24),
      (byte) (num >> 16),
      (byte) (num >> 8)
    };
    int length = byte_0.Length;
    for (int index = 0; index != length; ++index)
      byte_0[index] ^= (byte) ((uint) numArray[index & 7] + (uint) index);
  }

  private static bool smethod_2() => Class1.smethod_3();

  private static bool smethod_3()
  {
    StackFrame frame = new StackTrace().GetFrame(3);
    MethodBase methodBase = frame == null ? (MethodBase) null : frame.GetMethod();
    Type type = (object) methodBase == null ? (Type) null : methodBase.DeclaringType;
    return (object) type != (object) typeof (RuntimeMethodHandle) && (object) type != null && (object) type.Assembly == (object) typeof (Class1).Assembly;
  }

  private static int smethod_4(Type type_0) => type_0.MetadataToken;

  private static class Class2
  {
    internal static int smethod_0(int int_0, int int_1) => int_0 ^ int_1 - -461118703;

    internal static int smethod_1(int int_0, int int_1) => int_0 - 234719712 ^ int_1 + 28393733;

    internal static int smethod_2(int int_0, int int_1) => int_0 ^ int_1 - 881348926 ^ int_0 - int_1;
  }

  private sealed class Class3
  {
    internal static int smethod_0() => Class1.Class2.smethod_2(Class1.Class2.smethod_1(Class1.smethod_4(typeof (Class1.Class7)), Class1.Class2.smethod_2(Class1.smethod_4(typeof (Class1.Class3)), Class1.smethod_4(typeof (Class1.Class6)))), Class1.Class5.smethod_0());
  }

  private sealed class Class4
  {
    internal static int smethod_0() => Class1.Class2.smethod_2(Class1.smethod_4(typeof (Class1.Class4)), Class1.Class2.smethod_0(Class1.smethod_4(typeof (Class1.Class3)), Class1.Class2.smethod_1(Class1.smethod_4(typeof (Class1.Class7)), Class1.Class2.smethod_2(Class1.smethod_4(typeof (Class1.Class8)), Class1.Class2.smethod_0(Class1.smethod_4(typeof (Class1.Class6)), Class1.smethod_4(typeof (Class1.Class5)))))));
  }

  private sealed class Class5
  {
    internal static int smethod_0() => Class1.Class2.smethod_0(Class1.smethod_4(typeof (Class1.Class5)), Class1.Class2.smethod_2(Class1.Class2.smethod_1(Class1.smethod_4(typeof (Class1.Class6)), Class1.smethod_4(typeof (Class1.Class3))), Class1.Class2.smethod_2(Class1.smethod_4(typeof (Class1.Class8)) ^ -1425038354, Class1.Class6.smethod_0())));
  }

  private sealed class Class6
  {
    internal static int smethod_0() => Class1.Class2.smethod_1(Class1.Class2.smethod_1(Class1.Class8.smethod_0(), Class1.Class2.smethod_0(Class1.smethod_4(typeof (Class1.Class6)), Class1.Class7.smethod_0())), Class1.smethod_4(typeof (Class1.Class5)));
  }

  private sealed class Class7
  {
    internal static int smethod_0() => Class1.Class2.smethod_0(Class1.smethod_4(typeof (Class1.Class8)), Class1.smethod_4(typeof (Class1.Class4)) ^ Class1.Class2.smethod_1(Class1.smethod_4(typeof (Class1.Class7)), Class1.Class2.smethod_2(Class1.smethod_4(typeof (Class1.Class5)), Class1.Class4.smethod_0())));
  }

  private sealed class Class8
  {
    internal static int smethod_0() => Class1.Class2.smethod_2(Class1.Class2.smethod_0(Class1.Class7.smethod_0() ^ 527758446, Class1.smethod_4(typeof (Class1.Class4))), Class1.Class2.smethod_1(Class1.smethod_4(typeof (Class1.Class3)) ^ Class1.smethod_4(typeof (Class1.Class5)), -1456058191));
  }

  private sealed class Class9
  {
    private int int_0;
    private int int_1;

    internal Class9() => this.method_1(0L);

    internal long method_0()
    {
      if ((object) Assembly.GetCallingAssembly() != (object) typeof (Class1.Class9).Assembly || !Class1.smethod_2())
        return 2918384;
      int[] numArray = new int[4]{ 0, 0, 0, -1533493173 };
      numArray[1] = 2034668806;
      numArray[2] = -1505905167;
      numArray[0] = 380393196;
      int int0 = this.int_0;
      int int1 = this.int_1;
      int num1 = -1640531527;
      int num2 = -957401312;
      for (int index = 0; index != 32; ++index)
      {
        int1 -= (int0 << 4 ^ int0 >> 5) + int0 ^ num2 + numArray[num2 >> 11 & 3];
        num2 -= num1;
        int0 -= (int1 << 4 ^ int1 >> 5) + int1 ^ num2 + numArray[num2 & 3];
      }
      for (int index = 0; index != 4; ++index)
        numArray[index] = 0;
      return (long) ((ulong) int1 << 32 | (ulong) (uint) int0);
    }

    internal void method_1(long long_0)
    {
      if ((object) Assembly.GetCallingAssembly() != (object) typeof (Class1.Class9).Assembly || !Class1.smethod_2())
        return;
      int[] numArray = new int[4]{ 0, 2034668806, 0, 0 };
      numArray[0] = 380393196;
      numArray[2] = -1505905167;
      numArray[3] = -1533493173;
      int num1 = -1640531527;
      int num2 = (int) long_0;
      int num3 = (int) (long_0 >> 32);
      int num4 = 0;
      for (int index = 0; index != 32; ++index)
      {
        num2 += (num3 << 4 ^ num3 >> 5) + num3 ^ num4 + numArray[num4 & 3];
        num4 += num1;
        num3 += (num2 << 4 ^ num2 >> 5) + num2 ^ num4 + numArray[num4 >> 11 & 3];
      }
      for (int index = 0; index != 4; ++index)
        numArray[index] = 0;
      this.int_0 = num2;
      this.int_1 = num3;
    }
  }
}
