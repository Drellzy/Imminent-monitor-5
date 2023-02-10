// Decompiled with JetBrains decompiler
// Type: Class55
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal sealed class Class55 : Class52
{
  private object object_0;
  private FieldInfo fieldInfo_0;

  public object method_2() => this.object_0;

  public void method_3(object object_1) => this.object_0 = object_1;

  public FieldInfo method_4() => this.fieldInfo_0;

  public void method_5(FieldInfo fieldInfo_1) => this.fieldInfo_0 = fieldInfo_1;

  [SpecialName]
  public override int vmethod_2() => 12;

  public override Class45 vmethod_3(Class45 class45_0)
  {
    this.method_1(class45_0.method_0());
    if (class45_0.vmethod_2() != 12)
      throw new ArgumentOutOfRangeException();
    this.method_3(((Class55) class45_0).method_2());
    this.method_5(((Class55) class45_0).method_4());
    return (Class45) this;
  }

  public override Class45 vmethod_4()
  {
    Class55 class55 = new Class55();
    class55.method_3(this.object_0);
    class55.method_5(this.fieldInfo_0);
    class55.method_1(this.method_0());
    return (Class45) class55;
  }
}
