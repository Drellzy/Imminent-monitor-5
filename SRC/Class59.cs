// Decompiled with JetBrains decompiler
// Type: Class59
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Runtime.CompilerServices;

internal sealed class Class59 : Class45
{
  private Enum enum_0;

  public Class59(Enum enum_1) => this.enum_0 = enum_1 ?? (Enum) Class59.Enum0.Value;

  public Enum method_2() => this.enum_0;

  public void method_3(Enum enum_1) => this.enum_0 = enum_1 != null ? enum_1 : throw new ArgumentException();

  [SpecialName]
  public override object vmethod_0() => (object) this.method_2();

  [SpecialName]
  public override void vmethod_1(object object_0) => this.method_3((Enum) Enum.Parse(this.method_2().GetType(), object_0.ToString()));

  [SpecialName]
  public override int vmethod_2() => 7;

  public override Class45 vmethod_3(Class45 class45_0)
  {
    this.method_1(class45_0.method_0());
    switch (class45_0.vmethod_2())
    {
      case 0:
        this.method_3((Enum) Enum.ToObject(this.enum_0.GetType(), ((Class51) class45_0).method_2()));
        break;
      case 1:
        this.method_3((Enum) Enum.ToObject(this.enum_0.GetType(), ((Class62) class45_0).method_2()));
        break;
      case 3:
        this.method_3((Enum) Enum.ToObject(this.enum_0.GetType(), ((Class63) class45_0).method_2()));
        break;
      case 4:
        this.method_3((Enum) Enum.ToObject(this.enum_0.GetType(), ((Class69) class45_0).method_2()));
        break;
      case 7:
        Type type = this.enum_0.GetType();
        Enum enum_1 = ((Class59) class45_0).method_2();
        if ((object) enum_1.GetType() == (object) type)
        {
          this.method_3(enum_1);
          break;
        }
        this.method_3((Enum) Enum.ToObject(type, (object) enum_1));
        break;
      case 9:
        this.method_3((Enum) Enum.ToObject(this.enum_0.GetType(), ((Class46) class45_0).method_2()));
        break;
      case 11:
        this.method_3((Enum) Enum.ToObject(this.enum_0.GetType(), ((Class64) class45_0).method_2()));
        break;
      case 14:
        this.method_3((Enum) Enum.ToObject(this.enum_0.GetType(), ((Class70) class45_0).method_2()));
        break;
      case 18:
        this.method_3((Enum) Enum.ToObject(this.enum_0.GetType(), ((Class61) class45_0).method_2()));
        break;
      case 20:
        this.method_3((Enum) Enum.ToObject(this.enum_0.GetType(), ((Class49) class45_0).method_2()));
        break;
      default:
        throw new ArgumentOutOfRangeException();
    }
    return (Class45) this;
  }

  public override Class45 vmethod_4()
  {
    Class59 class59 = new Class59(this.enum_0);
    class59.method_1(this.method_0());
    return (Class45) class59;
  }

  private enum Enum0
  {
    Value,
  }
}
