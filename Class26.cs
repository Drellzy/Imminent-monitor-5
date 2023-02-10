// Decompiled with JetBrains decompiler
// Type: Class26
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Threading;

internal static class Class26
{
  public static Interface2 smethod_0() => Class26.smethod_1() ?? (Interface2) new Class74();

  private static Interface2 smethod_1()
  {
    try
    {
      Class44 interface2_0 = new Class44();
      if (Class26.smethod_3((Interface2) interface2_0))
        return (Interface2) interface2_0;
      interface2_0.Dispose();
      return (Interface2) null;
    }
    catch (Exception ex) when (!Class26.smethod_2(ex))
    {
      return (Interface2) null;
    }
  }

  private static bool smethod_2(Exception exception_0) => exception_0 is ThreadAbortException || exception_0 is ThreadInterruptedException;

  private static bool smethod_3(Interface2 interface2_0)
  {
    byte[] numArray = new byte[3]
    {
      (byte) 0,
      (byte) 130,
      byte.MaxValue
    };
    for (int int_0 = 0; int_0 < numArray.Length; ++int_0)
    {
      byte byte_0 = numArray[int_0];
      interface2_0.imethod_2(int_0, ref byte_0);
    }
    if (interface2_0.imethod_0() != numArray.Length)
      return false;
    for (int int_0 = 0; int_0 < numArray.Length; ++int_0)
    {
      byte byte_0;
      interface2_0.imethod_1(int_0, out byte_0);
      if ((int) byte_0 != (int) numArray[int_0])
        return false;
    }
    interface2_0.imethod_3();
    return interface2_0.imethod_0() == 0;
  }
}
