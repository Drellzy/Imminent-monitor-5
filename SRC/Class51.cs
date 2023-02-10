// Decompiled with JetBrains decompiler
// Type: Class51
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Runtime.CompilerServices;

internal sealed class Class51 : Class45
{
  private byte byte_0;

  public byte method_2() => this.byte_0;

  public void method_3(byte byte_1) => this.byte_0 = byte_1;

  public override Class45 vmethod_4()
  {
    Class51 class51 = new Class51();
    class51.method_3(this.byte_0);
    class51.method_1(this.method_0());
    return (Class45) class51;
  }

  [SpecialName]
  public override object vmethod_0() => (object) this.method_2();

  [SpecialName]
  public override void vmethod_1(object object_0)
  {
    switch (object_0)
    {
      case short byte_1_1:
        this.method_3((byte) byte_1_1);
        break;
      case int byte_1_2:
        this.method_3((byte) byte_1_2);
        break;
      case long byte_1_3:
        this.method_3((byte) byte_1_3);
        break;
      case ushort byte_1_4:
        this.method_3((byte) byte_1_4);
        break;
      case uint byte_1_5:
        this.method_3((byte) byte_1_5);
        break;
      case ulong byte_1_6:
        this.method_3((byte) byte_1_6);
        break;
      case float byte_1_7:
        this.method_3((byte) byte_1_7);
        break;
      case double byte_1_8:
        this.method_3((byte) byte_1_8);
        break;
      default:
        this.method_3(Convert.ToByte(object_0));
        break;
    }
  }

  [SpecialName]
  public override int vmethod_2() => 0;

  public override Class45 vmethod_3(Class45 class45_0)
  {
    this.method_1(class45_0.method_0());
    switch (class45_0.vmethod_2())
    {
      case 0:
        this.method_3(((Class51) class45_0).method_2());
        break;
      case 1:
        this.method_3((byte) ((Class62) class45_0).method_2());
        break;
      case 2:
        this.method_3((byte) (int) ((Class67) class45_0).method_2());
        break;
      case 3:
        this.method_3((byte) ((Class63) class45_0).method_2());
        break;
      case 4:
        this.method_3((byte) ((Class69) class45_0).method_2());
        break;
      case 5:
        this.method_3((byte) (uint) ((Class65) class45_0).method_2());
        break;
      case 7:
        this.method_3(Convert.ToByte((object) ((Class59) class45_0).method_2()));
        break;
      case 9:
        this.method_3((byte) ((Class46) class45_0).method_2());
        break;
      case 11:
        this.method_3((byte) ((Class64) class45_0).method_2());
        break;
      case 14:
        this.method_3((byte) ((Class70) class45_0).method_2());
        break;
      case 15:
        this.method_3((byte) ((Class50) class45_0).method_2());
        break;
      case 16:
        this.method_3((byte) ((Class48) class45_0).method_2());
        break;
      case 18:
        this.method_3((byte) ((Class61) class45_0).method_2());
        break;
      case 20:
        this.method_3(Convert.ToByte(((Class49) class45_0).method_2()));
        break;
      case 23:
        this.method_3(Convert.ToByte(((Class47) class45_0).method_2()));
        break;
      default:
        throw new ArgumentOutOfRangeException();
    }
    return (Class45) this;
  }
}
