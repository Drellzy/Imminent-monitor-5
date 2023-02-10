// Decompiled with JetBrains decompiler
// Type: Class38
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

internal sealed class Class38
{
  private Class75[] class75_0;
  private int int_0;
  private string string_0;
  private Class19[] class19_0;
  private byte byte_0;
  private int int_1;

  public Class19[] method_0() => this.class19_0;

  public void method_1(Class19[] class19_1) => this.class19_0 = class19_1;

  public Class75[] method_2() => this.class75_0;

  public void method_3(Class75[] class75_1) => this.class75_0 = class75_1;

  public string method_4() => this.string_0;

  public void method_5(string string_1) => this.string_0 = string_1;

  public int method_6() => this.int_0;

  public void method_7(int int_2) => this.int_0 = int_2;

  public int method_8() => this.int_1;

  public void method_9(int int_2) => this.int_1 = int_2;

  public byte method_10() => this.byte_0;

  public void method_11(byte byte_1) => this.byte_0 = byte_1;

  public bool method_12() => ((uint) this.method_10() & 2U) > 0U;

  public bool method_13() => ((uint) this.method_10() & 16U) > 0U;

  public bool method_14() => ((uint) this.method_10() & 4U) > 0U;
}
