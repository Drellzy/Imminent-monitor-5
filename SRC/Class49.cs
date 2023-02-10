// Decompiled with JetBrains decompiler
// Type: Class49
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System.Runtime.CompilerServices;

internal sealed class Class49 : Class45
{
  private object object_0;

  public object method_2() => this.object_0;

  public void method_3(object object_1) => this.object_0 = object_1;

  [SpecialName]
  public override object vmethod_0() => this.method_2();

  [SpecialName]
  public override void vmethod_1(object object_1) => this.method_3(object_1);

  [SpecialName]
  public override int vmethod_2() => 20;

  public override Class45 vmethod_3(Class45 class45_0)
  {
    this.method_1(class45_0.method_0());
    this.method_3(class45_0.vmethod_0());
    return (Class45) this;
  }

  public override Class45 vmethod_4()
  {
    Class49 class49 = new Class49();
    class49.method_3(this.object_0);
    class49.method_1(this.method_0());
    return (Class45) class49;
  }
}
