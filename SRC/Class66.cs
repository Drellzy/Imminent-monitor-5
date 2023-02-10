// Decompiled with JetBrains decompiler
// Type: Class66
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Runtime.CompilerServices;

internal sealed class Class66 : Class45
{
  private string string_0;

  public string method_2() => this.string_0;

  public void method_3(string string_1) => this.string_0 = string_1;

  [SpecialName]
  public override object vmethod_0() => (object) this.method_2();

  [SpecialName]
  public override void vmethod_1(object object_0) => this.method_3((string) object_0);

  [SpecialName]
  public override int vmethod_2() => 8;

  public override Class45 vmethod_3(Class45 class45_0)
  {
    this.method_1(class45_0.method_0());
    switch (class45_0.vmethod_2())
    {
      case 8:
        this.method_3(((Class66) class45_0).method_2());
        break;
      case 20:
        this.method_3((string) ((Class49) class45_0).method_2());
        break;
      default:
        throw new ArgumentOutOfRangeException();
    }
    return (Class45) this;
  }

  public override Class45 vmethod_4()
  {
    Class66 class66 = new Class66();
    class66.method_3(this.string_0);
    class66.method_1(this.method_0());
    return (Class45) class66;
  }
}
