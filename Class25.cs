// Decompiled with JetBrains decompiler
// Type: Class25
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;

internal static class Class25
{
  public static Type smethod_0(Type type_0) => !type_0.IsByRef && !type_0.IsArray && !type_0.IsPointer ? type_0 : Class25.smethod_0(type_0.GetElementType());

  public static Type smethod_1(Type type_0)
  {
    if (type_0.HasElementType && !type_0.IsArray)
      type_0 = type_0.GetElementType();
    return type_0;
  }

  public static Class16<Struct2> smethod_2(Type type_0)
  {
    Class16<Struct2> class16_1 = new Class16<Struct2>();
    Type type = type_0;
    while (true)
    {
      Struct2 struct2;
      if (!type.IsArray)
      {
        if (type.IsByRef)
        {
          Class16<Struct2> class16_2 = class16_1;
          struct2 = new Struct2();
          struct2.int_0 = 0;
          Struct2 gparam_1 = struct2;
          class16_2.method_7(gparam_1);
        }
        else if (type.IsPointer)
        {
          Class16<Struct2> class16_3 = class16_1;
          struct2 = new Struct2();
          struct2.int_0 = 2;
          Struct2 gparam_1 = struct2;
          class16_3.method_7(gparam_1);
        }
        else
          break;
      }
      else
        goto label_6;
label_5:
      type = type.GetElementType();
      continue;
label_6:
      Class16<Struct2> class16_4 = class16_1;
      struct2 = new Struct2();
      struct2.int_0 = 1;
      struct2.int_1 = type.GetArrayRank();
      Struct2 gparam_1_1 = struct2;
      class16_4.method_7(gparam_1_1);
      goto label_5;
    }
    return class16_1;
  }

  public static Class16<Struct2> smethod_3(string string_0)
  {
    string str = string_0;
    Class16<Struct2> class16_1 = new Class16<Struct2>();
    while (true)
    {
      Struct2 struct2;
      while (!str.EndsWith("&", StringComparison.Ordinal))
      {
        if (str.EndsWith("*", StringComparison.Ordinal))
        {
          Class16<Struct2> class16_2 = class16_1;
          struct2 = new Struct2();
          struct2.int_0 = 2;
          Struct2 gparam_1 = struct2;
          class16_2.method_7(gparam_1);
          str = str.Substring(0, str.Length - 1);
        }
        else if (str.EndsWith("[]", StringComparison.Ordinal))
        {
          Class16<Struct2> class16_3 = class16_1;
          struct2 = new Struct2();
          struct2.int_0 = 1;
          struct2.int_1 = 1;
          Struct2 gparam_1 = struct2;
          class16_3.method_7(gparam_1);
          str = str.Substring(0, str.Length - 2);
        }
        else
        {
          if (!str.EndsWith(",]", StringComparison.Ordinal))
            return class16_1;
          int num = 1;
          int length = -1;
          for (int index = str.Length - 2; index >= 0; --index)
          {
            switch (str[index])
            {
              case ',':
                ++num;
                break;
              case '[':
                length = index;
                index = -1;
                break;
              default:
                throw new InvalidOperationException("VM-3012");
            }
          }
          str = length >= 0 ? str.Substring(0, length) : throw new InvalidOperationException("VM-3014");
          Class16<Struct2> class16_4 = class16_1;
          struct2 = new Struct2();
          struct2.int_0 = 1;
          struct2.int_1 = num;
          Struct2 gparam_1 = struct2;
          class16_4.method_7(gparam_1);
        }
      }
      Class16<Struct2> class16_5 = class16_1;
      struct2 = new Struct2();
      struct2.int_0 = 0;
      Struct2 gparam_1_1 = struct2;
      class16_5.method_7(gparam_1_1);
      str = str.Substring(0, str.Length - 1);
    }
  }

  public static Type smethod_4(Type type_0, Class16<Struct2> class16_0)
  {
    Type type = type_0;
    while (class16_0.Count > 0)
    {
      Struct2 struct2 = class16_0.method_6();
      switch (struct2.int_0)
      {
        case 0:
          type = type.MakeByRefType();
          continue;
        case 1:
          type = struct2.int_1 != 1 ? type.MakeArrayType(struct2.int_1) : type.MakeArrayType();
          continue;
        case 2:
          type = type.MakePointerType();
          continue;
        default:
          continue;
      }
    }
    return type;
  }
}
