// Decompiled with JetBrains decompiler
// Type: Class62
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Runtime.CompilerServices;

internal sealed class Class62 : Class45
{
  private ulong ulong_0;

  public ulong method_2() => this.ulong_0;

  public void method_3(ulong ulong_1) => this.ulong_0 = ulong_1;

  [SpecialName]
  public override object vmethod_0() => (object) this.method_2();

  [SpecialName]
  public override void vmethod_1(object object_0)
  {
    switch (object_0)
    {
      case short ulong_1_1:
        this.method_3((ulong) ulong_1_1);
        break;
      case int ulong_1_2:
        this.method_3((ulong) ulong_1_2);
        break;
      case long ulong_1_3:
        this.method_3((ulong) ulong_1_3);
        break;
      case float ulong_1_4:
        this.method_3((ulong) ulong_1_4);
        break;
      case double ulong_1_5:
        this.method_3((ulong) ulong_1_5);
        break;
      default:
        this.method_3(Convert.ToUInt64(object_0));
        break;
    }
  }

  public override Class45 vmethod_4()
  {
    Class62 class62 = new Class62();
    class62.method_3(this.ulong_0);
    class62.method_1(this.method_0());
    return (Class45) class62;
  }

  [SpecialName]
  public override int vmethod_2() => 1;

  public override Class45 vmethod_3(Class45 class45_0)
  {
    this.method_1(class45_0.method_0());
    switch (class45_0.vmethod_2())
    {
      case 0:
        this.method_3((ulong) ((Class51) class45_0).method_2());
        break;
      case 1:
        this.method_3(((Class62) class45_0).method_2());
        break;
      case 2:
        this.method_3((ulong) (long) ((Class67) class45_0).method_2());
        break;
      case 3:
        this.method_3((ulong) ((Class63) class45_0).method_2());
        break;
      case 4:
        this.method_3((ulong) ((Class69) class45_0).method_2());
        break;
      case 5:
        this.method_3((ulong) ((Class65) class45_0).method_2());
        break;
      case 7:
        this.method_3(Convert.ToUInt64((object) ((Class59) class45_0).method_2()));
        break;
      case 9:
        this.method_3((ulong) ((Class46) class45_0).method_2());
        break;
      case 11:
        this.method_3((ulong) ((Class64) class45_0).method_2());
        break;
      case 14:
        this.method_3((ulong) ((Class70) class45_0).method_2());
        break;
      case 15:
        this.method_3((ulong) ((Class50) class45_0).method_2());
        break;
      case 16:
        this.method_3((ulong) ((Class48) class45_0).method_2());
        break;
      case 18:
        this.method_3((ulong) ((Class61) class45_0).method_2());
        break;
      case 20:
        this.method_3(Convert.ToUInt64(((Class49) class45_0).method_2()));
        break;
      case 23:
        this.method_3((ulong) Convert.ToByte(((Class47) class45_0).method_2()));
        break;
      default:
        throw new ArgumentOutOfRangeException();
    }
    return (Class45) this;
  }
}
