// Decompiled with JetBrains decompiler
// Type: Class64
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Runtime.CompilerServices;

internal sealed class Class64 : Class45
{
  private uint uint_0;

  public uint method_2() => this.uint_0;

  public void method_3(uint uint_1) => this.uint_0 = uint_1;

  [SpecialName]
  public override object vmethod_0() => (object) this.method_2();

  [SpecialName]
  public override void vmethod_1(object object_0)
  {
    switch (object_0)
    {
      case short uint_1_1:
        this.method_3((uint) uint_1_1);
        break;
      case int uint_1_2:
        this.method_3((uint) uint_1_2);
        break;
      case long uint_1_3:
        this.method_3((uint) uint_1_3);
        break;
      case ulong uint_1_4:
        this.method_3((uint) uint_1_4);
        break;
      case float uint_1_5:
        this.method_3((uint) uint_1_5);
        break;
      case double uint_1_6:
        this.method_3((uint) uint_1_6);
        break;
      default:
        this.method_3(Convert.ToUInt32(object_0));
        break;
    }
  }

  public override Class45 vmethod_4()
  {
    Class64 class64 = new Class64();
    class64.method_3(this.uint_0);
    class64.method_1(this.method_0());
    return (Class45) class64;
  }

  [SpecialName]
  public override int vmethod_2() => 11;

  public override Class45 vmethod_3(Class45 class45_0)
  {
    this.method_1(class45_0.method_0());
    switch (class45_0.vmethod_2())
    {
      case 0:
        this.method_3((uint) ((Class51) class45_0).method_2());
        break;
      case 1:
        this.method_3((uint) ((Class62) class45_0).method_2());
        break;
      case 2:
        this.method_3((uint) (int) ((Class67) class45_0).method_2());
        break;
      case 3:
        this.method_3((uint) ((Class63) class45_0).method_2());
        break;
      case 4:
        this.method_3((uint) ((Class69) class45_0).method_2());
        break;
      case 5:
        this.method_3((uint) ((Class65) class45_0).method_2());
        break;
      case 7:
        this.method_3(Convert.ToUInt32((object) ((Class59) class45_0).method_2()));
        break;
      case 9:
        this.method_3((uint) ((Class46) class45_0).method_2());
        break;
      case 11:
        this.method_3(((Class64) class45_0).method_2());
        break;
      case 14:
        this.method_3((uint) ((Class70) class45_0).method_2());
        break;
      case 15:
        this.method_3((uint) ((Class50) class45_0).method_2());
        break;
      case 16:
        this.method_3((uint) ((Class48) class45_0).method_2());
        break;
      case 18:
        this.method_3((uint) ((Class61) class45_0).method_2());
        break;
      case 20:
        this.method_3(Convert.ToUInt32(((Class49) class45_0).method_2()));
        break;
      case 23:
        this.method_3((uint) Convert.ToByte(((Class47) class45_0).method_2()));
        break;
      default:
        throw new ArgumentOutOfRangeException();
    }
    return (Class45) this;
  }
}
