// Decompiled with JetBrains decompiler
// Type: GClass35
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System.Runtime.CompilerServices;

public sealed class GClass35
{
  private GClass35.GDelegate21 gdelegate21_0;
  private GClass35.GDelegate18 gdelegate18_0;
  private GClass35.GDelegate20 gdelegate20_0;
  private GClass35.GDelegate19 gdelegate19_0;
  private GClass35.GDelegate22 gdelegate22_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_0(GClass35.GDelegate21 gdelegate21_1) => this.gdelegate21_0 += gdelegate21_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_1(GClass35.GDelegate21 gdelegate21_1) => this.gdelegate21_0 -= gdelegate21_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_2(GClass35.GDelegate18 gdelegate18_1) => this.gdelegate18_0 += gdelegate18_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_3(GClass35.GDelegate18 gdelegate18_1) => this.gdelegate18_0 -= gdelegate18_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_4(GClass35.GDelegate20 gdelegate20_1) => this.gdelegate20_0 += gdelegate20_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_5(GClass35.GDelegate20 gdelegate20_1) => this.gdelegate20_0 -= gdelegate20_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_6(GClass35.GDelegate19 gdelegate19_1) => this.gdelegate19_0 += gdelegate19_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_7(GClass35.GDelegate19 gdelegate19_1) => this.gdelegate19_0 -= gdelegate19_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_8(GClass35.GDelegate22 gdelegate22_1) => this.gdelegate22_0 += gdelegate22_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_9(GClass35.GDelegate22 gdelegate22_1) => this.gdelegate22_0 -= gdelegate22_1;

  public void method_10(bool bool_0)
  {
    GClass35.GDelegate20 gdelegate200 = this.gdelegate20_0;
    if (gdelegate200 == null)
      return;
    gdelegate200(bool_0);
  }

  public void method_11()
  {
    GClass35.GDelegate21 gdelegate210 = this.gdelegate21_0;
    if (gdelegate210 == null)
      return;
    gdelegate210();
  }

  public void method_12()
  {
    GClass35.GDelegate18 gdelegate180 = this.gdelegate18_0;
    if (gdelegate180 == null)
      return;
    gdelegate180();
  }

  public void method_13(int int_0, double double_0, double double_1)
  {
    GClass35.GDelegate19 gdelegate190 = this.gdelegate19_0;
    if (gdelegate190 == null)
      return;
    gdelegate190(int_0, double_0, double_1);
  }

  public void method_14(string string_0)
  {
    GClass35.GDelegate22 gdelegate220 = this.gdelegate22_0;
    if (gdelegate220 == null)
      return;
    gdelegate220(string_0);
  }

  public delegate void GDelegate18();

  public delegate void GDelegate19(int int_0, double double_0, double double_1);

  public delegate void GDelegate20(bool bool_0);

  public delegate void GDelegate21();

  public delegate void GDelegate22(string string_0);
}
