// Decompiled with JetBrains decompiler
// Type: Class53
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Runtime.CompilerServices;

internal sealed class Class53 : Class52
{
  private Class45 class45_0;

  public Class45 method_2() => this.class45_0;

  public void method_3(Class45 class45_1) => this.class45_0 = class45_1;

  [SpecialName]
  public override int vmethod_2() => 6;

  public override Class45 vmethod_3(Class45 class45_1)
  {
    this.method_1(class45_1.method_0());
    if (class45_1.vmethod_2() != 6)
      throw new ArgumentOutOfRangeException();
    this.method_3(((Class53) class45_1).method_2());
    return (Class45) this;
  }

  public override Class45 vmethod_4()
  {
    Class53 class53 = new Class53();
    class53.method_3(this.method_2());
    class53.method_1(this.method_0());
    return (Class45) class53;
  }
}
