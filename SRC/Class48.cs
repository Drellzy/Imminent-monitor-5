// Decompiled with JetBrains decompiler
// Type: Class48
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Runtime.CompilerServices;

internal sealed class Class48 : Class45
{
  private double double_0;

  public double method_2() => this.double_0;

  public void method_3(double double_1) => this.double_0 = double_1;

  [SpecialName]
  public override object vmethod_0() => (object) this.method_2();

  [SpecialName]
  public override void vmethod_1(object object_0) => this.method_3(Convert.ToDouble(object_0));

  public override Class45 vmethod_4()
  {
    Class48 class48 = new Class48();
    class48.method_3(this.double_0);
    class48.method_1(this.method_0());
    return (Class45) class48;
  }

  [SpecialName]
  public override int vmethod_2() => 16;

  public override Class45 vmethod_3(Class45 class45_0)
  {
    this.method_1(class45_0.method_0());
    switch (class45_0.vmethod_2())
    {
      case 0:
        this.method_3((double) ((Class51) class45_0).method_2());
        break;
      case 1:
        this.method_3((double) ((Class62) class45_0).method_2());
        break;
      case 3:
        this.method_3((double) ((Class63) class45_0).method_2());
        break;
      case 4:
        this.method_3((double) ((Class69) class45_0).method_2());
        break;
      case 9:
        this.method_3((double) ((Class46) class45_0).method_2());
        break;
      case 11:
        this.method_3((double) ((Class64) class45_0).method_2());
        break;
      case 14:
        this.method_3((double) ((Class70) class45_0).method_2());
        break;
      case 15:
        this.method_3((double) ((Class50) class45_0).method_2());
        break;
      case 16:
        this.method_3(((Class48) class45_0).method_2());
        break;
      case 18:
        this.method_3((double) ((Class61) class45_0).method_2());
        break;
      case 20:
        this.method_3((double) ((Class49) class45_0).method_2());
        break;
      default:
        throw new ArgumentOutOfRangeException();
    }
    return (Class45) this;
  }
}
