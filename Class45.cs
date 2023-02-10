// Decompiled with JetBrains decompiler
// Type: Class45
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;

internal abstract class Class45
{
  private Type type_0;

  public abstract object vmethod_0();

  public abstract void vmethod_1(object object_0);

  public abstract int vmethod_2();

  public abstract Class45 vmethod_3(Class45 class45_0);

  public abstract Class45 vmethod_4();

  public virtual bool vmethod_5() => false;

  public Type method_0() => this.type_0;

  public void method_1(Type type_1) => this.type_0 = type_1;
}
