// Decompiled with JetBrains decompiler
// Type: Class141
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System.Drawing;

[StandardModule]
internal sealed class Class141
{
  public static Brush smethod_0(int int_0, int int_1, int int_2, int int_3) => (Brush) new SolidBrush(Color.FromArgb(int_0, int_1, int_2, int_3));

  public static Brush smethod_1(int int_0, int int_1, int int_2) => (Brush) new SolidBrush(Color.FromArgb(int_0, int_1, int_2));

  public static Brush smethod_2(int int_0, Color color_0) => (Brush) new SolidBrush(Color.FromArgb(int_0, color_0));

  public static Brush smethod_3(Pen pen_0) => (Brush) new SolidBrush(pen_0.Color);

  public static Brush smethod_4(Color color_0) => (Brush) new SolidBrush(color_0);

  public static Pen smethod_5(int int_0, int int_1, int int_2, int int_3) => new Pen((Brush) new SolidBrush(Color.FromArgb(int_0, int_1, int_2, int_3)));

  public static Pen smethod_6(int int_0, int int_1, int int_2) => new Pen((Brush) new SolidBrush(Color.FromArgb(int_0, int_1, int_2)));

  public static Pen smethod_7(int int_0, Color color_0) => new Pen((Brush) new SolidBrush(Color.FromArgb(int_0, color_0)));

  public static Pen smethod_8(SolidBrush solidBrush_0) => new Pen((Brush) solidBrush_0);

  public static Pen smethod_9(Color color_0) => new Pen((Brush) new SolidBrush(color_0));
}
