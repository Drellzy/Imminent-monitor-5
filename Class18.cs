// Decompiled with JetBrains decompiler
// Type: Class18
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;

internal static class Class18
{
  private static readonly bool bool_0;

  static Class18()
  {
    try
    {
      Class18.bool_0 = Type.GetType("Mono.Runtime") != null;
    }
    catch
    {
      Class18.bool_0 = false;
    }
  }

  public static bool smethod_0() => Class18.bool_0;
}
