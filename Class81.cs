// Decompiled with JetBrains decompiler
// Type: Class81
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal static class Class81
{
  public static void smethod_0(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
  {
    if (Class18.smethod_0())
    {
      int metadataToken = FieldInfo.GetFieldFromHandle(runtimeFieldHandle_0).MetadataToken;
    }
    RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
  }
}
