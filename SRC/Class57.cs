// Decompiled with JetBrains decompiler
// Type: Class57
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Runtime.CompilerServices;

internal sealed class Class57 : Class56
{
  private Array array_0;
  private int[] int_0;

  public Array method_4() => this.array_0;

  public void method_5(Array array_1) => this.array_0 = array_1;

  public int[] method_6() => this.int_0;

  public void method_7(int[] int_1) => this.int_0 = int_1;

  [SpecialName]
  public override object vmethod_6() => this.method_4().GetValue(this.method_6());

  [SpecialName]
  public override void vmethod_7(object object_0) => this.method_4().SetValue(object_0, this.method_6());

  public override Class45 vmethod_4()
  {
    Class57 class57 = new Class57();
    class57.method_5(this.method_4());
    class57.method_7(this.method_6());
    class57.method_3(this.method_2());
    class57.method_1(this.method_0());
    return (Class45) class57;
  }

  [SpecialName]
  public override int vmethod_2() => 21;

  public override Class45 vmethod_3(Class45 class45_0)
  {
    this.method_1(class45_0.method_0());
    Class57 class57 = class45_0.vmethod_2() == 21 ? (Class57) class45_0 : throw new ArgumentOutOfRangeException();
    this.method_5(class57.method_4());
    this.method_7(class57.method_6());
    this.method_3(class57.method_2());
    return (Class45) this;
  }

  public override bool vmethod_8(Class56 class56_0)
  {
    Class57 class57 = (Class57) class56_0;
    return this.method_4() == class57.method_4() && Class79.smethod_0(this.method_6(), class57.method_6());
  }
}
