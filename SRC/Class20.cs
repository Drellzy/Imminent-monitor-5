// Decompiled with JetBrains decompiler
// Type: Class20
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Reflection;

internal static class Class20
{
  public static readonly Type type_0 = typeof (object);
  public static readonly Type type_1 = typeof (Nullable<>);
  public static readonly Type type_2 = typeof (TypedReference);
  public static readonly Type type_3 = typeof (Enum);
  public static readonly Type type_4 = typeof (ValueType);
  public static readonly Assembly assembly_0 = typeof (Class20).Assembly;

  public static bool smethod_0(Type type_5) => type_5.IsGenericType && (object) type_5.GetGenericTypeDefinition() == (object) Class20.type_1;
}
