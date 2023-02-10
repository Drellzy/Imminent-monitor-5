// Decompiled with JetBrains decompiler
// Type: Class24
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;

internal static class Class24
{
  public static bool smethod_0(Type type_0, Type type_1)
  {
    if ((object) type_0 == (object) type_1)
      return true;
    if ((object) type_0 == null || (object) type_1 == null)
      return false;
    if (type_0.IsByRef)
      return type_1.IsByRef && Class24.smethod_0(type_0.GetElementType(), type_1.GetElementType());
    if (type_1.IsByRef)
      return false;
    if (type_0.IsPointer)
      return type_1.IsPointer && Class24.smethod_0(type_0.GetElementType(), type_1.GetElementType());
    if (type_1.IsPointer)
      return false;
    if (type_0.IsArray)
      return type_1.IsArray && type_0.GetArrayRank() == type_1.GetArrayRank() && Class24.smethod_0(type_0.GetElementType(), type_1.GetElementType());
    if (type_1.IsArray)
      return false;
    if (type_0.IsGenericType && !type_0.IsGenericTypeDefinition)
      type_0 = type_0.GetGenericTypeDefinition();
    if (type_1.IsGenericType && !type_1.IsGenericTypeDefinition)
      type_1 = type_1.GetGenericTypeDefinition();
    return (object) type_0 == (object) type_1;
  }
}
