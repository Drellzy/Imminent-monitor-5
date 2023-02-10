// Decompiled with JetBrains decompiler
// Type: Class71
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal sealed class Class71 : Class45
{
  private object object_0;

  public Class71(object object_1)
  {
    switch (object_1)
    {
      case null:
      case ValueType _:
        this.object_0 = object_1;
        break;
      default:
        throw new ArgumentException();
    }
  }

  public object method_2() => this.object_0;

  public void method_3(object object_1)
  {
    switch (object_1)
    {
      case null:
      case ValueType _:
        this.object_0 = object_1;
        break;
      default:
        throw new ArgumentException();
    }
  }

  [SpecialName]
  public override object vmethod_0() => this.method_2();

  [SpecialName]
  public override void vmethod_1(object object_1) => this.method_3(object_1);

  [SpecialName]
  public override int vmethod_2() => 24;

  public override Class45 vmethod_3(Class45 class45_0)
  {
    this.method_1(class45_0.method_0());
    switch (class45_0.vmethod_2())
    {
      case 20:
        this.method_3(((Class49) class45_0).method_2());
        break;
      case 24:
        if (this.method_2() != null)
        {
          object object_1 = ((Class71) class45_0).method_2();
          Type type = this.method_2().GetType();
          if (object_1 != null && !type.IsPrimitive && !type.IsEnum && type.IsAssignableFrom(object_1.GetType()))
          {
            foreach (FieldInfo field in type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy | BindingFlags.GetField | BindingFlags.SetField))
              field.SetValue(this.method_2(), field.GetValue(object_1));
            break;
          }
          this.method_3(object_1);
          break;
        }
        this.method_3(((Class71) class45_0).method_2());
        break;
      default:
        this.method_3(class45_0.vmethod_0());
        break;
    }
    return (Class45) this;
  }

  public override Class45 vmethod_4()
  {
    Class71 class71 = new Class71(this.object_0);
    class71.method_1(this.method_0());
    return (Class45) class71;
  }
}
