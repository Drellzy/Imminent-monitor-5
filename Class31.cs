// Decompiled with JetBrains decompiler
// Type: Class31
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System.Runtime.CompilerServices;

internal sealed class Class31 : Class27
{
  private byte byte_0;
  private Class33 class33_0;
  private string string_0;
  private Class33[] class33_1;
  private Class33[] class33_2;
  private Class33 class33_3;

  public byte method_0() => this.byte_0;

  public void method_1(byte byte_1) => this.byte_0 = byte_1;

  public bool method_2() => ((uint) this.method_0() & 1U) > 0U;

  public bool method_3() => ((uint) this.method_0() & 2U) > 0U;

  public Class33 method_4() => this.class33_0;

  public void method_5(Class33 class33_4) => this.class33_0 = class33_4;

  public string method_6() => this.string_0;

  public void method_7(string string_1) => this.string_0 = string_1;

  public Class33[] method_8() => this.class33_1;

  public void method_9(Class33[] class33_4) => this.class33_1 = class33_4;

  public Class33[] method_10() => this.class33_2;

  public void method_11(Class33[] class33_4) => this.class33_2 = class33_4;

  public Class33 method_12() => this.class33_3;

  public void method_13(Class33 class33_4) => this.class33_3 = class33_4;

  [SpecialName]
  public override byte vmethod_0() => 2;
}
