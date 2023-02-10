// Decompiled with JetBrains decompiler
// Type: Class17
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

internal sealed class Class17
{
  private int int_0;
  private readonly int int_1;

  public Class17(int int_2, int int_3)
  {
    this.method_1(int_2);
    this.int_1 = int_3;
  }

  public int method_0() => this.int_0;

  public void method_1(int int_2) => this.int_0 = int_2;

  public int method_2() => this.int_1;

  public override bool Equals(object obj)
  {
    Class17 class17_0 = obj as Class17;
    return !(class17_0 == (Class17) null) && this.method_3(class17_0);
  }

  public bool method_3(Class17 class17_0) => class17_0.method_0() == this.method_0();

  public static bool operator ==(Class17 class17_0, Class17 class17_1) => class17_0.method_3(class17_1);

  public static bool operator !=(Class17 class17_0, Class17 class17_1) => !(class17_0 == class17_1);

  public override int GetHashCode() => this.method_0().GetHashCode();

  public override string ToString() => this.method_0().ToString();
}
