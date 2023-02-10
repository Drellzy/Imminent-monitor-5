// Decompiled with JetBrains decompiler
// Type: Class50
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Runtime.CompilerServices;

internal sealed class Class50 : Class45
{
  private float float_0;

  public float method_2() => this.float_0;

  public void method_3(float float_1) => this.float_0 = float_1;

  [SpecialName]
  public override object vmethod_0() => (object) this.method_2();

  [SpecialName]
  public override void vmethod_1(object object_0) => this.method_3(Convert.ToSingle(object_0));

  public override Class45 vmethod_4()
  {
    Class50 class50 = new Class50();
    class50.method_3(this.float_0);
    class50.method_1(this.method_0());
    return (Class45) class50;
  }

  [SpecialName]
  public override int vmethod_2() => 15;

  public override Class45 vmethod_3(Class45 class45_0)
  {
    this.method_1(class45_0.method_0());
    switch (class45_0.vmethod_2())
    {
      case 0:
        this.method_3((float) ((Class51) class45_0).method_2());
        break;
      case 1:
        this.method_3((float) ((Class62) class45_0).method_2());
        break;
      case 3:
        this.method_3((float) ((Class63) class45_0).method_2());
        break;
      case 4:
        this.method_3((float) ((Class69) class45_0).method_2());
        break;
      case 7:
        this.method_3(Convert.ToSingle((object) ((Class59) class45_0).method_2()));
        break;
      case 9:
        this.method_3((float) ((Class46) class45_0).method_2());
        break;
      case 11:
        this.method_3((float) ((Class64) class45_0).method_2());
        break;
      case 14:
        this.method_3((float) ((Class70) class45_0).method_2());
        break;
      case 15:
        this.method_3(((Class50) class45_0).method_2());
        break;
      case 16:
        this.method_3((float) ((Class48) class45_0).method_2());
        break;
      case 18:
        this.method_3((float) ((Class61) class45_0).method_2());
        break;
      case 20:
        this.method_3((float) ((Class49) class45_0).method_2());
        break;
      default:
        throw new ArgumentOutOfRangeException();
    }
    return (Class45) this;
  }
}
