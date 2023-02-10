// Decompiled with JetBrains decompiler
// Type: Class58
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Runtime.CompilerServices;

internal sealed class Class58 : Class56
{
  private Array array_0;
  private long long_0;

  public Array method_4() => this.array_0;

  public void method_5(Array array_1) => this.array_0 = array_1;

  public long method_6() => this.long_0;

  public void method_7(long long_1) => this.long_0 = long_1;

  [SpecialName]
  public override object vmethod_6() => this.array_0.GetValue(this.long_0);

  [SpecialName]
  public override void vmethod_7(object object_0) => this.array_0.SetValue(object_0, this.long_0);

  [SpecialName]
  public override int vmethod_2() => 17;

  public override Class45 vmethod_3(Class45 class45_0)
  {
    this.method_1(class45_0.method_0());
    Class58 class58 = class45_0.vmethod_2() == 17 ? (Class58) class45_0 : throw new ArgumentOutOfRangeException();
    this.method_5(class58.method_4());
    this.method_7(class58.method_6());
    this.method_3(class58.method_2());
    return (Class45) this;
  }

  public override Class45 vmethod_4()
  {
    Class58 class58 = new Class58();
    class58.method_5(this.array_0);
    class58.method_7(this.long_0);
    class58.method_3(this.method_2());
    class58.method_1(this.method_0());
    return (Class45) class58;
  }

  public override bool vmethod_8(Class56 class56_0)
  {
    Class58 class58 = (Class58) class56_0;
    return this.method_6() == class58.method_6() && this.method_4() == class58.method_4();
  }
}
