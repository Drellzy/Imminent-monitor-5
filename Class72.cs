// Decompiled with JetBrains decompiler
// Type: Class72
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Runtime.CompilerServices;

internal sealed class Class72 : Class45
{
  private char char_0;

  public char method_2() => this.char_0;

  public void method_3(char char_1) => this.char_0 = char_1;

  [SpecialName]
  public override object vmethod_0() => (object) this.method_2();

  [SpecialName]
  public override void vmethod_1(object object_0) => this.method_3(Convert.ToChar(object_0));

  [SpecialName]
  public override int vmethod_2() => 10;

  public override Class45 vmethod_3(Class45 class45_0)
  {
    this.method_1(class45_0.method_0());
    switch (class45_0.vmethod_2())
    {
      case 0:
        this.method_3((char) ((Class51) class45_0).method_2());
        break;
      case 1:
        this.method_3((char) ((Class62) class45_0).method_2());
        break;
      case 2:
        this.method_3((char) (int) ((Class67) class45_0).method_2());
        break;
      case 3:
        this.method_3((char) ((Class63) class45_0).method_2());
        break;
      case 4:
        this.method_3((char) ((Class69) class45_0).method_2());
        break;
      case 5:
        this.method_3((char) (uint) ((Class65) class45_0).method_2());
        break;
      case 7:
        this.method_3(Convert.ToChar((object) ((Class59) class45_0).method_2()));
        break;
      case 9:
        this.method_3((char) ((Class46) class45_0).method_2());
        break;
      case 10:
        this.method_3(((Class72) class45_0).method_2());
        break;
      case 11:
        this.method_3((char) ((Class64) class45_0).method_2());
        break;
      case 14:
        this.method_3((char) ((Class70) class45_0).method_2());
        break;
      case 18:
        this.method_3((char) ((Class61) class45_0).method_2());
        break;
      case 20:
        this.method_3(Convert.ToChar(((Class49) class45_0).method_2()));
        break;
      case 23:
        this.method_3(Convert.ToChar(((Class47) class45_0).method_2()));
        break;
      default:
        throw new ArgumentOutOfRangeException();
    }
    return (Class45) this;
  }

  public override Class45 vmethod_4()
  {
    Class72 class72 = new Class72();
    class72.method_3(this.char_0);
    class72.method_1(this.method_0());
    return (Class45) class72;
  }
}
