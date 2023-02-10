// Decompiled with JetBrains decompiler
// Type: Class60
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Runtime.CompilerServices;

internal sealed class Class60 : Class45
{
  private Array array_0;

  public Array method_2() => this.array_0;

  public void method_3(Array array_1) => this.array_0 = array_1;

  [SpecialName]
  public override object vmethod_0() => (object) this.method_2();

  [SpecialName]
  public override void vmethod_1(object object_0) => this.method_3((Array) object_0);

  public override Class45 vmethod_4()
  {
    Class60 class60 = new Class60();
    class60.method_3(this.array_0);
    class60.method_1(this.method_0());
    return (Class45) class60;
  }

  [SpecialName]
  public override int vmethod_2() => 13;

  public override Class45 vmethod_3(Class45 class45_0)
  {
    this.method_1(class45_0.method_0());
    switch (class45_0.vmethod_2())
    {
      case 13:
        this.method_3(((Class60) class45_0).method_2());
        break;
      case 20:
        this.method_3((Array) ((Class49) class45_0).method_2());
        break;
      default:
        throw new ArgumentOutOfRangeException();
    }
    return (Class45) this;
  }
}
