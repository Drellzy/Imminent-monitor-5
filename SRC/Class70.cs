// Decompiled with JetBrains decompiler
// Type: Class70
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Runtime.CompilerServices;

internal sealed class Class70 : Class45
{
  private short short_0;

  public short method_2() => this.short_0;

  public void method_3(short short_1) => this.short_0 = short_1;

  [SpecialName]
  public override object vmethod_0() => (object) this.method_2();

  [SpecialName]
  public override void vmethod_1(object object_0)
  {
    switch (object_0)
    {
      case int short_1_1:
        this.method_3((short) short_1_1);
        break;
      case long short_1_2:
        this.method_3((short) short_1_2);
        break;
      case ushort short_1_3:
        this.method_3((short) short_1_3);
        break;
      case uint short_1_4:
        this.method_3((short) short_1_4);
        break;
      case ulong short_1_5:
        this.method_3((short) short_1_5);
        break;
      case float short_1_6:
        this.method_3((short) short_1_6);
        break;
      case double short_1_7:
        this.method_3((short) short_1_7);
        break;
      default:
        this.method_3(Convert.ToInt16(object_0));
        break;
    }
  }

  public override Class45 vmethod_4()
  {
    Class70 class70 = new Class70();
    class70.method_3(this.short_0);
    class70.method_1(this.method_0());
    return (Class45) class70;
  }

  [SpecialName]
  public override int vmethod_2() => 14;

  public override Class45 vmethod_3(Class45 class45_0)
  {
    this.method_1(class45_0.method_0());
    switch (class45_0.vmethod_2())
    {
      case 0:
        this.method_3((short) ((Class51) class45_0).method_2());
        break;
      case 1:
        this.method_3((short) ((Class62) class45_0).method_2());
        break;
      case 2:
        this.method_3((short) (int) ((Class67) class45_0).method_2());
        break;
      case 3:
        this.method_3((short) ((Class63) class45_0).method_2());
        break;
      case 4:
        this.method_3((short) ((Class69) class45_0).method_2());
        break;
      case 7:
        this.method_3(Convert.ToInt16((object) ((Class59) class45_0).method_2()));
        break;
      case 9:
        this.method_3((short) ((Class46) class45_0).method_2());
        break;
      case 11:
        this.method_3((short) ((Class64) class45_0).method_2());
        break;
      case 14:
        this.method_3(((Class70) class45_0).method_2());
        break;
      case 15:
        this.method_3((short) ((Class50) class45_0).method_2());
        break;
      case 16:
        this.method_3((short) ((Class48) class45_0).method_2());
        break;
      case 18:
        this.method_3((short) ((Class61) class45_0).method_2());
        break;
      case 20:
        this.method_3(Convert.ToInt16(((Class49) class45_0).method_2()));
        break;
      case 23:
        this.method_3((short) Convert.ToByte(((Class47) class45_0).method_2()));
        break;
      default:
        throw new ArgumentOutOfRangeException();
    }
    return (Class45) this;
  }
}
