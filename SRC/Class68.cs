// Decompiled with JetBrains decompiler
// Type: Class68
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal sealed class Class68 : Class45
{
  private MethodBase methodBase_0;

  public MethodBase method_2() => this.methodBase_0;

  public void method_3(MethodBase methodBase_1) => this.methodBase_0 = methodBase_1;

  public IntPtr method_4() => this.method_2().MethodHandle.GetFunctionPointer();

  [SpecialName]
  public override object vmethod_0() => (object) this.method_2();

  [SpecialName]
  public override void vmethod_1(object object_0) => this.method_3((MethodBase) object_0);

  [SpecialName]
  public override int vmethod_2() => 22;

  public override Class45 vmethod_3(Class45 class45_0)
  {
    this.method_1(class45_0.method_0());
    if (class45_0.vmethod_2() != 22)
      throw new ArgumentOutOfRangeException();
    this.method_3(((Class68) class45_0).method_2());
    return (Class45) this;
  }

  public override Class45 vmethod_4()
  {
    Class68 class68 = new Class68();
    class68.method_3(this.methodBase_0);
    class68.method_1(this.method_0());
    return (Class45) class68;
  }
}
