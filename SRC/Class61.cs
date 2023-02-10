// Decompiled with JetBrains decompiler
// Type: Class61
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Runtime.CompilerServices;

internal sealed class Class61 : Class45
{
  private sbyte sbyte_0;

  public sbyte method_2() => this.sbyte_0;

  public void method_3(sbyte sbyte_1) => this.sbyte_0 = sbyte_1;

  [SpecialName]
  public override object vmethod_0() => (object) this.method_2();

  [SpecialName]
  public override void vmethod_1(object object_0)
  {
    switch (object_0)
    {
      case byte sbyte_1_1:
        this.method_3((sbyte) sbyte_1_1);
        break;
      case short sbyte_1_2:
        this.method_3((sbyte) sbyte_1_2);
        break;
      case int sbyte_1_3:
        this.method_3((sbyte) sbyte_1_3);
        break;
      case long sbyte_1_4:
        this.method_3((sbyte) sbyte_1_4);
        break;
      case ushort sbyte_1_5:
        this.method_3((sbyte) sbyte_1_5);
        break;
      case uint sbyte_1_6:
        this.method_3((sbyte) sbyte_1_6);
        break;
      case ulong sbyte_1_7:
        this.method_3((sbyte) sbyte_1_7);
        break;
      case float sbyte_1_8:
        this.method_3((sbyte) sbyte_1_8);
        break;
      case double sbyte_1_9:
        this.method_3((sbyte) sbyte_1_9);
        break;
      default:
        this.method_3(Convert.ToSByte(object_0));
        break;
    }
  }

  public override Class45 vmethod_4()
  {
    Class61 class61 = new Class61();
    class61.method_3(this.sbyte_0);
    class61.method_1(this.method_0());
    return (Class45) class61;
  }

  [SpecialName]
  public override int vmethod_2() => 18;

  public override Class45 vmethod_3(Class45 class45_0)
  {
    this.method_1(class45_0.method_0());
    switch (class45_0.vmethod_2())
    {
      case 0:
        this.method_3((sbyte) ((Class51) class45_0).method_2());
        break;
      case 1:
        this.method_3((sbyte) ((Class62) class45_0).method_2());
        break;
      case 2:
        this.method_3((sbyte) (int) ((Class67) class45_0).method_2());
        break;
      case 3:
        this.method_3((sbyte) ((Class63) class45_0).method_2());
        break;
      case 4:
        this.method_3((sbyte) ((Class69) class45_0).method_2());
        break;
      case 7:
        this.method_3(Convert.ToSByte((object) ((Class59) class45_0).method_2()));
        break;
      case 9:
        this.method_3((sbyte) ((Class46) class45_0).method_2());
        break;
      case 11:
        this.method_3((sbyte) ((Class64) class45_0).method_2());
        break;
      case 14:
        this.method_3((sbyte) ((Class70) class45_0).method_2());
        break;
      case 15:
        this.method_3((sbyte) ((Class50) class45_0).method_2());
        break;
      case 16:
        this.method_3((sbyte) ((Class48) class45_0).method_2());
        break;
      case 18:
        this.method_3(((Class61) class45_0).method_2());
        break;
      case 20:
        this.method_3(Convert.ToSByte(((Class49) class45_0).method_2()));
        break;
      case 23:
        this.method_3(Convert.ToSByte(((Class47) class45_0).method_2()));
        break;
      default:
        throw new ArgumentOutOfRangeException();
    }
    return (Class45) this;
  }
}
