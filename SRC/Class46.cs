// Decompiled with JetBrains decompiler
// Type: Class46
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Runtime.CompilerServices;

internal sealed class Class46 : Class45
{
  private int int_0;

  public int method_2() => this.int_0;

  public void method_3(int int_1) => this.int_0 = int_1;

  [SpecialName]
  public override object vmethod_0() => (object) this.method_2();

  [SpecialName]
  public override void vmethod_1(object object_0)
  {
    switch (object_0)
    {
      case long int_1_1:
        this.method_3((int) int_1_1);
        break;
      case ushort int_1_2:
        this.method_3((int) int_1_2);
        break;
      case uint int_1_3:
        this.method_3((int) int_1_3);
        break;
      case ulong int_1_4:
        this.method_3((int) int_1_4);
        break;
      case float int_1_5:
        this.method_3((int) int_1_5);
        break;
      case double int_1_6:
        this.method_3((int) int_1_6);
        break;
      default:
        this.method_3(Convert.ToInt32(object_0));
        break;
    }
  }

  public override Class45 vmethod_4()
  {
    Class46 class46 = new Class46();
    class46.method_3(this.int_0);
    class46.method_1(this.method_0());
    return (Class45) class46;
  }

  [SpecialName]
  public override int vmethod_2() => 9;

  public override Class45 vmethod_3(Class45 class45_0)
  {
    this.method_1(class45_0.method_0());
    switch (class45_0.vmethod_2())
    {
      case 0:
        this.method_3((int) ((Class51) class45_0).method_2());
        break;
      case 1:
        this.method_3((int) ((Class62) class45_0).method_2());
        break;
      case 2:
        this.method_3((int) ((Class67) class45_0).method_2());
        break;
      case 3:
        this.method_3(Convert.ToInt32(((Class63) class45_0).method_2()));
        break;
      case 4:
        this.method_3((int) ((Class69) class45_0).method_2());
        break;
      case 5:
        this.method_3((int) (uint) ((Class65) class45_0).method_2());
        break;
      case 7:
        this.method_3(Convert.ToInt32((object) ((Class59) class45_0).method_2()));
        break;
      case 9:
        this.method_3(((Class46) class45_0).method_2());
        break;
      case 11:
        this.method_3((int) ((Class64) class45_0).method_2());
        break;
      case 14:
        this.method_3((int) ((Class70) class45_0).method_2());
        break;
      case 15:
        this.method_3((int) ((Class50) class45_0).method_2());
        break;
      case 16:
        this.method_3((int) ((Class48) class45_0).method_2());
        break;
      case 18:
        this.method_3((int) ((Class61) class45_0).method_2());
        break;
      case 20:
        this.method_3(Convert.ToInt32(((Class49) class45_0).method_2()));
        break;
      case 23:
        this.method_3((int) Convert.ToByte(((Class47) class45_0).method_2()));
        break;
      default:
        throw new ArgumentOutOfRangeException();
    }
    return (Class45) this;
  }
}
