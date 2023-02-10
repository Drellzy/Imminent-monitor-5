// Decompiled with JetBrains decompiler
// Type: Class54
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Runtime.CompilerServices;

internal sealed class Class54 : Class52
{
  private int int_0;

  public int method_2() => this.int_0;

  public void method_3(int int_1) => this.int_0 = int_1;

  [SpecialName]
  public override int vmethod_2() => 19;

  public override Class45 vmethod_3(Class45 class45_0)
  {
    this.method_1(class45_0.method_0());
    if (class45_0.vmethod_2() != 19)
      throw new ArgumentOutOfRangeException();
    this.method_3(((Class54) class45_0).method_2());
    return (Class45) this;
  }

  public override Class45 vmethod_4()
  {
    Class54 class54 = new Class54();
    class54.method_3(this.int_0);
    class54.method_1(this.method_0());
    return (Class45) class54;
  }
}
